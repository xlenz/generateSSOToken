using System;
using System.Drawing;
using System.Reflection;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using generateSSOToken.Properties;

namespace generateSSOToken
{
    public partial class Form1 : Form
    {
        private string _ssoXML;
        private string _ssoXMLBack;
        private const string HeaderStart = "<soapenv:Header><wsse:Security soapenv:mustUnderstand=\"0\" xmlns:wsse=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd\">";
        private const string HeaderEnd = "</wsse:Security></soapenv:Header>";
        readonly Color _defaultColor;
        static int _port;

        Thread _thread;

        [SecurityPermissionAttribute(SecurityAction.Demand, ControlThread = true)]
        internal void ThreadDispose()
        {
            if (_thread != null)
            {
                _thread.Abort();
                _thread.Join(2000);
            }
        }

        public Form1()
        {
            var icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
            InitializeComponent();
            Icon = icon;
            const string copyToClipMsg = "Copy to clipboard";
            toolTip1.SetToolTip(BtnCopyToClipboardEnc, copyToClipMsg);
            toolTip1.SetToolTip(BtnCopyToClipboardDec, copyToClipMsg);
            _defaultColor = TbPort.BackColor;
            _port = Convert.ToInt32(TbPort.Text);
            Helpers.Load(TbHostnamePort, TbPort, TbUser, TbPwd, CbWrap, CbCustomSSO, TbSsoHostname);
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ThreadDispose();
        }

        private void BtnGetSSOClick(object sender, EventArgs e)
        {
            if (TbHostnamePort.Text == string.Empty || _port == 0)
                return;
            if (_thread == null || _thread.ThreadState == ThreadState.Stopped)
            {
                _thread = new Thread(ThreadProc)
                {
                    IsBackground = true
                };
                _thread.Start();
            }
            else
            {
                BtnGetSSO.Enabled = false;
                ThreadDispose();
                BtnGetSSO.Text = Resources.Form1_button1_Click_Get_SSO_Token;
                LbGettingSSO.Visible = false;
                BtnGetSSO.Enabled = true;
            }
        }

        private void TbHostnamePortTextChanged(object sender, EventArgs e)
        {
            ReplaceBadChars(TbHostnamePort);
            LbHostnamePort.Visible = TbHostnamePort.Text == string.Empty;
        }

        private void TbSsoHostnameTextChanged(object sender, EventArgs e)
        {
            ReplaceBadChars(TbSsoHostname);
            LbHostnamePort.Visible = TbHostnamePort.Text == string.Empty;
        }

        private static void ReplaceBadChars(TextBoxBase tb)
        {
            if (tb.Text.Contains(" ") || tb.Text.Contains("{") || tb.Text.Contains("}"))
            {
                int beforeLength = tb.Text.Substring(0, tb.SelectionStart).Length;
                tb.Text = tb.Text.Replace(" ", "");
                tb.Text = tb.Text.Replace("{", "");
                tb.Text = tb.Text.Replace("}", "");
                if (beforeLength < 1)
                    beforeLength = 1;
                tb.SelectionStart = beforeLength - 1;
            }
        }

        private void TbPwdTextChanged(object sender, EventArgs e)
        {
            LbPwd.Visible = TbUser.Text.Replace(" ", "") == string.Empty;
        }

        private void TbSSOEncKeyDown(object sender, KeyEventArgs e)
        {
            Helpers.SelectAll(TbSSOEnc, e);
        }

        private void TbHeaderKeyDown(object sender, KeyEventArgs e)
        {
            Helpers.SelectAll(TbHeader, e);
        }

        private void CbWrapCheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_ssoXML)) return;
            WrapXmlWithSOAPHeaders();
            if (!CbWrap.Checked)
                _ssoXML = _ssoXMLBack;

            RichTbSSOXml.Text = _ssoXML;
        }

        private void WrapXmlWithSOAPHeaders()
        {
            if (!CbWrap.Checked) return;
            _ssoXMLBack = _ssoXML;
            _ssoXML = HeaderStart + _ssoXML + HeaderEnd;
        }

        private void BtnCopySSOEncClick(object sender, EventArgs e)
        {
            Helpers.CopyToClilbaord(TbSSOEnc.Text);
        }

        private void BtnCopySSODecClick(object sender, EventArgs e)
        {
            Helpers.CopyToClilbaord(RichTbSSOXml.Text);
        }

        private void BtnCopyHeaderClick(object sender, EventArgs e)
        {
            Helpers.CopyToClilbaord(TbHeader.Text);
        }

        private void TbPortTextChanged(object sender, EventArgs e)
        {
            int tmpNum;
            bool isNum = int.TryParse(TbPort.Text.Trim(), out tmpNum);
            if (isNum && tmpNum > 1 && tmpNum < 65535)
            {
                _port = tmpNum;
                TbPort.BackColor = _defaultColor;
            }
            else
            {
                _port = 0;
                TbPort.BackColor = Color.Red;
            }
        }

        void ThreadProc()
        {
            Helpers.BtnEnable(BtnGetSSO, false);
            var hostname = TbHostnamePort.Text;
            var ssoHostname = CbCustomSSO.Checked ? TbSsoHostname.Text : null;
            var user = TbUser.Text;
            var pwd = TbPwd.Text;
            Helpers.LbVisible(LbGettingSSO, true);
            Helpers.CtlText(BtnGetSSO, "Abort");
            Helpers.BtnEnable(BtnGetSSO, true);
            try
            {
                _ssoXML = new SSO(hostname, user, pwd, isBase64: false, ssoPort: _port.ToString(), ssoHostname: ssoHostname).Get();
                var ssoBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(_ssoXML));
                Helpers.Save(hostname, _port, user, pwd, CbWrap.Checked, CbCustomSSO.Checked, ssoHostname);
                Helpers.CtlText(groupBox2, "Result (for user " + user + ")");
                WrapXmlWithSOAPHeaders();
                Helpers.CtlText(TbSSOEnc, ssoBase64);
                Helpers.CtlText(RichTbSSOXml, _ssoXML);
            }
            catch (Exception exception)
            {
                if (!exception.Message.ToLower().Contains("Thread was being aborted.".ToLower()))
                {
                    MessageBox.Show(exception.Message, "Error obtaining SSO Token", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    _ssoXMLBack = _ssoXML = string.Empty;
                    Helpers.CtlText(TbSSOEnc, string.Empty);
                    Helpers.CtlText(RichTbSSOXml, string.Empty);
                    Helpers.CtlText(groupBox2, "Result ");
                }
            }
            finally
            {
                if (_thread != null && _thread.ThreadState == ThreadState.Background)
                {
                    Helpers.CtlText(BtnGetSSO, Resources.Form1_button1_Click_Get_SSO_Token);
                    Helpers.LbVisible(LbGettingSSO, false);
                    ThreadDispose();
                }
            }
        }

        private void CustomSSOCheckedChanged(object sender, EventArgs e)
        {
            TbSsoHostname.Enabled = CbCustomSSO.Checked;
        }
    }
}

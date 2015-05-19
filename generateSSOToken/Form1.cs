using System;
using System.Drawing;
using System.Reflection;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;
using generateSSOToken.Properties;
using generateSSOToken.SSO;

namespace generateSSOToken
{
    public partial class Form1 : Form
    {
        private SsoToken _sso;
        readonly Color _defaultColor;
        static int _port;
        private const string HeaderStart = "<soapenv:Header><wsse:Security soapenv:mustUnderstand=\"0\" xmlns:wsse=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd\">";
        private const string HeaderEnd = "</wsse:Security></soapenv:Header>";

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
            copyToClipboardToolTip.SetToolTip(BtnCopyToClipboardEnc, copyToClipMsg);
            copyToClipboardToolTip.SetToolTip(BtnCopyToClipboardDec, copyToClipMsg);
            copyToClipboardToolTip.SetToolTip(BtnCopyHeader, copyToClipMsg);
            copyToClipboardToolTip.SetToolTip(BtnCopyToClipboardSoapUi, copyToClipMsg);
            _defaultColor = TbPort.BackColor;
            _port = Convert.ToInt32(TbPort.Text);
            Helpers.Load(TbOeHost, TbPort, TbUser, TbPwd, cbUseHttps);
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ThreadDispose();
        }

        private void BtnGetSsoClick(object sender, EventArgs e)
        {
            if (TbOeHost.Text == string.Empty || _port == 0)
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
            ReplaceBadChars(TbOeHost);
            LbHostnamePort.Visible = TbOeHost.Text == string.Empty;
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

        private void TbSsoEncKeyDown(object sender, KeyEventArgs e)
        {
            Helpers.SelectAll(TbSSOEnc, e);
        }
        
        private void TbHeaderKeyDown(object sender, KeyEventArgs e)
        {
            Helpers.SelectAll(TbHeader, e);
        }

        private void TbSoapUiHeader_KeyDown(object sender, KeyEventArgs e)
        {
            Helpers.SelectAll(TbSoapUiHeader, e);
        }
        
        private void BtnCopySsoEncClick(object sender, EventArgs e)
        {
            Helpers.CopyToClilbaord(TbSSOEnc.Text);
        }

        private void BtnCopySsoDecClick(object sender, EventArgs e)
        {
            Helpers.CopyToClilbaord(RichTbSSOXml.Text);
        }

        private void BtnCopyHeaderClick(object sender, EventArgs e)
        {
            Helpers.CopyToClilbaord(TbHeader.Text);
        }

        private void BtnCopyToClipboardSoapUi_Click(object sender, EventArgs e)
        {
            Helpers.CopyToClilbaord(TbSoapUiHeader.Text);
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
            var oeHost = TbOeHost.Text;
            var user = TbUser.Text;
            var pwd = TbPwd.Text;
            bool useHttps = cbUseHttps.Checked;
            Helpers.LbVisible(LbGettingSSO, true);
            Helpers.CtlText(BtnGetSSO, "Abort");
            Helpers.BtnEnable(BtnGetSSO, true);
            try
            {
                _sso = new SsoToken(oeHost, user, pwd, _port.ToString(), useHttps);
                Helpers.Save(oeHost, _port, user, pwd, useHttps);
                Helpers.CtlText(GbResults, "Result (for user " + user + ")");
                Helpers.CtlText(TbSSOEnc, _sso.GetBase64());
                Helpers.CtlText(TbSoapUiHeader, HeaderStart + _sso.GetDecoded() + HeaderEnd);
                Helpers.CtlText(RichTbSSOXml, _sso.GetXmlString());
            }
            catch (Exception exception)
            {
                if (!exception.Message.ToLower().Contains("Thread was being aborted.".ToLower()))
                {
                    MessageBox.Show(exception.Message, "Error obtaining SSO Token", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    Helpers.CtlText(TbSSOEnc, string.Empty);
                    Helpers.CtlText(TbSoapUiHeader, string.Empty);
                    Helpers.CtlText(RichTbSSOXml, string.Empty);
                    Helpers.CtlText(GbResults, "Result ");
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
    }
}

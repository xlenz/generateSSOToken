using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace generateSSOToken
{
    class Helpers
    {
        static readonly string AppFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "getSSOToken");
        const string Properties = "config.properties";
        private const string KeyHost = "host";
        private const string KeySSOPort = "SSOPort";
        private const string KeyUser = "user";
        private const string KeyPwd = "pwd";
        private const string KeyWrap = "wrap";
        private const char Splitter = '=';

        internal static void Save(string hostnamePort, int ssoPort, string user, string pwd, bool wrap)
        {
            var path = Path.Combine(AppFolder, Properties);
            if (!File.Exists(AppFolder))
                Directory.CreateDirectory(AppFolder);
            var list = new List<string>
            {
                KeyHost + Splitter + hostnamePort,
                KeySSOPort + Splitter + ssoPort,
                KeyUser + Splitter + user,
                KeyPwd + Splitter + pwd,
                KeyWrap + Splitter + wrap
            };

            File.WriteAllLines(path, list.ToArray());
        }

        internal static void Load(TextBoxBase hostnamePort, TextBoxBase ssoPort, TextBoxBase user, TextBoxBase pwd, CheckBox cbWrap)
        {
            var path = Path.Combine(AppFolder, Properties);
            if (!File.Exists(path))
                return;

            var file = File.ReadAllLines(path);

            foreach (var line in file)
            {
                var keyPair = line.Trim().Split(Splitter);
                var key = keyPair[0].ToLower();
                var value = string.Empty;
                if (keyPair.Length > 1)
                    value = keyPair[1];
                switch (key)
                {
                    case KeyHost:
                        hostnamePort.Text = value;
                        break;
                    case KeySSOPort:
                        ssoPort.Text = value;
                        break;
                    case KeyUser:
                        user.Text = value;
                        break;
                    case KeyPwd:
                        pwd.Text = value;
                        break;
                    case KeyWrap:
                        bool flag;
                        Boolean.TryParse(value, out flag);
                        cbWrap.Checked = flag;
                        break;
                }
            }
        }

        internal static void SelectAll(TextBoxBase textBox, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
                textBox.SelectAll();
        }

        internal static void CopyToClilbaord(string text)
        {
            if (string.IsNullOrEmpty(text)) return;
            try
            {
                Clipboard.SetText(text);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Failed to copy to clipboard.", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        delegate void EnableButtonHandler(Button btn, bool enable);
        internal static void BtnEnable(Button btn, bool enable)
        {
            if (!btn.InvokeRequired)
            {
                btn.Enabled = enable;
            }
            else
            {
                btn.Invoke(new EnableButtonHandler(BtnEnable), btn, enable);
            }
        }

        delegate void VisibilityLabelHandler(Label lb, bool enable);
        internal static void LbVisible(Label lb, bool enable)
        {
            if (!lb.InvokeRequired)
            {
                lb.Visible = enable;
            }
            else
            {
                lb.Invoke(new VisibilityLabelHandler(LbVisible), lb, enable);
            }
        }
        /*
        delegate void ButtonTextHandler(Button btn, string text);
        internal static void BtnText(Button btn, string text)
        {
            if (!btn.InvokeRequired)
            {
                btn.Text = text;
            }
            else
            {
                btn.Invoke(new ButtonTextHandler(BtnText), btn, text);
            }
        }
        */
        delegate void CtlTextHandler(Control ctl, string text);
        internal static void CtlText(Control ctl, string text)
        {
            if (!ctl.InvokeRequired)
            {
                ctl.Text = text;
            }
            else
            {
                ctl.Invoke(new CtlTextHandler(CtlText), ctl, text);
            }
        }
    }
}

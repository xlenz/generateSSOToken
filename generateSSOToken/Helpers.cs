using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace generateSSOToken
{
    class Helpers
    {
        private static readonly string AppFolder =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "getSSOToken");

        const string Properties = "config.properties";
        private const string KeyHost = "OEHost";
        private const string KeySsoPort = "OEPort";
        private const string KeyUser = "user";
        private const string KeyPwd = "pwd";
        private const string KeyUseHttps = "useHttps";
        private const char Splitter = '=';

        internal static void Save(string oeHost, int oePort, string user, string pwd, bool useHttps)
        {
            var path = Path.Combine(AppFolder, Properties);
            if (!File.Exists(AppFolder))
                Directory.CreateDirectory(AppFolder);
            var list = new List<string>
            {
                KeyHost + Splitter + oeHost,
                KeySsoPort + Splitter + oePort,
                KeyUser + Splitter + user,
                KeyPwd + Splitter + pwd,
                KeyUseHttps + Splitter + useHttps
            };

            File.WriteAllLines(path, list.ToArray());
        }

        internal static void Load(TextBoxBase oeHost, TextBoxBase oePort, TextBoxBase user, TextBoxBase pwd, CheckBox useHttps)
        {
            var path = Path.Combine(AppFolder, Properties);
            if (!File.Exists(path))
            {
                return;
            }

            var file = File.ReadAllLines(path);

            foreach (var line in file)
            {
                var keyPair = line.Trim().Split(Splitter);
                var key = keyPair[0];
                var value = string.Empty;
                if (keyPair.Length > 1)
                {
                    value = keyPair[1];
                }
                switch (key)
                {
                    case KeyHost:
                        oeHost.Text = value;
                        break;
                    case KeySsoPort:
                        oePort.Text = value;
                        break;
                    case KeyUser:
                        user.Text = value;
                        break;
                    case KeyPwd:
                        pwd.Text = value;
                        break;
                    case KeyUseHttps:
                        bool flagHttps;
                        Boolean.TryParse(value, out flagHttps);
                        useHttps.Checked = flagHttps;
                        break;
                }
            }
        }

        internal static void SelectAll(TextBoxBase textBox, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                textBox.SelectAll();
            }
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

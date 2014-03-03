namespace generateSSOToken
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.TbHostnamePort = new System.Windows.Forms.TextBox();
            this.TbUser = new System.Windows.Forms.TextBox();
            this.TbPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboHistory = new System.Windows.Forms.ComboBox();
            this.CbCustomSSO = new System.Windows.Forms.CheckBox();
            this.TbSsoHostname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TbPort = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnCopyHeader = new System.Windows.Forms.Button();
            this.TbHeader = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCopyToClipboardEnc = new System.Windows.Forms.Button();
            this.TbSSOEnc = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RichTbSSOXml = new System.Windows.Forms.RichTextBox();
            this.BtnCopyToClipboardDec = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CbWrap = new System.Windows.Forms.CheckBox();
            this.BtnGetSSO = new System.Windows.Forms.Button();
            this.LbHostnamePort = new System.Windows.Forms.Label();
            this.LbPwd = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.LbGettingSSO = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SBM hostname:port";
            // 
            // TbHostnamePort
            // 
            this.TbHostnamePort.Location = new System.Drawing.Point(6, 32);
            this.TbHostnamePort.MaxLength = 1000;
            this.TbHostnamePort.Name = "TbHostnamePort";
            this.TbHostnamePort.Size = new System.Drawing.Size(154, 20);
            this.TbHostnamePort.TabIndex = 1;
            this.TbHostnamePort.Text = "stl-qa-oalmt3";
            this.TbHostnamePort.TextChanged += new System.EventHandler(this.TbHostnamePortTextChanged);
            // 
            // TbUser
            // 
            this.TbUser.Location = new System.Drawing.Point(6, 115);
            this.TbUser.MaxLength = 100;
            this.TbUser.Name = "TbUser";
            this.TbUser.Size = new System.Drawing.Size(248, 20);
            this.TbUser.TabIndex = 2;
            this.TbUser.Text = "admin";
            this.TbUser.TextChanged += new System.EventHandler(this.TbPwdTextChanged);
            // 
            // TbPwd
            // 
            this.TbPwd.Location = new System.Drawing.Point(6, 154);
            this.TbPwd.MaxLength = 100;
            this.TbPwd.Name = "TbPwd";
            this.TbPwd.Size = new System.Drawing.Size(248, 20);
            this.TbPwd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "user";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ComboHistory);
            this.groupBox1.Controls.Add(this.CbCustomSSO);
            this.groupBox1.Controls.Add(this.TbSsoHostname);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TbPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TbPwd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TbHostnamePort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbUser);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 180);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection details";
            // 
            // ComboHistory
            // 
            this.ComboHistory.FormattingEnabled = true;
            this.ComboHistory.Location = new System.Drawing.Point(167, 32);
            this.ComboHistory.Name = "ComboHistory";
            this.ComboHistory.Size = new System.Drawing.Size(87, 21);
            this.ComboHistory.TabIndex = 10;
            this.ComboHistory.Visible = false;
            // 
            // CbCustomSSO
            // 
            this.CbCustomSSO.AutoSize = true;
            this.CbCustomSSO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbCustomSSO.Location = new System.Drawing.Point(6, 55);
            this.CbCustomSSO.Name = "CbCustomSSO";
            this.CbCustomSSO.Size = new System.Drawing.Size(153, 17);
            this.CbCustomSSO.TabIndex = 9;
            this.CbCustomSSO.Text = "custom SSO hostname";
            this.CbCustomSSO.UseVisualStyleBackColor = true;
            this.CbCustomSSO.CheckedChanged += new System.EventHandler(this.CustomSSOCheckedChanged);
            // 
            // TbSsoHostname
            // 
            this.TbSsoHostname.Enabled = false;
            this.TbSsoHostname.Location = new System.Drawing.Point(6, 76);
            this.TbSsoHostname.Name = "TbSsoHostname";
            this.TbSsoHostname.Size = new System.Drawing.Size(154, 20);
            this.TbSsoHostname.TabIndex = 8;
            this.TbSsoHostname.TextChanged += new System.EventHandler(this.TbSsoHostnameTextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(197, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "SSO Port";
            // 
            // TbPort
            // 
            this.TbPort.Location = new System.Drawing.Point(200, 76);
            this.TbPort.MaxLength = 5;
            this.TbPort.Name = "TbPort";
            this.TbPort.Size = new System.Drawing.Size(54, 20);
            this.TbPort.TabIndex = 6;
            this.TbPort.Text = "8085";
            this.TbPort.TextChanged += new System.EventHandler(this.TbPortTextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 183);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.BtnCopyHeader);
            this.groupBox4.Controls.Add(this.TbHeader);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.BtnCopyToClipboardEnc);
            this.groupBox4.Controls.Add(this.TbSSOEnc);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(9, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(334, 62);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "REST:";
            // 
            // BtnCopyHeader
            // 
            this.BtnCopyHeader.BackgroundImage = global::generateSSOToken.Properties.Resources.clipCopy16;
            this.BtnCopyHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCopyHeader.Location = new System.Drawing.Point(129, 30);
            this.BtnCopyHeader.Name = "BtnCopyHeader";
            this.BtnCopyHeader.Size = new System.Drawing.Size(22, 22);
            this.BtnCopyHeader.TabIndex = 8;
            this.BtnCopyHeader.UseVisualStyleBackColor = true;
            this.BtnCopyHeader.Click += new System.EventHandler(this.BtnCopyHeaderClick);
            // 
            // TbHeader
            // 
            this.TbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbHeader.Location = new System.Drawing.Point(9, 32);
            this.TbHeader.MaxLength = 30;
            this.TbHeader.Name = "TbHeader";
            this.TbHeader.ReadOnly = true;
            this.TbHeader.Size = new System.Drawing.Size(114, 20);
            this.TbHeader.TabIndex = 4;
            this.TbHeader.Text = "ALFSSOAuthNToken";
            this.TbHeader.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbHeaderKeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Header";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(154, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Base64 SSO Token";
            // 
            // BtnCopyToClipboardEnc
            // 
            this.BtnCopyToClipboardEnc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCopyToClipboardEnc.BackgroundImage = global::generateSSOToken.Properties.Resources.clipCopy16;
            this.BtnCopyToClipboardEnc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCopyToClipboardEnc.Location = new System.Drawing.Point(306, 30);
            this.BtnCopyToClipboardEnc.Name = "BtnCopyToClipboardEnc";
            this.BtnCopyToClipboardEnc.Size = new System.Drawing.Size(22, 22);
            this.BtnCopyToClipboardEnc.TabIndex = 7;
            this.BtnCopyToClipboardEnc.UseVisualStyleBackColor = true;
            this.BtnCopyToClipboardEnc.Click += new System.EventHandler(this.BtnCopySSOEncClick);
            // 
            // TbSSOEnc
            // 
            this.TbSSOEnc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbSSOEnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbSSOEnc.Location = new System.Drawing.Point(157, 32);
            this.TbSSOEnc.Name = "TbSSOEnc";
            this.TbSSOEnc.ReadOnly = true;
            this.TbSSOEnc.Size = new System.Drawing.Size(143, 20);
            this.TbSSOEnc.TabIndex = 2;
            this.TbSSOEnc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSSOEncKeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.RichTbSSOXml);
            this.groupBox3.Controls.Add(this.BtnCopyToClipboardDec);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.CbWrap);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(9, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 90);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SOAP:";
            // 
            // RichTbSSOXml
            // 
            this.RichTbSSOXml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTbSSOXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTbSSOXml.Location = new System.Drawing.Point(6, 35);
            this.RichTbSSOXml.Name = "RichTbSSOXml";
            this.RichTbSSOXml.ReadOnly = true;
            this.RichTbSSOXml.Size = new System.Drawing.Size(322, 49);
            this.RichTbSSOXml.TabIndex = 3;
            this.RichTbSSOXml.Text = "";
            // 
            // BtnCopyToClipboardDec
            // 
            this.BtnCopyToClipboardDec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCopyToClipboardDec.BackgroundImage = global::generateSSOToken.Properties.Resources.clipCopy16;
            this.BtnCopyToClipboardDec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCopyToClipboardDec.Location = new System.Drawing.Point(306, 11);
            this.BtnCopyToClipboardDec.Name = "BtnCopyToClipboardDec";
            this.BtnCopyToClipboardDec.Size = new System.Drawing.Size(22, 22);
            this.BtnCopyToClipboardDec.TabIndex = 8;
            this.BtnCopyToClipboardDec.UseVisualStyleBackColor = true;
            this.BtnCopyToClipboardDec.Click += new System.EventHandler(this.BtnCopySSODecClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Xml SSO Token";
            // 
            // CbWrap
            // 
            this.CbWrap.AutoSize = true;
            this.CbWrap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbWrap.Location = new System.Drawing.Point(129, 16);
            this.CbWrap.Name = "CbWrap";
            this.CbWrap.Size = new System.Drawing.Size(176, 17);
            this.CbWrap.TabIndex = 6;
            this.CbWrap.Text = "Wrap with soapUI headers";
            this.CbWrap.UseVisualStyleBackColor = true;
            this.CbWrap.CheckedChanged += new System.EventHandler(this.CbWrapCheckedChanged);
            // 
            // BtnGetSSO
            // 
            this.BtnGetSSO.Location = new System.Drawing.Point(21, 198);
            this.BtnGetSSO.Name = "BtnGetSSO";
            this.BtnGetSSO.Size = new System.Drawing.Size(98, 23);
            this.BtnGetSSO.TabIndex = 8;
            this.BtnGetSSO.Text = "Get SSO Token";
            this.BtnGetSSO.UseVisualStyleBackColor = true;
            this.BtnGetSSO.Click += new System.EventHandler(this.BtnGetSSOClick);
            // 
            // LbHostnamePort
            // 
            this.LbHostnamePort.AutoSize = true;
            this.LbHostnamePort.ForeColor = System.Drawing.Color.DarkRed;
            this.LbHostnamePort.Location = new System.Drawing.Point(272, 51);
            this.LbHostnamePort.Name = "LbHostnamePort";
            this.LbHostnamePort.Size = new System.Drawing.Size(87, 13);
            this.LbHostnamePort.TabIndex = 9;
            this.LbHostnamePort.Text = "Cannot be empty";
            this.LbHostnamePort.Visible = false;
            // 
            // LbPwd
            // 
            this.LbPwd.AutoSize = true;
            this.LbPwd.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.LbPwd.Location = new System.Drawing.Point(272, 122);
            this.LbPwd.Name = "LbPwd";
            this.LbPwd.Size = new System.Drawing.Size(88, 13);
            this.LbPwd.TabIndex = 10;
            this.LbPwd.Text = "No user provided";
            this.LbPwd.Visible = false;
            // 
            // LbGettingSSO
            // 
            this.LbGettingSSO.AutoSize = true;
            this.LbGettingSSO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbGettingSSO.ForeColor = System.Drawing.Color.DarkGreen;
            this.LbGettingSSO.Location = new System.Drawing.Point(125, 203);
            this.LbGettingSSO.Name = "LbGettingSSO";
            this.LbGettingSSO.Size = new System.Drawing.Size(163, 13);
            this.LbGettingSSO.TabIndex = 11;
            this.LbGettingSSO.Text = "Getting SSO Token in progress...";
            this.LbGettingSSO.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(164, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "History";
            this.label6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 422);
            this.Controls.Add(this.LbGettingSSO);
            this.Controls.Add(this.LbPwd);
            this.Controls.Add(this.LbHostnamePort);
            this.Controls.Add(this.BtnGetSSO);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(390, 440);
            this.Name = "Form1";
            this.Text = "getSSOToken";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbHostnamePort;
        private System.Windows.Forms.TextBox TbUser;
        private System.Windows.Forms.TextBox TbPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TbSSOEnc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox RichTbSSOXml;
        private System.Windows.Forms.Button BtnGetSSO;
        private System.Windows.Forms.Label LbHostnamePort;
        private System.Windows.Forms.Label LbPwd;
        private System.Windows.Forms.TextBox TbHeader;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox CbWrap;
        private System.Windows.Forms.Button BtnCopyToClipboardDec;
        private System.Windows.Forms.Button BtnCopyToClipboardEnc;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbPort;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LbGettingSSO;
        private System.Windows.Forms.Button BtnCopyHeader;
        private System.Windows.Forms.TextBox TbSsoHostname;
        private System.Windows.Forms.CheckBox CbCustomSSO;
        private System.Windows.Forms.ComboBox ComboHistory;
        private System.Windows.Forms.Label label6;
    }
}


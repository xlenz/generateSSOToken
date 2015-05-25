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
            this.TbOeHost = new System.Windows.Forms.TextBox();
            this.TbUser = new System.Windows.Forms.TextBox();
            this.TbPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbUseHttps = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TbPort = new System.Windows.Forms.TextBox();
            this.GbResults = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnCopyHeader = new System.Windows.Forms.Button();
            this.TbHeader = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCopyToClipboardEnc = new System.Windows.Forms.Button();
            this.TbSSOEnc = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnCopyToClipboardSoapUi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TbSoapUiHeader = new System.Windows.Forms.TextBox();
            this.RichTbSSOXml = new System.Windows.Forms.RichTextBox();
            this.BtnCopyToClipboardDec = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnGetSSO = new System.Windows.Forms.Button();
            this.LbHostnamePort = new System.Windows.Forms.Label();
            this.LbPwd = new System.Windows.Forms.Label();
            this.copyToClipboardToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LbGettingSSO = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.GbResults.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "OE Host";
            // 
            // TbOeHost
            // 
            this.TbOeHost.Location = new System.Drawing.Point(6, 32);
            this.TbOeHost.MaxLength = 200;
            this.TbOeHost.Name = "TbOeHost";
            this.TbOeHost.Size = new System.Drawing.Size(204, 20);
            this.TbOeHost.TabIndex = 1;
            this.TbOeHost.Text = "stl-qa-oalmt1";
            this.TbOeHost.TextChanged += new System.EventHandler(this.TbHostnamePortTextChanged);
            // 
            // TbUser
            // 
            this.TbUser.Location = new System.Drawing.Point(6, 107);
            this.TbUser.MaxLength = 100;
            this.TbUser.Name = "TbUser";
            this.TbUser.Size = new System.Drawing.Size(264, 20);
            this.TbUser.TabIndex = 4;
            this.TbUser.Text = "admin";
            this.TbUser.TextChanged += new System.EventHandler(this.TbPwdTextChanged);
            // 
            // TbPwd
            // 
            this.TbPwd.Location = new System.Drawing.Point(6, 146);
            this.TbPwd.MaxLength = 100;
            this.TbPwd.Name = "TbPwd";
            this.TbPwd.Size = new System.Drawing.Size(264, 20);
            this.TbPwd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "user";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LbGettingSSO);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbUseHttps);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.BtnGetSSO);
            this.groupBox1.Controls.Add(this.TbPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TbPwd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TbOeHost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbUser);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 200);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Use https?";
            // 
            // cbUseHttps
            // 
            this.cbUseHttps.AutoSize = true;
            this.cbUseHttps.Location = new System.Drawing.Point(6, 71);
            this.cbUseHttps.Name = "cbUseHttps";
            this.cbUseHttps.Size = new System.Drawing.Size(49, 17);
            this.cbUseHttps.TabIndex = 3;
            this.cbUseHttps.Text = "https";
            this.cbUseHttps.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(213, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "OE Port";
            // 
            // TbPort
            // 
            this.TbPort.Location = new System.Drawing.Point(216, 32);
            this.TbPort.MaxLength = 5;
            this.TbPort.Name = "TbPort";
            this.TbPort.Size = new System.Drawing.Size(54, 20);
            this.TbPort.TabIndex = 2;
            this.TbPort.Text = "8085";
            this.TbPort.TextChanged += new System.EventHandler(this.TbPortTextChanged);
            // 
            // GbResults
            // 
            this.GbResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbResults.Controls.Add(this.groupBox4);
            this.GbResults.Controls.Add(this.groupBox3);
            this.GbResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbResults.Location = new System.Drawing.Point(12, 218);
            this.GbResults.Name = "GbResults";
            this.GbResults.Size = new System.Drawing.Size(360, 191);
            this.GbResults.TabIndex = 29;
            this.GbResults.TabStop = false;
            this.GbResults.Text = "Result";
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
            this.groupBox4.Size = new System.Drawing.Size(344, 62);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "REST:";
            // 
            // BtnCopyHeader
            // 
            this.BtnCopyHeader.BackgroundImage = global::generateSSOToken.Properties.Resources.clipCopy16;
            this.BtnCopyHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCopyHeader.Location = new System.Drawing.Point(129, 31);
            this.BtnCopyHeader.Name = "BtnCopyHeader";
            this.BtnCopyHeader.Size = new System.Drawing.Size(22, 22);
            this.BtnCopyHeader.TabIndex = 9;
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
            this.TbHeader.TabIndex = 8;
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
            this.label8.TabIndex = 31;
            this.label8.Text = "Header";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(154, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Base64 SSO Token";
            // 
            // BtnCopyToClipboardEnc
            // 
            this.BtnCopyToClipboardEnc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCopyToClipboardEnc.BackgroundImage = global::generateSSOToken.Properties.Resources.clipCopy16;
            this.BtnCopyToClipboardEnc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCopyToClipboardEnc.Location = new System.Drawing.Point(316, 31);
            this.BtnCopyToClipboardEnc.Name = "BtnCopyToClipboardEnc";
            this.BtnCopyToClipboardEnc.Size = new System.Drawing.Size(22, 22);
            this.BtnCopyToClipboardEnc.TabIndex = 11;
            this.BtnCopyToClipboardEnc.UseVisualStyleBackColor = true;
            this.BtnCopyToClipboardEnc.Click += new System.EventHandler(this.BtnCopySsoEncClick);
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
            this.TbSSOEnc.Size = new System.Drawing.Size(153, 20);
            this.TbSSOEnc.TabIndex = 10;
            this.TbSSOEnc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSsoEncKeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.BtnCopyToClipboardSoapUi);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TbSoapUiHeader);
            this.groupBox3.Controls.Add(this.RichTbSSOXml);
            this.groupBox3.Controls.Add(this.BtnCopyToClipboardDec);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(9, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 98);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SOAP:";
            // 
            // BtnCopyToClipboardSoapUi
            // 
            this.BtnCopyToClipboardSoapUi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCopyToClipboardSoapUi.BackgroundImage = global::generateSSOToken.Properties.Resources.clipCopy16;
            this.BtnCopyToClipboardSoapUi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCopyToClipboardSoapUi.Location = new System.Drawing.Point(165, 31);
            this.BtnCopyToClipboardSoapUi.Name = "BtnCopyToClipboardSoapUi";
            this.BtnCopyToClipboardSoapUi.Size = new System.Drawing.Size(22, 22);
            this.BtnCopyToClipboardSoapUi.TabIndex = 13;
            this.BtnCopyToClipboardSoapUi.UseVisualStyleBackColor = true;
            this.BtnCopyToClipboardSoapUi.Click += new System.EventHandler(this.BtnCopyToClipboardSoapUiClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Soap UI header";
            // 
            // TbSoapUiHeader
            // 
            this.TbSoapUiHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbSoapUiHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbSoapUiHeader.Location = new System.Drawing.Point(6, 32);
            this.TbSoapUiHeader.Name = "TbSoapUiHeader";
            this.TbSoapUiHeader.ReadOnly = true;
            this.TbSoapUiHeader.Size = new System.Drawing.Size(153, 20);
            this.TbSoapUiHeader.TabIndex = 12;
            this.TbSoapUiHeader.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSoapUiHeaderKeyDown);
            // 
            // RichTbSSOXml
            // 
            this.RichTbSSOXml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTbSSOXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTbSSOXml.Location = new System.Drawing.Point(6, 73);
            this.RichTbSSOXml.Name = "RichTbSSOXml";
            this.RichTbSSOXml.ReadOnly = true;
            this.RichTbSSOXml.Size = new System.Drawing.Size(332, 19);
            this.RichTbSSOXml.TabIndex = 14;
            this.RichTbSSOXml.Text = "";
            // 
            // BtnCopyToClipboardDec
            // 
            this.BtnCopyToClipboardDec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCopyToClipboardDec.BackgroundImage = global::generateSSOToken.Properties.Resources.clipCopy16;
            this.BtnCopyToClipboardDec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCopyToClipboardDec.Location = new System.Drawing.Point(316, 48);
            this.BtnCopyToClipboardDec.Name = "BtnCopyToClipboardDec";
            this.BtnCopyToClipboardDec.Size = new System.Drawing.Size(22, 22);
            this.BtnCopyToClipboardDec.TabIndex = 15;
            this.BtnCopyToClipboardDec.UseVisualStyleBackColor = true;
            this.BtnCopyToClipboardDec.Click += new System.EventHandler(this.BtnCopySsoDecClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Full Xml SSO Token";
            // 
            // BtnGetSSO
            // 
            this.BtnGetSSO.Location = new System.Drawing.Point(6, 172);
            this.BtnGetSSO.Name = "BtnGetSSO";
            this.BtnGetSSO.Size = new System.Drawing.Size(98, 23);
            this.BtnGetSSO.TabIndex = 7;
            this.BtnGetSSO.Text = "Get SSO Token";
            this.BtnGetSSO.UseVisualStyleBackColor = true;
            this.BtnGetSSO.Click += new System.EventHandler(this.BtnGetSsoClick);
            // 
            // LbHostnamePort
            // 
            this.LbHostnamePort.AutoSize = true;
            this.LbHostnamePort.ForeColor = System.Drawing.Color.DarkRed;
            this.LbHostnamePort.Location = new System.Drawing.Point(295, 47);
            this.LbHostnamePort.Name = "LbHostnamePort";
            this.LbHostnamePort.Size = new System.Drawing.Size(87, 13);
            this.LbHostnamePort.TabIndex = 23;
            this.LbHostnamePort.Text = "Cannot be empty";
            this.LbHostnamePort.Visible = false;
            // 
            // LbPwd
            // 
            this.LbPwd.AutoSize = true;
            this.LbPwd.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.LbPwd.Location = new System.Drawing.Point(294, 130);
            this.LbPwd.Name = "LbPwd";
            this.LbPwd.Size = new System.Drawing.Size(88, 13);
            this.LbPwd.TabIndex = 26;
            this.LbPwd.Text = "No user provided";
            this.LbPwd.Visible = false;
            // 
            // LbGettingSSO
            // 
            this.LbGettingSSO.AutoSize = true;
            this.LbGettingSSO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbGettingSSO.ForeColor = System.Drawing.Color.DarkGreen;
            this.LbGettingSSO.Location = new System.Drawing.Point(110, 178);
            this.LbGettingSSO.Name = "LbGettingSSO";
            this.LbGettingSSO.Size = new System.Drawing.Size(163, 13);
            this.LbGettingSSO.TabIndex = 28;
            this.LbGettingSSO.Text = "Getting SSO Token in progress...";
            this.LbGettingSSO.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 421);
            this.Controls.Add(this.LbPwd);
            this.Controls.Add(this.LbHostnamePort);
            this.Controls.Add(this.GbResults);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(340, 433);
            this.Name = "Form1";
            this.Text = "getSSOToken";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GbResults.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbOeHost;
        private System.Windows.Forms.TextBox TbUser;
        private System.Windows.Forms.TextBox TbPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GbResults;
        private System.Windows.Forms.TextBox TbSSOEnc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox RichTbSSOXml;
        private System.Windows.Forms.Button BtnGetSSO;
        private System.Windows.Forms.Label LbHostnamePort;
        private System.Windows.Forms.Label LbPwd;
        private System.Windows.Forms.TextBox TbHeader;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnCopyToClipboardDec;
        private System.Windows.Forms.Button BtnCopyToClipboardEnc;
        private System.Windows.Forms.ToolTip copyToClipboardToolTip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbPort;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LbGettingSSO;
        private System.Windows.Forms.Button BtnCopyHeader;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbUseHttps;
        private System.Windows.Forms.Button BtnCopyToClipboardSoapUi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbSoapUiHeader;
    }
}


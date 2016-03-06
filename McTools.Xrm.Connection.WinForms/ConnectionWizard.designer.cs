﻿namespace McTools.Xrm.Connection.WinForms
{
    partial class ConnectionWizard
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOrganizationUrl = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.pnlConnectMoreActiveDirectoryInfo = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblIfdQuestion = new System.Windows.Forms.Label();
            this.lblHomeRealmQuestion = new System.Windows.Forms.Label();
            this.txtHomeRealm = new System.Windows.Forms.TextBox();
            this.rbIfdNo = new System.Windows.Forms.RadioButton();
            this.rbIfdYes = new System.Windows.Forms.RadioButton();
            this.btnValidateIfdInfo = new System.Windows.Forms.Button();
            this.pnlConnectAuthentication = new System.Windows.Forms.Panel();
            this.chkSavePassword = new System.Windows.Forms.CheckBox();
            this.btnReset3 = new System.Windows.Forms.Button();
            this.btnBack3 = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.pnlConnectUrl = new System.Windows.Forms.Panel();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkUseIntegratedAuthentication = new System.Windows.Forms.CheckBox();
            this.pnlWaiting = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pnlConnected = new System.Windows.Forms.Panel();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConnectionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlError = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.llUseConnectionString = new System.Windows.Forms.LinkLabel();
            this.llUseConnectionString2 = new System.Windows.Forms.LinkLabel();
            this.pnlConnectWithConnectionString = new System.Windows.Forms.Panel();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.llConnectionStringHelp = new System.Windows.Forms.LinkLabel();
            this.btnConnectWithConnectionString = new System.Windows.Forms.Button();
            this.lblPreview = new System.Windows.Forms.Label();
            this.pnlConnectMoreActiveDirectoryInfo.SuspendLayout();
            this.pnlConnectAuthentication.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlConnectUrl.SuspendLayout();
            this.pnlWaiting.SuspendLayout();
            this.pnlConnected.SuspendLayout();
            this.pnlError.SuspendLayout();
            this.pnlConnectWithConnectionString.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOrganizationUrl
            // 
            this.txtOrganizationUrl.Location = new System.Drawing.Point(94, 3);
            this.txtOrganizationUrl.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrganizationUrl.Name = "txtOrganizationUrl";
            this.txtOrganizationUrl.Size = new System.Drawing.Size(388, 22);
            this.txtOrganizationUrl.TabIndex = 0;
            this.txtOrganizationUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrganizationUrl_KeyDown);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(486, 2);
            this.btnGo.Margin = new System.Windows.Forms.Padding(2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(70, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // pnlConnectMoreActiveDirectoryInfo
            // 
            this.pnlConnectMoreActiveDirectoryInfo.Controls.Add(this.btnReset);
            this.pnlConnectMoreActiveDirectoryInfo.Controls.Add(this.btnBack);
            this.pnlConnectMoreActiveDirectoryInfo.Controls.Add(this.lblIfdQuestion);
            this.pnlConnectMoreActiveDirectoryInfo.Controls.Add(this.lblHomeRealmQuestion);
            this.pnlConnectMoreActiveDirectoryInfo.Controls.Add(this.txtHomeRealm);
            this.pnlConnectMoreActiveDirectoryInfo.Controls.Add(this.rbIfdNo);
            this.pnlConnectMoreActiveDirectoryInfo.Controls.Add(this.rbIfdYes);
            this.pnlConnectMoreActiveDirectoryInfo.Controls.Add(this.btnValidateIfdInfo);
            this.pnlConnectMoreActiveDirectoryInfo.Location = new System.Drawing.Point(0, 71);
            this.pnlConnectMoreActiveDirectoryInfo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlConnectMoreActiveDirectoryInfo.Name = "pnlConnectMoreActiveDirectoryInfo";
            this.pnlConnectMoreActiveDirectoryInfo.Size = new System.Drawing.Size(563, 135);
            this.pnlConnectMoreActiveDirectoryInfo.TabIndex = 2;
            this.pnlConnectMoreActiveDirectoryInfo.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(333, 109);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(67, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(404, 109);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblIfdQuestion
            // 
            this.lblIfdQuestion.AutoSize = true;
            this.lblIfdQuestion.Location = new System.Drawing.Point(8, 2);
            this.lblIfdQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIfdQuestion.Name = "lblIfdQuestion";
            this.lblIfdQuestion.Size = new System.Drawing.Size(357, 13);
            this.lblIfdQuestion.TabIndex = 8;
            this.lblIfdQuestion.Text = "Are you connecting to an Internet Facing Deployment organization?";
            // 
            // lblHomeRealmQuestion
            // 
            this.lblHomeRealmQuestion.AutoSize = true;
            this.lblHomeRealmQuestion.Location = new System.Drawing.Point(10, 33);
            this.lblHomeRealmQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomeRealmQuestion.Name = "lblHomeRealmQuestion";
            this.lblHomeRealmQuestion.Size = new System.Drawing.Size(253, 13);
            this.lblHomeRealmQuestion.TabIndex = 7;
            this.lblHomeRealmQuestion.Text = "If necessary, you can speficiy the home realm url";
            // 
            // txtHomeRealm
            // 
            this.txtHomeRealm.Enabled = false;
            this.txtHomeRealm.Location = new System.Drawing.Point(11, 52);
            this.txtHomeRealm.Margin = new System.Windows.Forms.Padding(2);
            this.txtHomeRealm.Name = "txtHomeRealm";
            this.txtHomeRealm.Size = new System.Drawing.Size(545, 22);
            this.txtHomeRealm.TabIndex = 7;
            // 
            // rbIfdNo
            // 
            this.rbIfdNo.AutoSize = true;
            this.rbIfdNo.Checked = true;
            this.rbIfdNo.Location = new System.Drawing.Point(369, 1);
            this.rbIfdNo.Margin = new System.Windows.Forms.Padding(2);
            this.rbIfdNo.Name = "rbIfdNo";
            this.rbIfdNo.Size = new System.Drawing.Size(40, 17);
            this.rbIfdNo.TabIndex = 5;
            this.rbIfdNo.TabStop = true;
            this.rbIfdNo.Text = "No";
            this.rbIfdNo.UseVisualStyleBackColor = true;
            // 
            // rbIfdYes
            // 
            this.rbIfdYes.AutoSize = true;
            this.rbIfdYes.Location = new System.Drawing.Point(413, 1);
            this.rbIfdYes.Margin = new System.Windows.Forms.Padding(2);
            this.rbIfdYes.Name = "rbIfdYes";
            this.rbIfdYes.Size = new System.Drawing.Size(40, 17);
            this.rbIfdYes.TabIndex = 6;
            this.rbIfdYes.Text = "Yes";
            this.rbIfdYes.UseVisualStyleBackColor = true;
            this.rbIfdYes.CheckedChanged += new System.EventHandler(this.rbIfdYes_CheckedChanged);
            // 
            // btnValidateIfdInfo
            // 
            this.btnValidateIfdInfo.Location = new System.Drawing.Point(475, 109);
            this.btnValidateIfdInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnValidateIfdInfo.Name = "btnValidateIfdInfo";
            this.btnValidateIfdInfo.Size = new System.Drawing.Size(80, 23);
            this.btnValidateIfdInfo.TabIndex = 10;
            this.btnValidateIfdInfo.Text = "Next";
            this.btnValidateIfdInfo.UseVisualStyleBackColor = true;
            this.btnValidateIfdInfo.Click += new System.EventHandler(this.btnValidaIfdInfo_Click);
            // 
            // pnlConnectAuthentication
            // 
            this.pnlConnectAuthentication.Controls.Add(this.chkSavePassword);
            this.pnlConnectAuthentication.Controls.Add(this.btnReset3);
            this.pnlConnectAuthentication.Controls.Add(this.btnBack3);
            this.pnlConnectAuthentication.Controls.Add(this.lblPassword);
            this.pnlConnectAuthentication.Controls.Add(this.lblUsername);
            this.pnlConnectAuthentication.Controls.Add(this.lblDomain);
            this.pnlConnectAuthentication.Controls.Add(this.txtPassword);
            this.pnlConnectAuthentication.Controls.Add(this.txtUsername);
            this.pnlConnectAuthentication.Controls.Add(this.txtDomain);
            this.pnlConnectAuthentication.Controls.Add(this.btnConnect);
            this.pnlConnectAuthentication.Location = new System.Drawing.Point(0, 71);
            this.pnlConnectAuthentication.Margin = new System.Windows.Forms.Padding(2);
            this.pnlConnectAuthentication.Name = "pnlConnectAuthentication";
            this.pnlConnectAuthentication.Size = new System.Drawing.Size(563, 135);
            this.pnlConnectAuthentication.TabIndex = 8;
            this.pnlConnectAuthentication.Visible = false;
            // 
            // chkSavePassword
            // 
            this.chkSavePassword.AutoSize = true;
            this.chkSavePassword.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSavePassword.Location = new System.Drawing.Point(254, 87);
            this.chkSavePassword.Name = "chkSavePassword";
            this.chkSavePassword.Size = new System.Drawing.Size(301, 17);
            this.chkSavePassword.TabIndex = 6;
            this.chkSavePassword.Text = "Save password as encrypted string in connections file";
            this.chkSavePassword.UseVisualStyleBackColor = true;
            // 
            // btnReset3
            // 
            this.btnReset3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset3.Location = new System.Drawing.Point(333, 109);
            this.btnReset3.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset3.Name = "btnReset3";
            this.btnReset3.Size = new System.Drawing.Size(67, 23);
            this.btnReset3.TabIndex = 7;
            this.btnReset3.Text = "Reset";
            this.btnReset3.UseVisualStyleBackColor = true;
            this.btnReset3.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBack3
            // 
            this.btnBack3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack3.Location = new System.Drawing.Point(404, 109);
            this.btnBack3.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack3.Name = "btnBack3";
            this.btnBack3.Size = new System.Drawing.Size(67, 23);
            this.btnBack3.TabIndex = 8;
            this.btnBack3.Text = "Back";
            this.btnBack3.UseVisualStyleBackColor = true;
            this.btnBack3.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(8, 64);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(10, 38);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username";
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(11, 12);
            this.lblDomain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(47, 13);
            this.lblDomain.TabIndex = 9;
            this.lblDomain.Text = "Domain";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(72, 61);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(483, 22);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(72, 35);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(483, 22);
            this.txtUsername.TabIndex = 4;
            // 
            // txtDomain
            // 
            this.txtDomain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDomain.Location = new System.Drawing.Point(72, 9);
            this.txtDomain.Margin = new System.Windows.Forms.Padding(2);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(483, 22);
            this.txtDomain.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(475, 109);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(80, 23);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblDescription);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(563, 67);
            this.pnlHeader.TabIndex = 9;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(10, 31);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(550, 36);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Enter the url displayed in the browser when you are connected to your Microsoft D" +
    "ynamics CRM \r\norganization";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(8, 6);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(149, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "New connection";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(3, 5);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(92, 13);
            this.lblUrl.TabIndex = 10;
            this.lblUrl.Text = "Organization url";
            // 
            // pnlConnectUrl
            // 
            this.pnlConnectUrl.Controls.Add(this.llUseConnectionString);
            this.pnlConnectUrl.Controls.Add(this.txtTimeout);
            this.pnlConnectUrl.Controls.Add(this.label4);
            this.pnlConnectUrl.Controls.Add(this.chkUseIntegratedAuthentication);
            this.pnlConnectUrl.Controls.Add(this.txtOrganizationUrl);
            this.pnlConnectUrl.Controls.Add(this.lblUrl);
            this.pnlConnectUrl.Controls.Add(this.btnGo);
            this.pnlConnectUrl.Location = new System.Drawing.Point(0, 71);
            this.pnlConnectUrl.Margin = new System.Windows.Forms.Padding(2);
            this.pnlConnectUrl.Name = "pnlConnectUrl";
            this.pnlConnectUrl.Size = new System.Drawing.Size(563, 135);
            this.pnlConnectUrl.TabIndex = 11;
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(94, 68);
            this.txtTimeout.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(50, 22);
            this.txtTimeout.TabIndex = 2;
            this.txtTimeout.Text = "00:02:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Service timeout";
            // 
            // chkUseIntegratedAuthentication
            // 
            this.chkUseIntegratedAuthentication.AutoSize = true;
            this.chkUseIntegratedAuthentication.Location = new System.Drawing.Point(94, 28);
            this.chkUseIntegratedAuthentication.Margin = new System.Windows.Forms.Padding(2);
            this.chkUseIntegratedAuthentication.Name = "chkUseIntegratedAuthentication";
            this.chkUseIntegratedAuthentication.Size = new System.Drawing.Size(170, 17);
            this.chkUseIntegratedAuthentication.TabIndex = 1;
            this.chkUseIntegratedAuthentication.Text = "Use your current credentials";
            this.chkUseIntegratedAuthentication.UseVisualStyleBackColor = true;
            this.chkUseIntegratedAuthentication.CheckedChanged += new System.EventHandler(this.chkUseIntegratedAuthentication_CheckedChanged);
            // 
            // pnlWaiting
            // 
            this.pnlWaiting.Controls.Add(this.label3);
            this.pnlWaiting.Controls.Add(this.progressBar1);
            this.pnlWaiting.Location = new System.Drawing.Point(0, 71);
            this.pnlWaiting.Margin = new System.Windows.Forms.Padding(2);
            this.pnlWaiting.Name = "pnlWaiting";
            this.pnlWaiting.Size = new System.Drawing.Size(563, 135);
            this.pnlWaiting.TabIndex = 12;
            this.pnlWaiting.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(546, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Trying to connect to your Microsoft Dynamics CRM organization";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 3);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(546, 21);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 0;
            // 
            // pnlConnected
            // 
            this.pnlConnected.Controls.Add(this.btnFinish);
            this.pnlConnected.Controls.Add(this.label2);
            this.pnlConnected.Controls.Add(this.txtConnectionName);
            this.pnlConnected.Controls.Add(this.label1);
            this.pnlConnected.Location = new System.Drawing.Point(0, 71);
            this.pnlConnected.Margin = new System.Windows.Forms.Padding(2);
            this.pnlConnected.Name = "pnlConnected";
            this.pnlConnected.Size = new System.Drawing.Size(563, 135);
            this.pnlConnected.TabIndex = 13;
            this.pnlConnected.Visible = false;
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.Location = new System.Drawing.Point(476, 107);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(80, 23);
            this.btnFinish.TabIndex = 17;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtConnectionName
            // 
            this.txtConnectionName.Location = new System.Drawing.Point(57, 55);
            this.txtConnectionName.Name = "txtConnectionName";
            this.txtConnectionName.Size = new System.Drawing.Size(494, 22);
            this.txtConnectionName.TabIndex = 16;
            this.txtConnectionName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "The connection was created successfully. If you want to save this connection, ple" +
    "ase provide a name for this connection.";
            // 
            // pnlError
            // 
            this.pnlError.Controls.Add(this.llUseConnectionString2);
            this.pnlError.Controls.Add(this.button1);
            this.pnlError.Controls.Add(this.button2);
            this.pnlError.Controls.Add(this.lblError);
            this.pnlError.Location = new System.Drawing.Point(0, 71);
            this.pnlError.Margin = new System.Windows.Forms.Padding(2);
            this.pnlError.Name = "pnlError";
            this.pnlError.Size = new System.Drawing.Size(563, 135);
            this.pnlError.TabIndex = 14;
            this.pnlError.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(423, 107);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(494, 107);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblError
            // 
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(13, 12);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(539, 83);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "[lblError]";
            // 
            // llUseConnectionString
            // 
            this.llUseConnectionString.AutoSize = true;
            this.llUseConnectionString.Location = new System.Drawing.Point(5, 107);
            this.llUseConnectionString.Name = "llUseConnectionString";
            this.llUseConnectionString.Size = new System.Drawing.Size(443, 13);
            this.llUseConnectionString.TabIndex = 12;
            this.llUseConnectionString.TabStop = true;
            this.llUseConnectionString.Text = "I will connect to the Microsoft Dynamics CRM organization using a connection stri" +
    "ng";
            this.llUseConnectionString.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llUseConnectionString_LinkClicked);
            // 
            // llUseConnectionString2
            // 
            this.llUseConnectionString2.AutoSize = true;
            this.llUseConnectionString2.Location = new System.Drawing.Point(5, 112);
            this.llUseConnectionString2.Name = "llUseConnectionString2";
            this.llUseConnectionString2.Size = new System.Drawing.Size(249, 13);
            this.llUseConnectionString2.TabIndex = 16;
            this.llUseConnectionString2.TabStop = true;
            this.llUseConnectionString2.Text = "Let me try to connect using a connection string";
            this.llUseConnectionString2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llUseConnectionString_LinkClicked);
            // 
            // pnlConnectWithConnectionString
            // 
            this.pnlConnectWithConnectionString.Controls.Add(this.lblPreview);
            this.pnlConnectWithConnectionString.Controls.Add(this.btnConnectWithConnectionString);
            this.pnlConnectWithConnectionString.Controls.Add(this.llConnectionStringHelp);
            this.pnlConnectWithConnectionString.Controls.Add(this.txtConnectionString);
            this.pnlConnectWithConnectionString.Controls.Add(this.lblConnectionString);
            this.pnlConnectWithConnectionString.Controls.Add(this.btnReset2);
            this.pnlConnectWithConnectionString.Controls.Add(this.btnBack2);
            this.pnlConnectWithConnectionString.Location = new System.Drawing.Point(0, 71);
            this.pnlConnectWithConnectionString.Margin = new System.Windows.Forms.Padding(2);
            this.pnlConnectWithConnectionString.Name = "pnlConnectWithConnectionString";
            this.pnlConnectWithConnectionString.Size = new System.Drawing.Size(563, 135);
            this.pnlConnectWithConnectionString.TabIndex = 15;
            this.pnlConnectWithConnectionString.Visible = false;
            // 
            // btnReset2
            // 
            this.btnReset2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset2.Location = new System.Drawing.Point(346, 107);
            this.btnReset2.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(67, 23);
            this.btnReset2.TabIndex = 14;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBack2
            // 
            this.btnBack2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack2.Location = new System.Drawing.Point(417, 107);
            this.btnBack2.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(67, 23);
            this.btnBack2.TabIndex = 15;
            this.btnBack2.Text = "Back";
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Location = new System.Drawing.Point(3, 16);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(100, 13);
            this.lblConnectionString.TabIndex = 16;
            this.lblConnectionString.Text = "Connection string";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(3, 38);
            this.txtConnectionString.Multiline = true;
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(557, 64);
            this.txtConnectionString.TabIndex = 17;
            // 
            // llConnectionStringHelp
            // 
            this.llConnectionStringHelp.AutoSize = true;
            this.llConnectionStringHelp.Location = new System.Drawing.Point(8, 112);
            this.llConnectionStringHelp.Name = "llConnectionStringHelp";
            this.llConnectionStringHelp.Size = new System.Drawing.Size(189, 13);
            this.llConnectionStringHelp.TabIndex = 18;
            this.llConnectionStringHelp.TabStop = true;
            this.llConnectionStringHelp.Text = "Help me with the connection stirng";
            this.llConnectionStringHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llConnectionStringHelp_LinkClicked);
            // 
            // btnConnectWithConnectionString
            // 
            this.btnConnectWithConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectWithConnectionString.Location = new System.Drawing.Point(488, 107);
            this.btnConnectWithConnectionString.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnectWithConnectionString.Name = "btnConnectWithConnectionString";
            this.btnConnectWithConnectionString.Size = new System.Drawing.Size(67, 23);
            this.btnConnectWithConnectionString.TabIndex = 19;
            this.btnConnectWithConnectionString.Text = "Connect";
            this.btnConnectWithConnectionString.UseVisualStyleBackColor = true;
            this.btnConnectWithConnectionString.Click += new System.EventHandler(this.btnConnectWithConnectionString_Click);
            // 
            // lblPreview
            // 
            this.lblPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreview.AutoSize = true;
            this.lblPreview.ForeColor = System.Drawing.Color.Red;
            this.lblPreview.Location = new System.Drawing.Point(455, 16);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(100, 13);
            this.lblPreview.TabIndex = 20;
            this.lblPreview.Text = "PREVIEW FEATURE";
            // 
            // ConnectionWizard
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(563, 212);
            this.Controls.Add(this.pnlConnectWithConnectionString);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlError);
            this.Controls.Add(this.pnlConnected);
            this.Controls.Add(this.pnlWaiting);
            this.Controls.Add(this.pnlConnectUrl);
            this.Controls.Add(this.pnlConnectAuthentication);
            this.Controls.Add(this.pnlConnectMoreActiveDirectoryInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionWizard";
            this.ShowIcon = false;
            this.pnlConnectMoreActiveDirectoryInfo.ResumeLayout(false);
            this.pnlConnectMoreActiveDirectoryInfo.PerformLayout();
            this.pnlConnectAuthentication.ResumeLayout(false);
            this.pnlConnectAuthentication.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlConnectUrl.ResumeLayout(false);
            this.pnlConnectUrl.PerformLayout();
            this.pnlWaiting.ResumeLayout(false);
            this.pnlConnected.ResumeLayout(false);
            this.pnlConnected.PerformLayout();
            this.pnlError.ResumeLayout(false);
            this.pnlError.PerformLayout();
            this.pnlConnectWithConnectionString.ResumeLayout(false);
            this.pnlConnectWithConnectionString.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrganizationUrl;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Panel pnlConnectMoreActiveDirectoryInfo;
        private System.Windows.Forms.Label lblHomeRealmQuestion;
        private System.Windows.Forms.TextBox txtHomeRealm;
        private System.Windows.Forms.RadioButton rbIfdNo;
        private System.Windows.Forms.RadioButton rbIfdYes;
        private System.Windows.Forms.Button btnValidateIfdInfo;
        private System.Windows.Forms.Panel pnlConnectAuthentication;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Panel pnlConnectUrl;
        private System.Windows.Forms.Label lblIfdQuestion;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset3;
        private System.Windows.Forms.Button btnBack3;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel pnlWaiting;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel pnlConnected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkUseIntegratedAuthentication;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConnectionName;
        private System.Windows.Forms.Panel pnlError;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.CheckBox chkSavePassword;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel llUseConnectionString;
        private System.Windows.Forms.LinkLabel llUseConnectionString2;
        private System.Windows.Forms.Panel pnlConnectWithConnectionString;
        private System.Windows.Forms.LinkLabel llConnectionStringHelp;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button btnConnectWithConnectionString;
        private System.Windows.Forms.Label lblPreview;
    }
}


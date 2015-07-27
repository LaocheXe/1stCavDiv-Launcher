namespace _1stCavDiv_Launcher
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.clbMods = new System.Windows.Forms.CheckedListBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMlstRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cmbMSSelection = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkAdvancePara = new System.Windows.Forms.CheckBox();
            this.clbParameters = new System.Windows.Forms.CheckedListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkLauncherClose = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkParaEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoModsDisabled = new System.Windows.Forms.RadioButton();
            this.rdoModsEnabled = new System.Windows.Forms.RadioButton();
            this.lblDeBugg = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblDeBug = new System.Windows.Forms.Label();
            this.chkInit = new System.Windows.Forms.CheckBox();
            this.chkMalloc = new System.Windows.Forms.CheckBox();
            this.chkexThreads = new System.Windows.Forms.CheckBox();
            this.chkcpuCount = new System.Windows.Forms.CheckBox();
            this.chkmaxVRAM = new System.Windows.Forms.CheckBox();
            this.chkmaxMem = new System.Windows.Forms.CheckBox();
            this.mnuMainfStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modPackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rCONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamInfomationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamSpeak3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnJoinTS = new System.Windows.Forms.Button();
            this.pWSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torrentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.mnuMainfStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbMods
            // 
            this.clbMods.BackColor = System.Drawing.Color.White;
            this.clbMods.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbMods.ForeColor = System.Drawing.Color.Black;
            this.clbMods.FormattingEnabled = true;
            this.clbMods.Location = new System.Drawing.Point(6, 19);
            this.clbMods.Name = "clbMods";
            this.clbMods.Size = new System.Drawing.Size(183, 276);
            this.clbMods.TabIndex = 2;
            this.clbMods.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbMods_ItemCheck);
            this.clbMods.SelectedIndexChanged += new System.EventHandler(this.clbMods_SelectedIndexChanged);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(213, 390);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(370, 64);
            this.btnLaunch.TabIndex = 3;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMlstRefresh);
            this.groupBox1.Controls.Add(this.clbMods);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 368);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mods List";
            // 
            // btnMlstRefresh
            // 
            this.btnMlstRefresh.Location = new System.Drawing.Point(7, 307);
            this.btnMlstRefresh.Name = "btnMlstRefresh";
            this.btnMlstRefresh.Size = new System.Drawing.Size(182, 58);
            this.btnMlstRefresh.TabIndex = 3;
            this.btnMlstRefresh.Text = "Refresh";
            this.btnMlstRefresh.UseVisualStyleBackColor = true;
            this.btnMlstRefresh.Click += new System.EventHandler(this.btnMlstRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.clbParameters);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(213, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 298);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Launch Options";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cmbMSSelection);
            this.groupBox8.Location = new System.Drawing.Point(187, 20);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(177, 99);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Mod Set Selection";
            // 
            // cmbMSSelection
            // 
            this.cmbMSSelection.FormattingEnabled = true;
            this.cmbMSSelection.Location = new System.Drawing.Point(6, 53);
            this.cmbMSSelection.Name = "cmbMSSelection";
            this.cmbMSSelection.Size = new System.Drawing.Size(164, 21);
            this.cmbMSSelection.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkAdvancePara);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(181, 177);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(183, 54);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Advance Parameters";
            // 
            // chkAdvancePara
            // 
            this.chkAdvancePara.AutoSize = true;
            this.chkAdvancePara.Location = new System.Drawing.Point(6, 31);
            this.chkAdvancePara.Name = "chkAdvancePara";
            this.chkAdvancePara.Size = new System.Drawing.Size(121, 17);
            this.chkAdvancePara.TabIndex = 2;
            this.chkAdvancePara.Text = "Parameters Enabled";
            this.chkAdvancePara.UseVisualStyleBackColor = true;
            this.chkAdvancePara.CheckedChanged += new System.EventHandler(this.chkAdvancePara_CheckedChanged);
            // 
            // clbParameters
            // 
            this.clbParameters.FormattingEnabled = true;
            this.clbParameters.Items.AddRange(new object[] {
            "-window",
            "-nosplash",
            "-skipIntro",
            "-winxp",
            "-noCB",
            "-noLogs",
            "-noPause",
            "-showScriptErrors",
            "-noFilePatching",
            "-autotest",
            "-checkSignatures",
            "-buldozer",
            "-noLand",
            "-noSound",
            "-donothing",
            "/secuexp"});
            this.clbParameters.Location = new System.Drawing.Point(221, 279);
            this.clbParameters.Name = "clbParameters";
            this.clbParameters.Size = new System.Drawing.Size(143, 19);
            this.clbParameters.TabIndex = 6;
            this.clbParameters.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkLauncherClose);
            this.groupBox5.Location = new System.Drawing.Point(6, 237);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(169, 55);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Launcher";
            // 
            // chkLauncherClose
            // 
            this.chkLauncherClose.AutoSize = true;
            this.chkLauncherClose.Location = new System.Drawing.Point(6, 32);
            this.chkLauncherClose.Name = "chkLauncherClose";
            this.chkLauncherClose.Size = new System.Drawing.Size(100, 17);
            this.chkLauncherClose.TabIndex = 2;
            this.chkLauncherClose.Text = "Close Launcher";
            this.chkLauncherClose.UseVisualStyleBackColor = true;
            this.chkLauncherClose.CheckedChanged += new System.EventHandler(this.chkLauncherClose_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkParaEnabled);
            this.groupBox4.Location = new System.Drawing.Point(6, 177);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(169, 54);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parameters";
            // 
            // chkParaEnabled
            // 
            this.chkParaEnabled.AutoSize = true;
            this.chkParaEnabled.Location = new System.Drawing.Point(6, 31);
            this.chkParaEnabled.Name = "chkParaEnabled";
            this.chkParaEnabled.Size = new System.Drawing.Size(121, 17);
            this.chkParaEnabled.TabIndex = 1;
            this.chkParaEnabled.Text = "Parameters Enabled";
            this.chkParaEnabled.UseVisualStyleBackColor = true;
            this.chkParaEnabled.CheckedChanged += new System.EventHandler(this.chkParaEnabled_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoModsDisabled);
            this.groupBox3.Controls.Add(this.rdoModsEnabled);
            this.groupBox3.Location = new System.Drawing.Point(12, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mods";
            // 
            // rdoModsDisabled
            // 
            this.rdoModsDisabled.AutoSize = true;
            this.rdoModsDisabled.Location = new System.Drawing.Point(6, 58);
            this.rdoModsDisabled.Name = "rdoModsDisabled";
            this.rdoModsDisabled.Size = new System.Drawing.Size(89, 17);
            this.rdoModsDisabled.TabIndex = 4;
            this.rdoModsDisabled.TabStop = true;
            this.rdoModsDisabled.Text = "Disable Mods";
            this.rdoModsDisabled.UseVisualStyleBackColor = true;
            this.rdoModsDisabled.CheckedChanged += new System.EventHandler(this.rdoModsDisabled_CheckedChanged);
            // 
            // rdoModsEnabled
            // 
            this.rdoModsEnabled.AutoSize = true;
            this.rdoModsEnabled.Location = new System.Drawing.Point(6, 35);
            this.rdoModsEnabled.Name = "rdoModsEnabled";
            this.rdoModsEnabled.Size = new System.Drawing.Size(93, 17);
            this.rdoModsEnabled.TabIndex = 3;
            this.rdoModsEnabled.TabStop = true;
            this.rdoModsEnabled.Text = "Enabled Mods";
            this.rdoModsEnabled.UseVisualStyleBackColor = true;
            this.rdoModsEnabled.CheckedChanged += new System.EventHandler(this.rdoModsEnabled_CheckedChanged);
            // 
            // lblDeBugg
            // 
            this.lblDeBugg.AutoSize = true;
            this.lblDeBugg.Location = new System.Drawing.Point(110, 457);
            this.lblDeBugg.Name = "lblDeBugg";
            this.lblDeBugg.Size = new System.Drawing.Size(0, 13);
            this.lblDeBugg.TabIndex = 8;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblDeBug);
            this.groupBox7.Controls.Add(this.chkInit);
            this.groupBox7.Controls.Add(this.chkMalloc);
            this.groupBox7.Controls.Add(this.chkexThreads);
            this.groupBox7.Controls.Add(this.chkcpuCount);
            this.groupBox7.Controls.Add(this.chkmaxVRAM);
            this.groupBox7.Controls.Add(this.chkmaxMem);
            this.groupBox7.Location = new System.Drawing.Point(19, 473);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(369, 174);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Visible = false;
            // 
            // lblDeBug
            // 
            this.lblDeBug.AutoSize = true;
            this.lblDeBug.Location = new System.Drawing.Point(137, 81);
            this.lblDeBug.Name = "lblDeBug";
            this.lblDeBug.Size = new System.Drawing.Size(39, 13);
            this.lblDeBug.TabIndex = 18;
            this.lblDeBug.Text = "Debug";
            // 
            // chkInit
            // 
            this.chkInit.AutoSize = true;
            this.chkInit.Location = new System.Drawing.Point(15, 150);
            this.chkInit.Name = "chkInit";
            this.chkInit.Size = new System.Drawing.Size(48, 17);
            this.chkInit.TabIndex = 17;
            this.chkInit.Text = "-init=";
            this.chkInit.UseVisualStyleBackColor = true;
            // 
            // chkMalloc
            // 
            this.chkMalloc.AutoSize = true;
            this.chkMalloc.Location = new System.Drawing.Point(15, 127);
            this.chkMalloc.Name = "chkMalloc";
            this.chkMalloc.Size = new System.Drawing.Size(65, 17);
            this.chkMalloc.TabIndex = 16;
            this.chkMalloc.Text = "-malloc=";
            this.chkMalloc.UseVisualStyleBackColor = true;
            // 
            // chkexThreads
            // 
            this.chkexThreads.AutoSize = true;
            this.chkexThreads.Location = new System.Drawing.Point(15, 104);
            this.chkexThreads.Name = "chkexThreads";
            this.chkexThreads.Size = new System.Drawing.Size(85, 17);
            this.chkexThreads.TabIndex = 15;
            this.chkexThreads.Text = "-exThreads=";
            this.chkexThreads.UseVisualStyleBackColor = true;
            // 
            // chkcpuCount
            // 
            this.chkcpuCount.AutoSize = true;
            this.chkcpuCount.Location = new System.Drawing.Point(15, 81);
            this.chkcpuCount.Name = "chkcpuCount";
            this.chkcpuCount.Size = new System.Drawing.Size(81, 17);
            this.chkcpuCount.TabIndex = 14;
            this.chkcpuCount.Text = "-cpuCount=";
            this.chkcpuCount.UseVisualStyleBackColor = true;
            // 
            // chkmaxVRAM
            // 
            this.chkmaxVRAM.AutoSize = true;
            this.chkmaxVRAM.Location = new System.Drawing.Point(15, 58);
            this.chkmaxVRAM.Name = "chkmaxVRAM";
            this.chkmaxVRAM.Size = new System.Drawing.Size(85, 17);
            this.chkmaxVRAM.TabIndex = 13;
            this.chkmaxVRAM.Text = "-maxVRAM=";
            this.chkmaxVRAM.UseVisualStyleBackColor = true;
            // 
            // chkmaxMem
            // 
            this.chkmaxMem.AutoSize = true;
            this.chkmaxMem.Location = new System.Drawing.Point(15, 35);
            this.chkmaxMem.Name = "chkmaxMem";
            this.chkmaxMem.Size = new System.Drawing.Size(77, 17);
            this.chkmaxMem.TabIndex = 12;
            this.chkmaxMem.Text = "-maxMem=";
            this.chkmaxMem.UseVisualStyleBackColor = true;
            // 
            // mnuMainfStrip
            // 
            this.mnuMainfStrip.BackColor = System.Drawing.Color.Transparent;
            this.mnuMainfStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.downloadsToolStripMenuItem,
            this.serverBrowserToolStripMenuItem,
            this.utilitiesToolStripMenuItem,
            this.browserToolStripMenuItem,
            this.teamInfomationToolStripMenuItem,
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.mnuMainfStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuMainfStrip.Name = "mnuMainfStrip";
            this.mnuMainfStrip.Size = new System.Drawing.Size(599, 24);
            this.mnuMainfStrip.TabIndex = 10;
            this.mnuMainfStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // downloadsToolStripMenuItem
            // 
            this.downloadsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modPackToolStripMenuItem});
            this.downloadsToolStripMenuItem.Name = "downloadsToolStripMenuItem";
            this.downloadsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.downloadsToolStripMenuItem.Text = "Downloads";
            // 
            // modPackToolStripMenuItem
            // 
            this.modPackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pWSToolStripMenuItem,
            this.torrentToolStripMenuItem1});
            this.modPackToolStripMenuItem.Name = "modPackToolStripMenuItem";
            this.modPackToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modPackToolStripMenuItem.Text = "Mod Pack";
            this.modPackToolStripMenuItem.Click += new System.EventHandler(this.modPackToolStripMenuItem_Click);
            // 
            // serverBrowserToolStripMenuItem
            // 
            this.serverBrowserToolStripMenuItem.Name = "serverBrowserToolStripMenuItem";
            this.serverBrowserToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.serverBrowserToolStripMenuItem.Text = "Server Browser";
            this.serverBrowserToolStripMenuItem.Click += new System.EventHandler(this.serverBrowserToolStripMenuItem_Click);
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rCONToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // rCONToolStripMenuItem
            // 
            this.rCONToolStripMenuItem.Enabled = false;
            this.rCONToolStripMenuItem.Name = "rCONToolStripMenuItem";
            this.rCONToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.rCONToolStripMenuItem.Text = "RCON";
            // 
            // browserToolStripMenuItem
            // 
            this.browserToolStripMenuItem.Enabled = false;
            this.browserToolStripMenuItem.Name = "browserToolStripMenuItem";
            this.browserToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.browserToolStripMenuItem.Text = "Browser";
            // 
            // teamInfomationToolStripMenuItem
            // 
            this.teamInfomationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamSpeak3ToolStripMenuItem});
            this.teamInfomationToolStripMenuItem.Name = "teamInfomationToolStripMenuItem";
            this.teamInfomationToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.teamInfomationToolStripMenuItem.Text = "Team Infomation";
            // 
            // teamSpeak3ToolStripMenuItem
            // 
            this.teamSpeak3ToolStripMenuItem.Name = "teamSpeak3ToolStripMenuItem";
            this.teamSpeak3ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.teamSpeak3ToolStripMenuItem.Text = "TeamSpeak 3";
            this.teamSpeak3ToolStripMenuItem.Click += new System.EventHandler(this.teamSpeak3ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fAQToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.supportPageToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Enabled = false;
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.fAQToolStripMenuItem.Text = "FAQ";
            this.fAQToolStripMenuItem.Click += new System.EventHandler(this.fAQToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // supportPageToolStripMenuItem
            // 
            this.supportPageToolStripMenuItem.Enabled = false;
            this.supportPageToolStripMenuItem.Name = "supportPageToolStripMenuItem";
            this.supportPageToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.supportPageToolStripMenuItem.Text = "Support Page";
            this.supportPageToolStripMenuItem.Click += new System.EventHandler(this.supportPageToolStripMenuItem_Click);
            // 
            // btnJoinTS
            // 
            this.btnJoinTS.Location = new System.Drawing.Point(489, 47);
            this.btnJoinTS.Name = "btnJoinTS";
            this.btnJoinTS.Size = new System.Drawing.Size(94, 33);
            this.btnJoinTS.TabIndex = 11;
            this.btnJoinTS.Text = "Join Teamspeak";
            this.btnJoinTS.UseVisualStyleBackColor = true;
            this.btnJoinTS.Click += new System.EventHandler(this.btnJoinTS_Click);
            // 
            // pWSToolStripMenuItem
            // 
            this.pWSToolStripMenuItem.Name = "pWSToolStripMenuItem";
            this.pWSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pWSToolStripMenuItem.Text = "PWS";
            this.pWSToolStripMenuItem.Click += new System.EventHandler(this.pWSToolStripMenuItem_Click);
            // 
            // torrentToolStripMenuItem1
            // 
            this.torrentToolStripMenuItem1.Name = "torrentToolStripMenuItem1";
            this.torrentToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.torrentToolStripMenuItem1.Text = "Torrent";
            this.torrentToolStripMenuItem1.Click += new System.EventHandler(this.torrentToolStripMenuItem1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 479);
            this.Controls.Add(this.btnJoinTS);
            this.Controls.Add(this.lblDeBugg);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.mnuMainfStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMainfStrip;
            this.Name = "Main";
            this.Text = "Launcher - 1st Cavalry Division";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.mnuMainfStrip.ResumeLayout(false);
            this.mnuMainfStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbMods;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMlstRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkLauncherClose;
        private System.Windows.Forms.CheckBox chkParaEnabled;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox clbParameters;
        private System.Windows.Forms.RadioButton rdoModsDisabled;
        private System.Windows.Forms.RadioButton rdoModsEnabled;
        private System.Windows.Forms.Label lblDeBugg;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkAdvancePara;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox chkInit;
        private System.Windows.Forms.CheckBox chkMalloc;
        private System.Windows.Forms.CheckBox chkexThreads;
        private System.Windows.Forms.CheckBox chkcpuCount;
        private System.Windows.Forms.CheckBox chkmaxVRAM;
        private System.Windows.Forms.CheckBox chkmaxMem;
        private System.Windows.Forms.Label lblDeBug;
        private System.Windows.Forms.MenuStrip mnuMainfStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modPackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rCONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamInfomationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamSpeak3ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cmbMSSelection;
        private System.Windows.Forms.Button btnJoinTS;
        public System.Windows.Forms.ToolStripMenuItem serverBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pWSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torrentToolStripMenuItem1;
    }
}


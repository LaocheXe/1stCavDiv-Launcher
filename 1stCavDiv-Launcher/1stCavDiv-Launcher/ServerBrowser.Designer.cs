namespace _1stCavDiv_Launcher
{
    partial class ServerBrowser
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Servers", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Favorits", System.Windows.Forms.HorizontalAlignment.Center);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerBrowser));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNameFilter = new System.Windows.Forms.Button();
            this.txtNameFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpServerPassword = new System.Windows.Forms.GroupBox();
            this.txtServerPassword = new System.Windows.Forms.TextBox();
            this.lvServerBrowser = new System.Windows.Forms.ListView();
            this.chPassworded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIsland = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPlayers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBattleye = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnJoin = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cmbServerSelect = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRemoteJoin = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chksPassword = new System.Windows.Forms.CheckBox();
            this.grpRemotePass = new System.Windows.Forms.GroupBox();
            this.txtRemotePassword = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtRemotePort = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRemoteHost = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btnSavSerSave = new System.Windows.Forms.Button();
            this.btnSavSerAdd = new System.Windows.Forms.Button();
            this.txtSavSerPass = new System.Windows.Forms.TextBox();
            this.txtSavSerPort = new System.Windows.Forms.TextBox();
            this.txtSavSerIp = new System.Windows.Forms.TextBox();
            this.txtSavSerName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.chkConDelete = new System.Windows.Forms.CheckBox();
            this.btnDeleteServer = new System.Windows.Forms.Button();
            this.btnEditServer = new System.Windows.Forms.Button();
            this.cmbSavSerList = new System.Windows.Forms.ComboBox();
            this.ServerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Island = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Version = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoModsDisabled = new System.Windows.Forms.RadioButton();
            this.rdoModsEnabled = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkParaEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkAdvancePara = new System.Windows.Forms.CheckBox();
            this.clbParameters = new System.Windows.Forms.CheckedListBox();
            this.lblDebug = new System.Windows.Forms.Label();
            this.clbMods = new System.Windows.Forms.CheckedListBox();
            this.mnuServerBrowser = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMissionMap = new System.Windows.Forms.TextBox();
            this.txtMissionType = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.txtBattlEye = new System.Windows.Forms.TextBox();
            this.txtServerPortHI = new System.Windows.Forms.TextBox();
            this.txtServerAddressHI = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.rtxtServerMods = new System.Windows.Forms.RichTextBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.txtMissionName = new System.Windows.Forms.TextBox();
            this.btnMim = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpServerPassword.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.grpRemotePass.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.mnuServerBrowser.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(442, 503);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 46);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(321, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1109, 585);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.grpServerPassword);
            this.tabPage1.Controls.Add(this.lvServerBrowser);
            this.tabPage1.Controls.Add(this.btnJoin);
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1101, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Server Browser";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNameFilter);
            this.groupBox1.Controls.Add(this.txtNameFilter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 484);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 69);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Paramaters";
            // 
            // btnNameFilter
            // 
            this.btnNameFilter.Location = new System.Drawing.Point(197, 31);
            this.btnNameFilter.Name = "btnNameFilter";
            this.btnNameFilter.Size = new System.Drawing.Size(75, 23);
            this.btnNameFilter.TabIndex = 16;
            this.btnNameFilter.Text = "Search";
            this.btnNameFilter.UseVisualStyleBackColor = true;
            this.btnNameFilter.Click += new System.EventHandler(this.btnNameFilter_Click);
            // 
            // txtNameFilter
            // 
            this.txtNameFilter.Location = new System.Drawing.Point(91, 33);
            this.txtNameFilter.Name = "txtNameFilter";
            this.txtNameFilter.Size = new System.Drawing.Size(100, 20);
            this.txtNameFilter.TabIndex = 15;
            this.txtNameFilter.TextChanged += new System.EventHandler(this.txtNameFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Filter Name:";
            // 
            // grpServerPassword
            // 
            this.grpServerPassword.Controls.Add(this.txtServerPassword);
            this.grpServerPassword.Enabled = false;
            this.grpServerPassword.Location = new System.Drawing.Point(791, 484);
            this.grpServerPassword.Name = "grpServerPassword";
            this.grpServerPassword.Size = new System.Drawing.Size(173, 65);
            this.grpServerPassword.TabIndex = 16;
            this.grpServerPassword.TabStop = false;
            this.grpServerPassword.Text = "Password";
            // 
            // txtServerPassword
            // 
            this.txtServerPassword.Location = new System.Drawing.Point(6, 19);
            this.txtServerPassword.Name = "txtServerPassword";
            this.txtServerPassword.Size = new System.Drawing.Size(160, 20);
            this.txtServerPassword.TabIndex = 0;
            // 
            // lvServerBrowser
            // 
            this.lvServerBrowser.AllowColumnReorder = true;
            this.lvServerBrowser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPassworded,
            this.chSName,
            this.chMission,
            this.chMode,
            this.chIsland,
            this.chPlayers,
            this.chVersion,
            this.chState,
            this.chHost,
            this.chPort,
            this.chBattleye,
            this.chMod});
            this.lvServerBrowser.FullRowSelect = true;
            listViewGroup1.Header = "Servers";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "lvgServers";
            listViewGroup2.Header = "Favorits";
            listViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup2.Name = "lvgFavorits";
            this.lvServerBrowser.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lvServerBrowser.Location = new System.Drawing.Point(3, 3);
            this.lvServerBrowser.MultiSelect = false;
            this.lvServerBrowser.Name = "lvServerBrowser";
            this.lvServerBrowser.OwnerDraw = true;
            this.lvServerBrowser.Size = new System.Drawing.Size(1095, 475);
            this.lvServerBrowser.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvServerBrowser.TabIndex = 0;
            this.lvServerBrowser.UseCompatibleStateImageBehavior = false;
            this.lvServerBrowser.View = System.Windows.Forms.View.Details;
            this.lvServerBrowser.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvServerBrowser_DrawColumnHeader);
            this.lvServerBrowser.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvServerBrowser_DrawSubItem);
            this.lvServerBrowser.SelectedIndexChanged += new System.EventHandler(this.lvServerList_SelectedIndexChanged);
            // 
            // chPassworded
            // 
            this.chPassworded.Text = "";
            this.chPassworded.Width = 25;
            // 
            // chSName
            // 
            this.chSName.Text = "Server Name";
            this.chSName.Width = 421;
            // 
            // chMission
            // 
            this.chMission.Text = "Mission";
            this.chMission.Width = 158;
            // 
            // chMode
            // 
            this.chMode.Text = "Mode";
            this.chMode.Width = 98;
            // 
            // chIsland
            // 
            this.chIsland.Text = "Island";
            this.chIsland.Width = 85;
            // 
            // chPlayers
            // 
            this.chPlayers.Text = "Players";
            this.chPlayers.Width = 84;
            // 
            // chVersion
            // 
            this.chVersion.Text = "Version";
            this.chVersion.Width = 85;
            // 
            // chState
            // 
            this.chState.Text = "State";
            this.chState.Width = 84;
            // 
            // chHost
            // 
            this.chHost.Text = "Host/IP";
            this.chHost.Width = 0;
            // 
            // chPort
            // 
            this.chPort.Text = "Port";
            this.chPort.Width = 0;
            // 
            // chBattleye
            // 
            this.chBattleye.Text = "BattlEye";
            this.chBattleye.Width = 0;
            // 
            // chMod
            // 
            this.chMod.Text = "Mods";
            this.chMod.Width = 0;
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(970, 503);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(125, 46);
            this.btnJoin.TabIndex = 9;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox9);
            this.tabPage2.Controls.Add(this.btnRemoteJoin);
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.grpRemotePass);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1101, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Remote";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cmbServerSelect);
            this.groupBox7.Location = new System.Drawing.Point(525, 23);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(570, 110);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Server Selection";
            // 
            // cmbServerSelect
            // 
            this.cmbServerSelect.FormattingEnabled = true;
            this.cmbServerSelect.Items.AddRange(new object[] {
            "...Select Server...",
            "NATO TF Pub",
            "NATO TF Tradoc",
            "NATO TF Dynamic",
            "NATO TF Test"});
            this.cmbServerSelect.Location = new System.Drawing.Point(29, 45);
            this.cmbServerSelect.Name = "cmbServerSelect";
            this.cmbServerSelect.Size = new System.Drawing.Size(208, 21);
            this.cmbServerSelect.TabIndex = 0;
            this.cmbServerSelect.SelectedIndexChanged += new System.EventHandler(this.cmbServerSelect_SelectedIndexChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Controls.Add(this.label7);
            this.groupBox9.Location = new System.Drawing.Point(525, 252);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(570, 119);
            this.groupBox9.TabIndex = 11;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Server";
            this.groupBox9.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Current Server Port:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Current Server IP:";
            // 
            // btnRemoteJoin
            // 
            this.btnRemoteJoin.Location = new System.Drawing.Point(970, 472);
            this.btnRemoteJoin.Name = "btnRemoteJoin";
            this.btnRemoteJoin.Size = new System.Drawing.Size(125, 58);
            this.btnRemoteJoin.TabIndex = 10;
            this.btnRemoteJoin.Text = "Join";
            this.btnRemoteJoin.UseVisualStyleBackColor = true;
            this.btnRemoteJoin.Click += new System.EventHandler(this.btnRemoteJoin_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.chksPassword);
            this.groupBox8.Location = new System.Drawing.Point(335, 7);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(183, 364);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Examples";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tradoc Server: 2302";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Public Server #1: 2332";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Listed Ports";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "server.1stcavdiv.us";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "1st Cavalry Division IP/Host";
            // 
            // chksPassword
            // 
            this.chksPassword.AutoSize = true;
            this.chksPassword.Location = new System.Drawing.Point(7, 306);
            this.chksPassword.Name = "chksPassword";
            this.chksPassword.Size = new System.Drawing.Size(100, 17);
            this.chksPassword.TabIndex = 3;
            this.chksPassword.Text = "Use Password?";
            this.chksPassword.UseVisualStyleBackColor = true;
            this.chksPassword.CheckedChanged += new System.EventHandler(this.chksPassword_CheckedChanged);
            // 
            // grpRemotePass
            // 
            this.grpRemotePass.Controls.Add(this.txtRemotePassword);
            this.grpRemotePass.Enabled = false;
            this.grpRemotePass.Location = new System.Drawing.Point(14, 271);
            this.grpRemotePass.Name = "grpRemotePass";
            this.grpRemotePass.Size = new System.Drawing.Size(314, 100);
            this.grpRemotePass.TabIndex = 2;
            this.grpRemotePass.TabStop = false;
            this.grpRemotePass.Text = "Password";
            // 
            // txtRemotePassword
            // 
            this.txtRemotePassword.Location = new System.Drawing.Point(74, 40);
            this.txtRemotePassword.Name = "txtRemotePassword";
            this.txtRemotePassword.PasswordChar = '*';
            this.txtRemotePassword.Size = new System.Drawing.Size(152, 20);
            this.txtRemotePassword.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtRemotePort);
            this.groupBox5.Location = new System.Drawing.Point(14, 164);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(314, 100);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Port";
            // 
            // txtRemotePort
            // 
            this.txtRemotePort.Location = new System.Drawing.Point(74, 36);
            this.txtRemotePort.Name = "txtRemotePort";
            this.txtRemotePort.Size = new System.Drawing.Size(152, 20);
            this.txtRemotePort.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRemoteHost);
            this.groupBox2.Location = new System.Drawing.Point(14, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 152);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server IP/Host";
            // 
            // txtRemoteHost
            // 
            this.txtRemoteHost.Location = new System.Drawing.Point(74, 62);
            this.txtRemoteHost.Name = "txtRemoteHost";
            this.txtRemoteHost.Size = new System.Drawing.Size(152, 20);
            this.txtRemoteHost.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox11);
            this.tabPage3.Controls.Add(this.groupBox10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1101, 559);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Save Servers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.groupBox12);
            this.groupBox11.Enabled = false;
            this.groupBox11.Location = new System.Drawing.Point(6, 98);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(1089, 349);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.btnSavSerSave);
            this.groupBox12.Controls.Add(this.btnSavSerAdd);
            this.groupBox12.Controls.Add(this.txtSavSerPass);
            this.groupBox12.Controls.Add(this.txtSavSerPort);
            this.groupBox12.Controls.Add(this.txtSavSerIp);
            this.groupBox12.Controls.Add(this.txtSavSerName);
            this.groupBox12.Controls.Add(this.label13);
            this.groupBox12.Controls.Add(this.label12);
            this.groupBox12.Controls.Add(this.label11);
            this.groupBox12.Controls.Add(this.label10);
            this.groupBox12.Location = new System.Drawing.Point(187, 20);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(605, 323);
            this.groupBox12.TabIndex = 0;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Add Server";
            // 
            // btnSavSerSave
            // 
            this.btnSavSerSave.Location = new System.Drawing.Point(195, 294);
            this.btnSavSerSave.Name = "btnSavSerSave";
            this.btnSavSerSave.Size = new System.Drawing.Size(75, 23);
            this.btnSavSerSave.TabIndex = 9;
            this.btnSavSerSave.Text = "Save";
            this.btnSavSerSave.UseVisualStyleBackColor = true;
            this.btnSavSerSave.Visible = false;
            // 
            // btnSavSerAdd
            // 
            this.btnSavSerAdd.Location = new System.Drawing.Point(524, 294);
            this.btnSavSerAdd.Name = "btnSavSerAdd";
            this.btnSavSerAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSavSerAdd.TabIndex = 8;
            this.btnSavSerAdd.Text = "Add";
            this.btnSavSerAdd.UseVisualStyleBackColor = true;
            // 
            // txtSavSerPass
            // 
            this.txtSavSerPass.Location = new System.Drawing.Point(235, 121);
            this.txtSavSerPass.Name = "txtSavSerPass";
            this.txtSavSerPass.Size = new System.Drawing.Size(128, 20);
            this.txtSavSerPass.TabIndex = 7;
            // 
            // txtSavSerPort
            // 
            this.txtSavSerPort.Location = new System.Drawing.Point(236, 95);
            this.txtSavSerPort.Name = "txtSavSerPort";
            this.txtSavSerPort.Size = new System.Drawing.Size(100, 20);
            this.txtSavSerPort.TabIndex = 6;
            // 
            // txtSavSerIp
            // 
            this.txtSavSerIp.Location = new System.Drawing.Point(236, 69);
            this.txtSavSerIp.Name = "txtSavSerIp";
            this.txtSavSerIp.Size = new System.Drawing.Size(186, 20);
            this.txtSavSerIp.TabIndex = 5;
            // 
            // txtSavSerName
            // 
            this.txtSavSerName.Location = new System.Drawing.Point(235, 43);
            this.txtSavSerName.Name = "txtSavSerName";
            this.txtSavSerName.Size = new System.Drawing.Size(187, 20);
            this.txtSavSerName.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(165, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(192, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Port";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(174, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Host/IP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(183, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Name";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.chkConDelete);
            this.groupBox10.Controls.Add(this.btnDeleteServer);
            this.groupBox10.Controls.Add(this.btnEditServer);
            this.groupBox10.Controls.Add(this.cmbSavSerList);
            this.groupBox10.Enabled = false;
            this.groupBox10.Location = new System.Drawing.Point(6, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(1089, 86);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            // 
            // chkConDelete
            // 
            this.chkConDelete.AutoSize = true;
            this.chkConDelete.Location = new System.Drawing.Point(547, 64);
            this.chkConDelete.Name = "chkConDelete";
            this.chkConDelete.Size = new System.Drawing.Size(95, 17);
            this.chkConDelete.TabIndex = 4;
            this.chkConDelete.Text = "Confirm Delete";
            this.chkConDelete.UseVisualStyleBackColor = true;
            // 
            // btnDeleteServer
            // 
            this.btnDeleteServer.Location = new System.Drawing.Point(465, 57);
            this.btnDeleteServer.Name = "btnDeleteServer";
            this.btnDeleteServer.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteServer.TabIndex = 3;
            this.btnDeleteServer.Text = "Delete";
            this.btnDeleteServer.UseVisualStyleBackColor = true;
            // 
            // btnEditServer
            // 
            this.btnEditServer.Location = new System.Drawing.Point(332, 57);
            this.btnEditServer.Name = "btnEditServer";
            this.btnEditServer.Size = new System.Drawing.Size(75, 23);
            this.btnEditServer.TabIndex = 2;
            this.btnEditServer.Text = "Edit";
            this.btnEditServer.UseVisualStyleBackColor = true;
            // 
            // cmbSavSerList
            // 
            this.cmbSavSerList.FormattingEnabled = true;
            this.cmbSavSerList.Items.AddRange(new object[] {
            "1st Cav Public #1",
            "1st Cav Tradoc"});
            this.cmbSavSerList.Location = new System.Drawing.Point(332, 27);
            this.cmbSavSerList.Name = "cmbSavSerList";
            this.cmbSavSerList.Size = new System.Drawing.Size(208, 21);
            this.cmbSavSerList.TabIndex = 1;
            // 
            // ServerName
            // 
            this.ServerName.DisplayIndex = 0;
            this.ServerName.Text = "Server Name";
            this.ServerName.Width = 363;
            // 
            // Mission
            // 
            this.Mission.DisplayIndex = 1;
            this.Mission.Text = "Mission";
            this.Mission.Width = 247;
            // 
            // Mode
            // 
            this.Mode.DisplayIndex = 2;
            this.Mode.Text = "Mode";
            this.Mode.Width = 79;
            // 
            // Island
            // 
            this.Island.DisplayIndex = 3;
            this.Island.Text = "Island";
            this.Island.Width = 77;
            // 
            // Version
            // 
            this.Version.DisplayIndex = 4;
            this.Version.Text = "Version";
            this.Version.Width = 130;
            // 
            // State
            // 
            this.State.DisplayIndex = 5;
            this.State.Text = "State";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoModsDisabled);
            this.groupBox3.Controls.Add(this.rdoModsEnabled);
            this.groupBox3.Location = new System.Drawing.Point(156, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 60);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mods";
            // 
            // rdoModsDisabled
            // 
            this.rdoModsDisabled.AutoSize = true;
            this.rdoModsDisabled.Location = new System.Drawing.Point(6, 37);
            this.rdoModsDisabled.Name = "rdoModsDisabled";
            this.rdoModsDisabled.Size = new System.Drawing.Size(89, 17);
            this.rdoModsDisabled.TabIndex = 4;
            this.rdoModsDisabled.TabStop = true;
            this.rdoModsDisabled.Text = "Disable Mods";
            this.rdoModsDisabled.UseVisualStyleBackColor = true;
            // 
            // rdoModsEnabled
            // 
            this.rdoModsEnabled.AutoSize = true;
            this.rdoModsEnabled.Location = new System.Drawing.Point(6, 19);
            this.rdoModsEnabled.Name = "rdoModsEnabled";
            this.rdoModsEnabled.Size = new System.Drawing.Size(93, 17);
            this.rdoModsEnabled.TabIndex = 3;
            this.rdoModsEnabled.TabStop = true;
            this.rdoModsEnabled.Text = "Enabled Mods";
            this.rdoModsEnabled.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkParaEnabled);
            this.groupBox4.Location = new System.Drawing.Point(7, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(163, 54);
            this.groupBox4.TabIndex = 5;
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
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkAdvancePara);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(7, 79);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(149, 54);
            this.groupBox6.TabIndex = 8;
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
            this.clbParameters.Location = new System.Drawing.Point(162, 85);
            this.clbParameters.Name = "clbParameters";
            this.clbParameters.Size = new System.Drawing.Size(118, 34);
            this.clbParameters.TabIndex = 10;
            this.clbParameters.Visible = false;
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Enabled = false;
            this.lblDebug.Location = new System.Drawing.Point(322, 24);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(39, 13);
            this.lblDebug.TabIndex = 12;
            this.lblDebug.Text = "Debug";
            this.lblDebug.Visible = false;
            // 
            // clbMods
            // 
            this.clbMods.BackColor = System.Drawing.Color.White;
            this.clbMods.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbMods.ForeColor = System.Drawing.Color.Black;
            this.clbMods.FormattingEnabled = true;
            this.clbMods.Location = new System.Drawing.Point(201, 85);
            this.clbMods.Name = "clbMods";
            this.clbMods.Size = new System.Drawing.Size(118, 21);
            this.clbMods.TabIndex = 13;
            this.clbMods.Visible = false;
            // 
            // mnuServerBrowser
            // 
            this.mnuServerBrowser.BackColor = System.Drawing.Color.Transparent;
            this.mnuServerBrowser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuServerBrowser.Location = new System.Drawing.Point(0, 0);
            this.mnuServerBrowser.Name = "mnuServerBrowser";
            this.mnuServerBrowser.Size = new System.Drawing.Size(1442, 24);
            this.mnuServerBrowser.TabIndex = 17;
            this.mnuServerBrowser.Text = "menuStrip1";
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
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1412, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "&X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label17);
            this.groupBox13.Controls.Add(this.label16);
            this.groupBox13.Controls.Add(this.label14);
            this.groupBox13.Controls.Add(this.txtMissionMap);
            this.groupBox13.Controls.Add(this.txtMissionType);
            this.groupBox13.Controls.Add(this.txtServerName);
            this.groupBox13.Location = new System.Drawing.Point(3, 205);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(319, 87);
            this.groupBox13.TabIndex = 19;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Server Information";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Mission Map:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Mission Type:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Server Name:";
            // 
            // txtMissionMap
            // 
            this.txtMissionMap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMissionMap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMissionMap.Location = new System.Drawing.Point(91, 64);
            this.txtMissionMap.Name = "txtMissionMap";
            this.txtMissionMap.ReadOnly = true;
            this.txtMissionMap.Size = new System.Drawing.Size(221, 13);
            this.txtMissionMap.TabIndex = 3;
            // 
            // txtMissionType
            // 
            this.txtMissionType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMissionType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMissionType.Location = new System.Drawing.Point(91, 38);
            this.txtMissionType.Name = "txtMissionType";
            this.txtMissionType.ReadOnly = true;
            this.txtMissionType.Size = new System.Drawing.Size(221, 13);
            this.txtMissionType.TabIndex = 2;
            // 
            // txtServerName
            // 
            this.txtServerName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtServerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServerName.Location = new System.Drawing.Point(91, 19);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.ReadOnly = true;
            this.txtServerName.Size = new System.Drawing.Size(222, 13);
            this.txtServerName.TabIndex = 0;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.txtBattlEye);
            this.groupBox14.Controls.Add(this.txtServerPortHI);
            this.groupBox14.Controls.Add(this.txtServerAddressHI);
            this.groupBox14.Controls.Add(this.label22);
            this.groupBox14.Controls.Add(this.label19);
            this.groupBox14.Controls.Add(this.label18);
            this.groupBox14.Location = new System.Drawing.Point(3, 119);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(319, 99);
            this.groupBox14.TabIndex = 20;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Host Information";
            // 
            // txtBattlEye
            // 
            this.txtBattlEye.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBattlEye.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBattlEye.Location = new System.Drawing.Point(110, 72);
            this.txtBattlEye.Name = "txtBattlEye";
            this.txtBattlEye.ReadOnly = true;
            this.txtBattlEye.Size = new System.Drawing.Size(202, 13);
            this.txtBattlEye.TabIndex = 5;
            // 
            // txtServerPortHI
            // 
            this.txtServerPortHI.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtServerPortHI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServerPortHI.Location = new System.Drawing.Point(110, 46);
            this.txtServerPortHI.Name = "txtServerPortHI";
            this.txtServerPortHI.ReadOnly = true;
            this.txtServerPortHI.Size = new System.Drawing.Size(202, 13);
            this.txtServerPortHI.TabIndex = 4;
            // 
            // txtServerAddressHI
            // 
            this.txtServerAddressHI.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtServerAddressHI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServerAddressHI.Location = new System.Drawing.Point(110, 20);
            this.txtServerAddressHI.Name = "txtServerAddressHI";
            this.txtServerAddressHI.ReadOnly = true;
            this.txtServerAddressHI.Size = new System.Drawing.Size(202, 13);
            this.txtServerAddressHI.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(50, 75);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "BattlEye:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(36, 49);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Server Port:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Server Address:";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.groupBox3);
            this.groupBox15.Controls.Add(this.groupBox4);
            this.groupBox15.Controls.Add(this.clbMods);
            this.groupBox15.Controls.Add(this.clbParameters);
            this.groupBox15.Controls.Add(this.groupBox6);
            this.groupBox15.Location = new System.Drawing.Point(3, 507);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(319, 139);
            this.groupBox15.TabIndex = 21;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Join Parameters";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.rtxtServerMods);
            this.groupBox16.Location = new System.Drawing.Point(0, 350);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(319, 151);
            this.groupBox16.TabIndex = 22;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Server Mods";
            // 
            // rtxtServerMods
            // 
            this.rtxtServerMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtServerMods.Location = new System.Drawing.Point(10, 19);
            this.rtxtServerMods.Name = "rtxtServerMods";
            this.rtxtServerMods.ReadOnly = true;
            this.rtxtServerMods.Size = new System.Drawing.Size(303, 126);
            this.rtxtServerMods.TabIndex = 0;
            this.rtxtServerMods.Text = "";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.txtMissionName);
            this.groupBox17.Location = new System.Drawing.Point(3, 299);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(316, 45);
            this.groupBox17.TabIndex = 23;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Mission Name:";
            // 
            // txtMissionName
            // 
            this.txtMissionName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMissionName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMissionName.Location = new System.Drawing.Point(9, 19);
            this.txtMissionName.Name = "txtMissionName";
            this.txtMissionName.ReadOnly = true;
            this.txtMissionName.Size = new System.Drawing.Size(301, 13);
            this.txtMissionName.TabIndex = 1;
            // 
            // btnMim
            // 
            this.btnMim.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMim.ForeColor = System.Drawing.Color.White;
            this.btnMim.Location = new System.Drawing.Point(1377, 1);
            this.btnMim.Name = "btnMim";
            this.btnMim.Size = new System.Drawing.Size(29, 23);
            this.btnMim.TabIndex = 24;
            this.btnMim.Text = "&-";
            this.btnMim.UseVisualStyleBackColor = false;
            this.btnMim.Click += new System.EventHandler(this.btnMim_Click);
            // 
            // ServerBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 647);
            this.Controls.Add(this.btnMim);
            this.Controls.Add(this.groupBox17);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox16);
            this.Controls.Add(this.groupBox15);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.mnuServerBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuServerBrowser;
            this.Name = "ServerBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Browser";
            this.Load += new System.EventHandler(this.ServerBrowser_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ServerBrowser_MouseDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpServerPassword.ResumeLayout(false);
            this.grpServerPassword.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.grpRemotePass.ResumeLayout(false);
            this.grpRemotePass.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.mnuServerBrowser.ResumeLayout(false);
            this.mnuServerBrowser.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ColumnHeader ServerName;
        private System.Windows.Forms.ColumnHeader Mission;
        private System.Windows.Forms.ColumnHeader Mode;
        private System.Windows.Forms.ColumnHeader Island;
        private System.Windows.Forms.ColumnHeader Version;
        private System.Windows.Forms.ColumnHeader State;
        private System.Windows.Forms.ListView lvServerBrowser;
        private System.Windows.Forms.ColumnHeader chPassworded;
        private System.Windows.Forms.ColumnHeader chSName;
        private System.Windows.Forms.ColumnHeader chMission;
        private System.Windows.Forms.ColumnHeader chMode;
        private System.Windows.Forms.ColumnHeader chIsland;
        private System.Windows.Forms.ColumnHeader chPlayers;
        private System.Windows.Forms.ColumnHeader chVersion;
        private System.Windows.Forms.ColumnHeader chState;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoModsDisabled;
        private System.Windows.Forms.RadioButton rdoModsEnabled;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkParaEnabled;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkAdvancePara;
        public System.Windows.Forms.ColumnHeader chHost;
        public System.Windows.Forms.ColumnHeader chPort;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.CheckedListBox clbParameters;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.CheckedListBox clbMods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNameFilter;
        private System.Windows.Forms.Button btnNameFilter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpServerPassword;
        private System.Windows.Forms.TextBox txtServerPassword;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox chksPassword;
        private System.Windows.Forms.GroupBox grpRemotePass;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRemoteJoin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemotePassword;
        private System.Windows.Forms.TextBox txtRemotePort;
        private System.Windows.Forms.TextBox txtRemoteHost;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cmbServerSelect;
        private System.Windows.Forms.MenuStrip mnuServerBrowser;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button btnSavSerSave;
        private System.Windows.Forms.Button btnSavSerAdd;
        private System.Windows.Forms.TextBox txtSavSerPass;
        private System.Windows.Forms.TextBox txtSavSerPort;
        private System.Windows.Forms.TextBox txtSavSerIp;
        private System.Windows.Forms.TextBox txtSavSerName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox chkConDelete;
        private System.Windows.Forms.Button btnDeleteServer;
        private System.Windows.Forms.Button btnEditServer;
        private System.Windows.Forms.ComboBox cmbSavSerList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMissionMap;
        private System.Windows.Forms.TextBox txtMissionType;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox txtBattlEye;
        private System.Windows.Forms.TextBox txtServerPortHI;
        private System.Windows.Forms.TextBox txtServerAddressHI;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.RichTextBox rtxtServerMods;
        private System.Windows.Forms.ColumnHeader chBattleye;
        private System.Windows.Forms.ColumnHeader chMod;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.TextBox txtMissionName;
        private System.Windows.Forms.Button btnMim;
    }
}
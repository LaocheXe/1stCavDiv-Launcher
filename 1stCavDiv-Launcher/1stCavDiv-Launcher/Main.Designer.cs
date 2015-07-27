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
            this.btnSettings = new System.Windows.Forms.Button();
            this.clbMods = new System.Windows.Forms.CheckedListBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMlstRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clbParameters = new System.Windows.Forms.CheckedListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkLauncherClose = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkParaEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoModsDisabled = new System.Windows.Forms.RadioButton();
            this.rdoModsEnabled = new System.Windows.Forms.RadioButton();
            this.btnModPackDown = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(435, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(239, 43);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // clbMods
            // 
            this.clbMods.BackColor = System.Drawing.Color.White;
            this.clbMods.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbMods.ForeColor = System.Drawing.Color.Black;
            this.clbMods.FormattingEnabled = true;
            this.clbMods.Location = new System.Drawing.Point(6, 19);
            this.clbMods.Name = "clbMods";
            this.clbMods.Size = new System.Drawing.Size(183, 242);
            this.clbMods.TabIndex = 2;
            this.clbMods.SelectedIndexChanged += new System.EventHandler(this.clbMods_SelectedIndexChanged);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(304, 386);
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
            this.groupBox1.Location = new System.Drawing.Point(103, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 368);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mods List";
            // 
            // btnMlstRefresh
            // 
            this.btnMlstRefresh.Location = new System.Drawing.Point(7, 295);
            this.btnMlstRefresh.Name = "btnMlstRefresh";
            this.btnMlstRefresh.Size = new System.Drawing.Size(182, 58);
            this.btnMlstRefresh.TabIndex = 3;
            this.btnMlstRefresh.Text = "Refresh";
            this.btnMlstRefresh.UseVisualStyleBackColor = true;
            this.btnMlstRefresh.Click += new System.EventHandler(this.btnMlstRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clbParameters);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(304, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 298);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Launch Options";
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
            "-checkSigbatures",
            "-buldozer",
            "-noLand",
            "-noSound",
            "-donothing",
            "/secuexp"});
            this.clbParameters.Location = new System.Drawing.Point(221, 19);
            this.clbParameters.Name = "clbParameters";
            this.clbParameters.Size = new System.Drawing.Size(143, 244);
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
            // btnModPackDown
            // 
            this.btnModPackDown.Enabled = false;
            this.btnModPackDown.Location = new System.Drawing.Point(183, 12);
            this.btnModPackDown.Name = "btnModPackDown";
            this.btnModPackDown.Size = new System.Drawing.Size(171, 43);
            this.btnModPackDown.TabIndex = 6;
            this.btnModPackDown.Text = "Mod Pack Download";
            this.btnModPackDown.UseVisualStyleBackColor = true;
            this.btnModPackDown.Click += new System.EventHandler(this.btnModPackDown_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 595);
            this.Controls.Add(this.btnModPackDown);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.btnSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Launcher - 1st Cavalry Division";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
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
        private System.Windows.Forms.Button btnModPackDown;
        private System.Windows.Forms.RadioButton rdoModsDisabled;
        private System.Windows.Forms.RadioButton rdoModsEnabled;
    }
}


namespace _1stCavDiv_Launcher
{
    partial class AppSettings
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabArmaSettings = new System.Windows.Forms.TabPage();
            this.btnArmabrowse = new System.Windows.Forms.Button();
            this.txtArmabrowse = new System.Windows.Forms.TextBox();
            this.tabParameters = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clbParameters = new System.Windows.Forms.CheckedListBox();
            this.tabPSettings = new System.Windows.Forms.TabPage();
            this.txtExThreads = new System.Windows.Forms.TextBox();
            this.txtCpuCount = new System.Windows.Forms.TextBox();
            this.txtMaxVRAM = new System.Windows.Forms.TextBox();
            this.txtMaxMem = new System.Windows.Forms.TextBox();
            this.txtMalloc = new System.Windows.Forms.TextBox();
            this.txtInit = new System.Windows.Forms.TextBox();
            this.chkInit = new System.Windows.Forms.CheckBox();
            this.chkMalloc = new System.Windows.Forms.CheckBox();
            this.chkexThreads = new System.Windows.Forms.CheckBox();
            this.chkcpuCount = new System.Windows.Forms.CheckBox();
            this.chkmaxVRAM = new System.Windows.Forms.CheckBox();
            this.chkmaxMem = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabTeamspeak = new System.Windows.Forms.TabPage();
            this.txtTsuName = new System.Windows.Forms.TextBox();
            this.btnApplysettings = new System.Windows.Forms.Button();
            this.btnCancelsettings = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabArmaSettings.SuspendLayout();
            this.tabParameters.SuspendLayout();
            this.tabPSettings.SuspendLayout();
            this.tabTeamspeak.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabArmaSettings);
            this.tabControl1.Controls.Add(this.tabParameters);
            this.tabControl1.Controls.Add(this.tabPSettings);
            this.tabControl1.Controls.Add(this.tabTeamspeak);
            this.tabControl1.Location = new System.Drawing.Point(12, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(746, 355);
            this.tabControl1.TabIndex = 2;
            // 
            // tabArmaSettings
            // 
            this.tabArmaSettings.Controls.Add(this.btnArmabrowse);
            this.tabArmaSettings.Controls.Add(this.txtArmabrowse);
            this.tabArmaSettings.Location = new System.Drawing.Point(4, 22);
            this.tabArmaSettings.Name = "tabArmaSettings";
            this.tabArmaSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabArmaSettings.Size = new System.Drawing.Size(738, 329);
            this.tabArmaSettings.TabIndex = 0;
            this.tabArmaSettings.Text = "ArmA 3 Settings";
            this.tabArmaSettings.UseVisualStyleBackColor = true;
            // 
            // btnArmabrowse
            // 
            this.btnArmabrowse.Location = new System.Drawing.Point(510, 46);
            this.btnArmabrowse.Name = "btnArmabrowse";
            this.btnArmabrowse.Size = new System.Drawing.Size(75, 23);
            this.btnArmabrowse.TabIndex = 1;
            this.btnArmabrowse.Text = "Browse";
            this.btnArmabrowse.UseVisualStyleBackColor = true;
            this.btnArmabrowse.Click += new System.EventHandler(this.btnArmabrowse_Click);
            // 
            // txtArmabrowse
            // 
            this.txtArmabrowse.Location = new System.Drawing.Point(17, 20);
            this.txtArmabrowse.Name = "txtArmabrowse";
            this.txtArmabrowse.Size = new System.Drawing.Size(568, 20);
            this.txtArmabrowse.TabIndex = 0;
            // 
            // tabParameters
            // 
            this.tabParameters.Controls.Add(this.label13);
            this.tabParameters.Controls.Add(this.label12);
            this.tabParameters.Controls.Add(this.label11);
            this.tabParameters.Controls.Add(this.label10);
            this.tabParameters.Controls.Add(this.label9);
            this.tabParameters.Controls.Add(this.label8);
            this.tabParameters.Controls.Add(this.label7);
            this.tabParameters.Controls.Add(this.label6);
            this.tabParameters.Controls.Add(this.label5);
            this.tabParameters.Controls.Add(this.label4);
            this.tabParameters.Controls.Add(this.label3);
            this.tabParameters.Controls.Add(this.label1);
            this.tabParameters.Controls.Add(this.clbParameters);
            this.tabParameters.Location = new System.Drawing.Point(4, 22);
            this.tabParameters.Name = "tabParameters";
            this.tabParameters.Padding = new System.Windows.Forms.Padding(3);
            this.tabParameters.Size = new System.Drawing.Size(738, 329);
            this.tabParameters.TabIndex = 1;
            this.tabParameters.Text = "Select Parameters";
            this.tabParameters.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(218, 278);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(218, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(218, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(218, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "-skipIntro : Disables world intros in the main menu permanently.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "-nosplash : Disables splash screens.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(507, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "-window : Displays Arma windowed instead of full screen. Screen resolution / wind" +
    "ow size are in arma3.cfg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Parameters";
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
            this.clbParameters.Location = new System.Drawing.Point(6, 47);
            this.clbParameters.Name = "clbParameters";
            this.clbParameters.Size = new System.Drawing.Size(143, 244);
            this.clbParameters.TabIndex = 0;
            // 
            // tabPSettings
            // 
            this.tabPSettings.Controls.Add(this.txtExThreads);
            this.tabPSettings.Controls.Add(this.txtCpuCount);
            this.tabPSettings.Controls.Add(this.txtMaxVRAM);
            this.tabPSettings.Controls.Add(this.txtMaxMem);
            this.tabPSettings.Controls.Add(this.txtMalloc);
            this.tabPSettings.Controls.Add(this.txtInit);
            this.tabPSettings.Controls.Add(this.chkInit);
            this.tabPSettings.Controls.Add(this.chkMalloc);
            this.tabPSettings.Controls.Add(this.chkexThreads);
            this.tabPSettings.Controls.Add(this.chkcpuCount);
            this.tabPSettings.Controls.Add(this.chkmaxVRAM);
            this.tabPSettings.Controls.Add(this.chkmaxMem);
            this.tabPSettings.Controls.Add(this.label2);
            this.tabPSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPSettings.Name = "tabPSettings";
            this.tabPSettings.Size = new System.Drawing.Size(738, 329);
            this.tabPSettings.TabIndex = 2;
            this.tabPSettings.Text = "Parameters Settings";
            this.tabPSettings.UseVisualStyleBackColor = true;
            // 
            // txtExThreads
            // 
            this.txtExThreads.Location = new System.Drawing.Point(131, 131);
            this.txtExThreads.Name = "txtExThreads";
            this.txtExThreads.Size = new System.Drawing.Size(100, 20);
            this.txtExThreads.TabIndex = 18;
            // 
            // txtCpuCount
            // 
            this.txtCpuCount.Location = new System.Drawing.Point(131, 108);
            this.txtCpuCount.Name = "txtCpuCount";
            this.txtCpuCount.Size = new System.Drawing.Size(100, 20);
            this.txtCpuCount.TabIndex = 17;
            // 
            // txtMaxVRAM
            // 
            this.txtMaxVRAM.Location = new System.Drawing.Point(131, 83);
            this.txtMaxVRAM.Name = "txtMaxVRAM";
            this.txtMaxVRAM.Size = new System.Drawing.Size(100, 20);
            this.txtMaxVRAM.TabIndex = 16;
            // 
            // txtMaxMem
            // 
            this.txtMaxMem.Location = new System.Drawing.Point(131, 60);
            this.txtMaxMem.Name = "txtMaxMem";
            this.txtMaxMem.Size = new System.Drawing.Size(100, 20);
            this.txtMaxMem.TabIndex = 15;
            // 
            // txtMalloc
            // 
            this.txtMalloc.Location = new System.Drawing.Point(131, 154);
            this.txtMalloc.Name = "txtMalloc";
            this.txtMalloc.Size = new System.Drawing.Size(231, 20);
            this.txtMalloc.TabIndex = 14;
            // 
            // txtInit
            // 
            this.txtInit.Location = new System.Drawing.Point(131, 177);
            this.txtInit.Name = "txtInit";
            this.txtInit.Size = new System.Drawing.Size(231, 20);
            this.txtInit.TabIndex = 13;
            // 
            // chkInit
            // 
            this.chkInit.AutoSize = true;
            this.chkInit.Location = new System.Drawing.Point(34, 177);
            this.chkInit.Name = "chkInit";
            this.chkInit.Size = new System.Drawing.Size(48, 17);
            this.chkInit.TabIndex = 11;
            this.chkInit.Text = "-init=";
            this.chkInit.UseVisualStyleBackColor = true;
            // 
            // chkMalloc
            // 
            this.chkMalloc.AutoSize = true;
            this.chkMalloc.Location = new System.Drawing.Point(34, 154);
            this.chkMalloc.Name = "chkMalloc";
            this.chkMalloc.Size = new System.Drawing.Size(65, 17);
            this.chkMalloc.TabIndex = 9;
            this.chkMalloc.Text = "-malloc=";
            this.chkMalloc.UseVisualStyleBackColor = true;
            // 
            // chkexThreads
            // 
            this.chkexThreads.AutoSize = true;
            this.chkexThreads.Location = new System.Drawing.Point(34, 131);
            this.chkexThreads.Name = "chkexThreads";
            this.chkexThreads.Size = new System.Drawing.Size(85, 17);
            this.chkexThreads.TabIndex = 7;
            this.chkexThreads.Text = "-exThreads=";
            this.chkexThreads.UseVisualStyleBackColor = true;
            // 
            // chkcpuCount
            // 
            this.chkcpuCount.AutoSize = true;
            this.chkcpuCount.Location = new System.Drawing.Point(34, 108);
            this.chkcpuCount.Name = "chkcpuCount";
            this.chkcpuCount.Size = new System.Drawing.Size(81, 17);
            this.chkcpuCount.TabIndex = 5;
            this.chkcpuCount.Text = "-cpuCount=";
            this.chkcpuCount.UseVisualStyleBackColor = true;
            // 
            // chkmaxVRAM
            // 
            this.chkmaxVRAM.AutoSize = true;
            this.chkmaxVRAM.Location = new System.Drawing.Point(34, 85);
            this.chkmaxVRAM.Name = "chkmaxVRAM";
            this.chkmaxVRAM.Size = new System.Drawing.Size(85, 17);
            this.chkmaxVRAM.TabIndex = 3;
            this.chkmaxVRAM.Text = "-maxVRAM=";
            this.chkmaxVRAM.UseVisualStyleBackColor = true;
            // 
            // chkmaxMem
            // 
            this.chkmaxMem.AutoSize = true;
            this.chkmaxMem.Location = new System.Drawing.Point(34, 62);
            this.chkmaxMem.Name = "chkmaxMem";
            this.chkmaxMem.Size = new System.Drawing.Size(77, 17);
            this.chkmaxMem.TabIndex = 1;
            this.chkmaxMem.Text = "-maxMem=";
            this.chkmaxMem.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Advance Parameter Settings";
            // 
            // tabTeamspeak
            // 
            this.tabTeamspeak.Controls.Add(this.txtTsuName);
            this.tabTeamspeak.Location = new System.Drawing.Point(4, 22);
            this.tabTeamspeak.Name = "tabTeamspeak";
            this.tabTeamspeak.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeamspeak.Size = new System.Drawing.Size(738, 329);
            this.tabTeamspeak.TabIndex = 3;
            this.tabTeamspeak.Text = "TeamSpeak Settings";
            this.tabTeamspeak.UseVisualStyleBackColor = true;
            // 
            // txtTsuName
            // 
            this.txtTsuName.Location = new System.Drawing.Point(125, 54);
            this.txtTsuName.Name = "txtTsuName";
            this.txtTsuName.Size = new System.Drawing.Size(100, 20);
            this.txtTsuName.TabIndex = 0;
            // 
            // btnApplysettings
            // 
            this.btnApplysettings.Location = new System.Drawing.Point(406, 421);
            this.btnApplysettings.Name = "btnApplysettings";
            this.btnApplysettings.Size = new System.Drawing.Size(75, 23);
            this.btnApplysettings.TabIndex = 3;
            this.btnApplysettings.Text = "Apply";
            this.btnApplysettings.UseVisualStyleBackColor = true;
            this.btnApplysettings.Click += new System.EventHandler(this.btnApplysettings_Click);
            // 
            // btnCancelsettings
            // 
            this.btnCancelsettings.Location = new System.Drawing.Point(526, 421);
            this.btnCancelsettings.Name = "btnCancelsettings";
            this.btnCancelsettings.Size = new System.Drawing.Size(75, 23);
            this.btnCancelsettings.TabIndex = 4;
            this.btnCancelsettings.Text = "Cancel";
            this.btnCancelsettings.UseVisualStyleBackColor = true;
            this.btnCancelsettings.Click += new System.EventHandler(this.btnCancelsettings_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Arma3.exe";
            this.openFileDialog1.Filter = "arma3.exe|arma3.exe";
            // 
            // AppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 456);
            this.Controls.Add(this.btnCancelsettings);
            this.Controls.Add(this.btnApplysettings);
            this.Controls.Add(this.tabControl1);
            this.Name = "AppSettings";
            this.Text = "Settings - 1st Cavalry Division";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabArmaSettings.ResumeLayout(false);
            this.tabArmaSettings.PerformLayout();
            this.tabParameters.ResumeLayout(false);
            this.tabParameters.PerformLayout();
            this.tabPSettings.ResumeLayout(false);
            this.tabPSettings.PerformLayout();
            this.tabTeamspeak.ResumeLayout(false);
            this.tabTeamspeak.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabArmaSettings;
        private System.Windows.Forms.TabPage tabParameters;
        private System.Windows.Forms.Button btnArmabrowse;
        private System.Windows.Forms.TextBox txtArmabrowse;
        private System.Windows.Forms.TabPage tabPSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbParameters;
        private System.Windows.Forms.CheckBox chkInit;
        private System.Windows.Forms.CheckBox chkMalloc;
        private System.Windows.Forms.CheckBox chkexThreads;
        private System.Windows.Forms.CheckBox chkcpuCount;
        private System.Windows.Forms.CheckBox chkmaxVRAM;
        private System.Windows.Forms.CheckBox chkmaxMem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabTeamspeak;
        private System.Windows.Forms.Button btnApplysettings;
        private System.Windows.Forms.Button btnCancelsettings;
        private System.Windows.Forms.TextBox txtTsuName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMalloc;
        private System.Windows.Forms.TextBox txtInit;
        private System.Windows.Forms.TextBox txtExThreads;
        private System.Windows.Forms.TextBox txtCpuCount;
        private System.Windows.Forms.TextBox txtMaxVRAM;
        private System.Windows.Forms.TextBox txtMaxMem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
namespace _1stCav_Updator
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
            this.tabArma = new System.Windows.Forms.TabPage();
            this.btnArmaBrowse = new System.Windows.Forms.Button();
            this.txtArmaPath = new System.Windows.Forms.TextBox();
            this.tab1stCavModSettings = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCheckRepair = new System.Windows.Forms.Label();
            this.pgbCheckRepair = new System.Windows.Forms.ProgressBar();
            this.chkCDelete = new System.Windows.Forms.CheckBox();
            this.btnDeleteMod = new System.Windows.Forms.Button();
            this.btnRepair = new System.Windows.Forms.Button();
            this.btnCheckFiles = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPCversion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblServerVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateRefresh = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabArma.SuspendLayout();
            this.tab1stCavModSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabArma);
            this.tabControl1.Controls.Add(this.tab1stCavModSettings);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(521, 224);
            this.tabControl1.TabIndex = 0;
            // 
            // tabArma
            // 
            this.tabArma.Controls.Add(this.btnArmaBrowse);
            this.tabArma.Controls.Add(this.txtArmaPath);
            this.tabArma.Location = new System.Drawing.Point(4, 22);
            this.tabArma.Name = "tabArma";
            this.tabArma.Padding = new System.Windows.Forms.Padding(3);
            this.tabArma.Size = new System.Drawing.Size(513, 198);
            this.tabArma.TabIndex = 0;
            this.tabArma.Text = "Arma 3 Settings";
            this.tabArma.UseVisualStyleBackColor = true;
            this.tabArma.Click += new System.EventHandler(this.tabArma_Click);
            // 
            // btnArmaBrowse
            // 
            this.btnArmaBrowse.Location = new System.Drawing.Point(369, 65);
            this.btnArmaBrowse.Name = "btnArmaBrowse";
            this.btnArmaBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnArmaBrowse.TabIndex = 1;
            this.btnArmaBrowse.Text = "Browse";
            this.btnArmaBrowse.UseVisualStyleBackColor = true;
            this.btnArmaBrowse.Click += new System.EventHandler(this.btnArmaBrowse_Click);
            // 
            // txtArmaPath
            // 
            this.txtArmaPath.Location = new System.Drawing.Point(24, 38);
            this.txtArmaPath.Name = "txtArmaPath";
            this.txtArmaPath.Size = new System.Drawing.Size(421, 20);
            this.txtArmaPath.TabIndex = 0;
            // 
            // tab1stCavModSettings
            // 
            this.tab1stCavModSettings.Controls.Add(this.label2);
            this.tab1stCavModSettings.Controls.Add(this.groupBox2);
            this.tab1stCavModSettings.Controls.Add(this.groupBox1);
            this.tab1stCavModSettings.Location = new System.Drawing.Point(4, 22);
            this.tab1stCavModSettings.Name = "tab1stCavModSettings";
            this.tab1stCavModSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tab1stCavModSettings.Size = new System.Drawing.Size(513, 198);
            this.tab1stCavModSettings.TabIndex = 1;
            this.tab1stCavModSettings.Text = "1st Cav Mod Settings";
            this.tab1stCavModSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCheckRepair);
            this.groupBox2.Controls.Add(this.pgbCheckRepair);
            this.groupBox2.Controls.Add(this.chkCDelete);
            this.groupBox2.Controls.Add(this.btnDeleteMod);
            this.groupBox2.Controls.Add(this.btnRepair);
            this.groupBox2.Controls.Add(this.btnCheckFiles);
            this.groupBox2.Location = new System.Drawing.Point(301, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check Integrity Of Mod Files";
            // 
            // lblCheckRepair
            // 
            this.lblCheckRepair.AutoSize = true;
            this.lblCheckRepair.Location = new System.Drawing.Point(27, 68);
            this.lblCheckRepair.Name = "lblCheckRepair";
            this.lblCheckRepair.Size = new System.Drawing.Size(156, 13);
            this.lblCheckRepair.TabIndex = 5;
            this.lblCheckRepair.Text = "Checking Files / Repairing Files";
            // 
            // pgbCheckRepair
            // 
            this.pgbCheckRepair.Location = new System.Drawing.Point(7, 84);
            this.pgbCheckRepair.Name = "pgbCheckRepair";
            this.pgbCheckRepair.Size = new System.Drawing.Size(193, 23);
            this.pgbCheckRepair.TabIndex = 4;
            // 
            // chkCDelete
            // 
            this.chkCDelete.AutoSize = true;
            this.chkCDelete.Location = new System.Drawing.Point(97, 167);
            this.chkCDelete.Name = "chkCDelete";
            this.chkCDelete.Size = new System.Drawing.Size(103, 17);
            this.chkCDelete.TabIndex = 3;
            this.chkCDelete.Text = "Confirm Deletion";
            this.chkCDelete.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMod
            // 
            this.btnDeleteMod.Location = new System.Drawing.Point(6, 157);
            this.btnDeleteMod.Name = "btnDeleteMod";
            this.btnDeleteMod.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMod.TabIndex = 2;
            this.btnDeleteMod.Text = "Delete Mod";
            this.btnDeleteMod.UseVisualStyleBackColor = true;
            this.btnDeleteMod.Click += new System.EventHandler(this.btnDeleteMod_Click);
            // 
            // btnRepair
            // 
            this.btnRepair.Enabled = false;
            this.btnRepair.Location = new System.Drawing.Point(97, 128);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(75, 23);
            this.btnRepair.TabIndex = 1;
            this.btnRepair.Text = "Repair";
            this.btnRepair.UseVisualStyleBackColor = true;
            // 
            // btnCheckFiles
            // 
            this.btnCheckFiles.Location = new System.Drawing.Point(6, 128);
            this.btnCheckFiles.Name = "btnCheckFiles";
            this.btnCheckFiles.Size = new System.Drawing.Size(75, 23);
            this.btnCheckFiles.TabIndex = 0;
            this.btnCheckFiles.Text = "Check Files";
            this.btnCheckFiles.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPCversion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblServerVersion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnUpdateRefresh);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check For Updates";
            // 
            // lblPCversion
            // 
            this.lblPCversion.AutoSize = true;
            this.lblPCversion.Location = new System.Drawing.Point(95, 56);
            this.lblPCversion.Name = "lblPCversion";
            this.lblPCversion.Size = new System.Drawing.Size(79, 13);
            this.lblPCversion.TabIndex = 4;
            this.lblPCversion.Text = "version number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "You Version:";
            // 
            // lblServerVersion
            // 
            this.lblServerVersion.AutoSize = true;
            this.lblServerVersion.Location = new System.Drawing.Point(95, 27);
            this.lblServerVersion.Name = "lblServerVersion";
            this.lblServerVersion.Size = new System.Drawing.Size(79, 13);
            this.lblServerVersion.TabIndex = 2;
            this.lblServerVersion.Text = "version number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Version:";
            // 
            // btnUpdateRefresh
            // 
            this.btnUpdateRefresh.Location = new System.Drawing.Point(42, 157);
            this.btnUpdateRefresh.Name = "btnUpdateRefresh";
            this.btnUpdateRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateRefresh.TabIndex = 0;
            this.btnUpdateRefresh.Text = "Refresh";
            this.btnUpdateRefresh.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(373, 251);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(454, 251);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "arma3.exe";
            this.openFileDialog1.Filter = "arma3.exe|arma3.exe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "BETA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "A few Things might not work at the moment";
            // 
            // AppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 286);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabControl1);
            this.Name = "AppSettings";
            this.Text = "Updater Tools - 1st Cavalry Division";
            this.Load += new System.EventHandler(this.AppSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabArma.ResumeLayout(false);
            this.tabArma.PerformLayout();
            this.tab1stCavModSettings.ResumeLayout(false);
            this.tab1stCavModSettings.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabArma;
        private System.Windows.Forms.Button btnArmaBrowse;
        private System.Windows.Forms.TextBox txtArmaPath;
        private System.Windows.Forms.TabPage tab1stCavModSettings;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteMod;
        private System.Windows.Forms.Button btnRepair;
        private System.Windows.Forms.Button btnCheckFiles;
        private System.Windows.Forms.CheckBox chkCDelete;
        private System.Windows.Forms.Label lblPCversion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblServerVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCheckRepair;
        private System.Windows.Forms.ProgressBar pgbCheckRepair;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}
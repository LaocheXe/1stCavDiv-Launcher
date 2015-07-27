namespace _1stCav_Updator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnOptions = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblDownload = new System.Windows.Forms.Label();
            this.lblArmaPath = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblPresent = new System.Windows.Forms.Label();
            this.lblDownloadTotal = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDownloadBMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 226);
            this.progressBar1.Maximum = 1000000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(590, 32);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.UseWaitCursor = true;
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(527, 13);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 23);
            this.btnOptions.TabIndex = 1;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerComplete);
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(222, 119);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(182, 44);
            this.btnFinish.TabIndex = 2;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Location = new System.Drawing.Point(232, 13);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(100, 13);
            this.lblDownload.TabIndex = 3;
            this.lblDownload.Text = "Update/Downloads";
            // 
            // lblArmaPath
            // 
            this.lblArmaPath.AutoSize = true;
            this.lblArmaPath.Location = new System.Drawing.Point(201, 103);
            this.lblArmaPath.Name = "lblArmaPath";
            this.lblArmaPath.Size = new System.Drawing.Size(191, 13);
            this.lblArmaPath.TabIndex = 4;
            this.lblArmaPath.Text = "                  Debug : Get Arma Directory";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(16, 172);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(182, 48);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "BETA";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(420, 172);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(182, 48);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(201, 207);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(38, 13);
            this.lblSpeed.TabIndex = 8;
            this.lblSpeed.Text = "Speed";
            // 
            // lblPresent
            // 
            this.lblPresent.AutoSize = true;
            this.lblPresent.Location = new System.Drawing.Point(361, 207);
            this.lblPresent.Name = "lblPresent";
            this.lblPresent.Size = new System.Drawing.Size(43, 13);
            this.lblPresent.TabIndex = 9;
            this.lblPresent.Text = "Present";
            // 
            // lblDownloadTotal
            // 
            this.lblDownloadTotal.AutoSize = true;
            this.lblDownloadTotal.Location = new System.Drawing.Point(250, 172);
            this.lblDownloadTotal.Name = "lblDownloadTotal";
            this.lblDownloadTotal.Size = new System.Drawing.Size(82, 13);
            this.lblDownloadTotal.TabIndex = 10;
            this.lblDownloadTotal.Text = "Download Total";
            // 
            // btnDownloadBMod
            // 
            this.btnDownloadBMod.Location = new System.Drawing.Point(16, 54);
            this.btnDownloadBMod.Name = "btnDownloadBMod";
            this.btnDownloadBMod.Size = new System.Drawing.Size(117, 46);
            this.btnDownloadBMod.TabIndex = 11;
            this.btnDownloadBMod.Text = "Beta: Download";
            this.btnDownloadBMod.UseVisualStyleBackColor = true;
            this.btnDownloadBMod.Visible = false;
            this.btnDownloadBMod.Click += new System.EventHandler(this.btnDownloadBMod_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 261);
            this.Controls.Add(this.btnDownloadBMod);
            this.Controls.Add(this.lblDownloadTotal);
            this.Controls.Add(this.lblPresent);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lblArmaPath);
            this.Controls.Add(this.lblDownload);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.progressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Download / Update Mod Pack - 1st Cavalry Division";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnOptions;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblDownload;
        private System.Windows.Forms.Label lblArmaPath;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblPresent;
        private System.Windows.Forms.Label lblDownloadTotal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDownloadBMod;
    }
}


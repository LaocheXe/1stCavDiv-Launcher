namespace _1stCavDiv_Launcher
{
    partial class Splash_Load
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
            this.tLoading = new System.Windows.Forms.Timer(this.components);
            this.pgbLoading = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // tLoading
            // 
            this.tLoading.Enabled = true;
            this.tLoading.Interval = 50;
            // 
            // pgbLoading
            // 
            this.pgbLoading.Location = new System.Drawing.Point(21, 178);
            this.pgbLoading.Name = "pgbLoading";
            this.pgbLoading.Size = new System.Drawing.Size(492, 27);
            this.pgbLoading.TabIndex = 0;
            // 
            // Splash_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 230);
            this.Controls.Add(this.pgbLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash_Load";
            this.Text = "Splash_Load";
            this.Load += new System.EventHandler(this.Splash_Load_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tLoading;
        private System.Windows.Forms.ProgressBar pgbLoading;
    }
}
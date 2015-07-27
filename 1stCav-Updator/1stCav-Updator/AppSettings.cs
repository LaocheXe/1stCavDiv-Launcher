using _1stCav_Updator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1stCav_Updator
{
    public partial class AppSettings : Form
    {

        string dirName;

        public void GetFile()
        {
            DialogResult result;
            do
            {
                result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtArmaPath.Text = openFileDialog1.FileName;
                    dirName = System.IO.Path.GetDirectoryName(openFileDialog1.FileName) + "\\";
                    dirName = dirName.Replace("\\", "\\\\");
                }
                else if (result == DialogResult.Cancel)
                {
                    break;
                }
            } 
            while (result != DialogResult.OK);
        }
        public AppSettings()
        {
            InitializeComponent();
        }

        // Load Saved Settings
        private void AppSettings_Load(object sender, EventArgs e)
        {
            txtArmaPath.Text = Properties.Settings.Default.ArmaPath;
        }

        // Close Button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ArmaPath = txtArmaPath.Text;
            Properties.Settings.Default.Save();
        }

        private void btnDeleteMod_Click(object sender, EventArgs e)
        {
            // Delete Mod File
            // If Confirm Deletion Checked
            if (chkCDelete.Checked)
            {
                // Delete Mod

            }
            else
            {
                MessageBox.Show("You did not select the Confirm Deletion Box", "Wait!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnArmaBrowse_Click(object sender, EventArgs e)
        {
            GetFile();
        }

        private void tabArma_Click(object sender, EventArgs e)
        {

        }

    }
}

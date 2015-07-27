using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1stCavDiv_Launcher
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
                    txtArmabrowse.Text = openFileDialog1.FileName;
                    dirName = System.IO.Path.GetDirectoryName(openFileDialog1.FileName) + "\\";
                    dirName = dirName.Replace("\\", "\\\\");
                 }
                else if (result == DialogResult.Cancel)
                  {
                    break;
                  }
                } while (result != DialogResult.OK);
        }

        public AppSettings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // Load Settings
            txtArmabrowse.Text = Properties.Settings.Default.ArmaPath;
            txtTsuName.Text = Properties.Settings.Default.tsUserName;
            txtCpuCount.Text = Properties.Settings.Default.paraCPUCount;
            txtExThreads.Text = Properties.Settings.Default.paraexThreads;
            txtInit.Text = Properties.Settings.Default.paraInit;
            txtMalloc.Text = Properties.Settings.Default.paraMalloc;
            txtMaxMem.Text = Properties.Settings.Default.paraMemMax;
            txtMaxVRAM.Text = Properties.Settings.Default.paraVRAMMax;
            // Load Checked List Box of Parameters
            if(Properties.Settings.Default.selectedParameters != null)
            {
                foreach (int i in Properties.Settings.Default.selectedParameters)
                {
                    clbParameters.SetItemChecked(i, true);
                }
            }
        }

        // Close the Settings Window
        private void btnCancelsettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Apply Settings - Save Them
        private void btnApplysettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ArmaPath = txtArmabrowse.Text;
            Properties.Settings.Default.tsUserName = txtTsuName.Text;
            Properties.Settings.Default.paraMemMax = txtMaxMem.Text;
            Properties.Settings.Default.paraVRAMMax = txtMaxVRAM.Text;
            Properties.Settings.Default.paraCPUCount = txtCpuCount.Text;
            Properties.Settings.Default.paraexThreads = txtExThreads.Text;
            Properties.Settings.Default.paraMalloc = txtMalloc.Text;
            Properties.Settings.Default.paraInit = txtInit.Text;
            Properties.Settings.Default.cparaMemMax = chkmaxMem.Checked;
            Properties.Settings.Default.cparaVRAMMax = chkmaxVRAM.Checked;
            Properties.Settings.Default.cparaexThreads = chkexThreads.Checked;
            Properties.Settings.Default.cparaCPUCount = chkcpuCount.Checked;
            Properties.Settings.Default.cparaMalloc = chkMalloc.Checked;
            Properties.Settings.Default.cparaInit = chkInit.Checked;
            Properties.Settings.Default.selectedParameters = new System.Collections.ArrayList(clbParameters.CheckedIndices);
            // Save Settings - Must be last
            Properties.Settings.Default.Save();
        }

        private void clbParameters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnArmabrowse_Click(object sender, EventArgs e)
        {
            GetFile();
        }

    }
}

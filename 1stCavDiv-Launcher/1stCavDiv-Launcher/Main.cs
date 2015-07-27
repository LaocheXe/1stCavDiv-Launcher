using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1stCavDiv_Launcher
{
    public partial class Main : Form
    {
        // Load Arma Path Saved Setting
        string arma3Path = Properties.Settings.Default["ArmaPath"].ToString();
        // Defile armaPath
        string armaPath = "";
        // Define Mod Names
        string modName = "@*";
        // Load TeamSpeakName
        string tsUsrName = Properties.Settings.Default["tsUserName"].ToString();
        // Load Advance Parameter Settings
        string mxMe = Properties.Settings.Default.paraMemMax;
        string mxVra = Properties.Settings.Default.paraVRAMMax;
        string cpuCon = Properties.Settings.Default.paraCPUCount;
        string exThrea = Properties.Settings.Default.paraexThreads;
        string maLlo = Properties.Settings.Default["paraMalloc"].ToString();
        string inTii = Properties.Settings.Default["paraInit"].ToString();
        // radio Buttons
        public enum ModsOnOff { modsenabled = 1, modsdisabled = 0 };

        public Main()
        {
            InitializeComponent();

            // Check for Arma Path - If none then ask
            // Make sure they add arma path and saved
            if (Properties.Settings.Default.ArmaPath != null)
            {
                // Do Nothing
            }
            else
            {
                // Error Message
                string str = String.Format("Arma 3 Path was not detected.\n \nGo to Options and add your Arma 3 Directory.");
                if (DialogResult.No != MessageBox.Show(str + "\nGo to Options Now?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        AppSettings shoOptions = new AppSettings();
                        shoOptions.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Load Other Settings
            chkLauncherClose.Checked = Properties.Settings.Default.CloseLauncher;
            chkParaEnabled.Checked = Properties.Settings.Default.ParameterEnabled;
            // Load Checked List Box of Parameters
            if (Properties.Settings.Default.selectedParameters != null)
            {
                foreach (int i in Properties.Settings.Default.selectedParameters)
                {
                    clbParameters.SetItemChecked(i, true);
                }
            }
                        // Declair armaPath with Arma3Path
            armaPath = arma3Path.Substring(0, arma3Path.Length - "arma3.exe".Length);

            // Comment
            try
            {
                string[] dirs = Directory.GetDirectories(armaPath, modName);

                clbMods.Items.Clear();

                for (int i = 0; i < dirs.Length; i++)
                {
                    string folderName = Path.GetFileName(dirs[i]);
                    clbMods.Items.Add(folderName, false);
                }
            }
            catch (Exception)
            {
                // Error Message
                string str = String.Format("Arma 3 Path was not detected.\n \nGo to Options and add your Arma 3 Directory.");
                if (DialogResult.No != MessageBox.Show(str + "\nGo to Options Now?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        AppSettings shoOptions = new AppSettings();
                        shoOptions.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            // Load any Saved Mod Selections Clicked
            if (Properties.Settings.Default.selectedMods != null)
            {
                foreach (int i in Properties.Settings.Default.selectedMods)
                {
                    clbMods.SetItemChecked(i, true);
                }
            }

            // Enable or Disable Mods Load
            if (Properties.Settings.Default.ModsOnOff == (int)ModsOnOff.modsenabled)
            {
                rdoModsEnabled.Checked = true;
            }
            else if (Properties.Settings.Default.ModsOnOff == (int)ModsOnOff.modsdisabled)
            {
                rdoModsDisabled.Checked = true;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            AppSettings shoSettings = new AppSettings();
            shoSettings.ShowDialog();
        }

        // ReFresh Mod List
        private void btnMlstRefresh_Click(object sender, EventArgs e)
        {
            // Declair armaPath with Arma3Path
            armaPath = arma3Path.Substring(0, arma3Path.Length - "arma3.exe".Length);

            // Comment
            try
            {
                string[] dirs = Directory.GetDirectories(armaPath, modName);

                clbMods.Items.Clear();

                for (int i = 0; i < dirs.Length; i++)
                {
                    string folderName = Path.GetFileName(dirs[i]);
                    clbMods.Items.Add(folderName, false);
                }
            }
            catch (Exception)
            {
                // Error Message
                string str = String.Format("Arma 3 Path was not detected.\n \nGo to Options and add your Arma 3 Directory.");
                if (DialogResult.No != MessageBox.Show(str + "\nGo to Options Now?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        AppSettings shoOptions = new AppSettings();
                        shoOptions.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            // Load any Saved Mod Selections Clicked
            if (Properties.Settings.Default.selectedMods != null)
            {
                foreach (int i in Properties.Settings.Default.selectedMods)
                {
                    clbMods.SetItemChecked(i, true);
                }
            }
        }

        private void clbMods_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.selectedMods = new System.Collections.ArrayList(clbMods.CheckedIndices);
            Properties.Settings.Default.Save();
        }

        private void chkParaEnabled_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ParameterEnabled = chkParaEnabled.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkLauncherClose_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CloseLauncher = chkLauncherClose.Checked;
            Properties.Settings.Default.Save();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {

            // Start Selection
            string arma3Path = Properties.Settings.Default["ArmaPath"].ToString();
            string armaPath = "";
            string selectedMods = string.Empty;
            string selectedPara = string.Empty;
            string gLaunch = string.Empty;

            if (arma3Path != null)
            {
                armaPath = arma3Path;
            }

            // Start Checking if arma3Path currently exsist
            if (File.Exists(armaPath))
            {
                // Check Box List if not Null then selectedMods
                if (clbMods.CheckedItems != null)
                {
                    // Check Box List Parameters if not null then use selected parameters
                    if (clbParameters.CheckedItems != null)
                    {
                        // For each mod selected
                        foreach (string s in clbMods.CheckedItems)
                            // For each parameter selected
                            foreach (string z in clbParameters.CheckedItems)
                            {
                                // launch game with selected check box list items
                                selectedMods += s + ";";
                                gLaunch += " " + z + " -mod=" + selectedMods;
                            }
                    }
                    // Else no parameters
                    else
                    {
                        foreach (string s in clbMods.CheckedItems)
                        {
                            // Launch game with mods only
                            selectedMods += s + ";";
                            gLaunch += " -mod=" + selectedMods;
                        }
                    }
                }
                // Else with parameters but no mods
                else
                {
                    if (clbParameters.CheckedItems != null)
                    {
                        foreach (string z in clbParameters.CheckedItems)
                        {
                            // launch game with parameters
                           // selectedMods += " " + z;
                            gLaunch += z;
                        }
                    }
                    else
                    {
                        // Or with out any parameters
                       // selectedMods = "";
                        gLaunch += string.Empty;
                    }
                }

                // Same up above but for parameters
                if (clbParameters.CheckedItems != null)
                {
                    foreach (string x in clbParameters.CheckedItems)
                    {
                        selectedPara += " " + x;
                        gLaunch += selectedPara ;
                    }
                }
                else
                {
                   // selectedPara = "";
                    gLaunch += string.Empty;
                }

                // If No Mod Radio Button is Checked
                if (rdoModsDisabled.Checked)
                {
                    // If Parameters is checked
                    if (chkParaEnabled.Checked != false)
                    {
                        ProcessStartInfo pinfo = new ProcessStartInfo();
                        pinfo.FileName = armaPath;
                        pinfo.Arguments = gLaunch;
                        Process.Start(pinfo);
                    }
                    else
                    {
                        // Start Game
                        Process.Start(armaPath);
                    }
                }

                // If With Mod Radio Button is Checked
                else if (rdoModsEnabled.Checked)
                {
                    // Start Game With Mods
                    ProcessStartInfo info = new ProcessStartInfo();
                    info.FileName = armaPath;
                    // Start game with mods added to the line
                    info.Arguments = gLaunch;
                    Process.Start(info);
                }
            }
            else
            {
                // Error Message
                MessageBox.Show("Error: 600\nGame Path Not Detected, Go to settings and select your arma 3 path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // If Close Launcher was selected - When game launches the launcher will close
            if (chkLauncherClose.Checked)
            {
                Properties.Settings.Default.CloseLauncher = chkLauncherClose.Checked;
                Properties.Settings.Default.Save();
                this.Close();
            }


            // Save Settings
            Properties.Settings.Default.selectedMods = new System.Collections.ArrayList(clbMods.CheckedIndices);
            Properties.Settings.Default.ParameterEnabled = chkParaEnabled.Checked;
            Properties.Settings.Default.CloseLauncher = chkLauncherClose.Checked;
            Properties.Settings.Default.ModsOnOff = (int)ModsOnOff.modsdisabled;
            Properties.Settings.Default.ModsOnOff = (int)ModsOnOff.modsenabled;
            Properties.Settings.Default.Save();
        }

        private void btnModPackDown_Click(object sender, EventArgs e)
        {
          //  Thread t = new Thread(new ParameterizedThreadStart(ExecuteResourceExe));
          //  t.Start(Properties.Resources._1stCav_Updator);

            string path = Path.GetTempPath() + "1stCav-Updator.exe";
            string path1 = Path.GetTempPath() + "Ionic.Zip.dll";
            string path2 = Path.GetTempPath() + "SharpCompress.dll";
            //string path2 = Path.Get
            File.WriteAllBytes(path, _1stCavDiv_Launcher.Properties.Resources._1stCav_Updator);
            File.WriteAllBytes(path1, _1stCavDiv_Launcher.Properties.Resources.Ionic_Zip);
            File.WriteAllBytes(path2, _1stCavDiv_Launcher.Properties.Resources.SharpCompress);
            Process.Start(path);
        }

        private void rdoModsEnabled_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ModsOnOff = (int)ModsOnOff.modsenabled;
            Properties.Settings.Default.Save();
        }

        private void rdoModsDisabled_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ModsOnOff = (int)ModsOnOff.modsdisabled;
            Properties.Settings.Default.Save();
        }
    }
}

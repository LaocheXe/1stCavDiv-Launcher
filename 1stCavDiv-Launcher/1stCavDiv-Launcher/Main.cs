using Microsoft.Win32;
//using NATO_TF_Torrent;
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
//        string mxMe = Properties.Settings.Default.paraMemMax;
//        string mxVra = Properties.Settings.Default.paraVRAMMax;
//        string cpuCon = Properties.Settings.Default.paraCPUCount;
//        string exThrea = Properties.Settings.Default.paraexThreads;
//        string maLlo = Properties.Settings.Default["paraMalloc"].ToString();
//        string inTii = Properties.Settings.Default["paraInit"].ToString();
        // radio Buttons
        public enum ModsOnOff { modsenabled = 1, modsdisabled = 0 };
        // ServerBrowser Form
        private ServerBrowser shoServerb;
        private AppSettings shoSettings;
        private AboutBox1 shoAbouts;

        public Main()
        {
            // Splash Screen Setup Needed
            InitializeComponent();
            InitializeServerBrowser();
            InitializeAppSettings();
            InitializeAboutBox1();
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
                        // Try to open this shoServerb
                        try
                        {

                            if (shoSettings.IsAccessible)
                            {
                                return;
                            }

                            if (shoSettings.IsDisposed)
                            {
                                InitializeAppSettings();
                            }
                            shoSettings.Show();
                        }
                        catch (Exception)
                        {
                            // If it is then don't open a new Form
                            // Add nothing here unless it needs a message
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void InitializeServerBrowser()
        {
            shoServerb = new ServerBrowser();
        }

        private void InitializeAppSettings()
        {
            shoSettings = new AppSettings();
        }

        private void InitializeAboutBox1()
        {
            shoAbouts = new AboutBox1();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            // If it is checked and loaded - Change Groupbox Name - Paraneters
            if (chkParaEnabled.Checked)
            {
                groupBox4.Text = "Parameters On";
            }
            else
            {
                groupBox4.Text = "Parameters Off";
            }

            // If it is checked and loaded - Change Groupbox Name - Advacned Paraneters
            if (chkAdvancePara.Checked)
            {
                groupBox6.Text = "Advance Parameters On";
            }
            else
            {
                groupBox6.Text = "Advance Parameters Off";
            }

            // If it is checked and loaded - Change Groupbox Name - Close Launcher
            if (chkLauncherClose.Checked)
            {
                groupBox5.Text = "Close Launcher Is On";
            }
            else
            {
                groupBox5.Text = "Close Launcher Is Off";
            }

            //DeBugs
            lblDeBug.Text = Properties.Settings.Default["paraCPUCount"].ToString();

            // Load Other Settings
            chkLauncherClose.Checked = Properties.Settings.Default.CloseLauncher;
            chkParaEnabled.Checked = Properties.Settings.Default.ParameterEnabled;
            chkAdvancePara.Checked = Properties.Settings.Default.ParameterAdva;
            chkmaxMem.Checked = Properties.Settings.Default.cparaMemMax;
            chkmaxVRAM.Checked = Properties.Settings.Default.cparaVRAMMax;
            chkexThreads.Checked = Properties.Settings.Default.cparaexThreads;
            chkcpuCount.Checked = Properties.Settings.Default.cparaCPUCount;
            chkMalloc.Checked = Properties.Settings.Default.cparaMalloc;
            chkInit.Checked = Properties.Settings.Default.cparaInit;
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
                        // Try to open this shoServerb
                        try
                        {

                            if (shoSettings.IsAccessible)
                            {
                                return;
                            }

                            if (shoSettings.IsDisposed)
                            {
                                InitializeAppSettings();
                            }
                            shoSettings.Show();
                        }
                        catch (Exception)
                        {
                            // If it is then don't open a new Form
                            // Add nothing here unless it needs a message
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            // Try Catch for error issues
            try
            {
                // Load any Saved Mod Selections Clicked
                if (Properties.Settings.Default.selectedMods != null)
                {
                    foreach (int i in Properties.Settings.Default.selectedMods)
                    {
                        clbMods.SetItemChecked(i, true);
                    }
                }
            }
            catch (Exception)
            {
                // Show Error Message
                MessageBox.Show("It seems you have removed a mod that you had selected last time you ran this application, your mod list needs to be re-checked.", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
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

        // ReFresh Mod List
        private void btnMlstRefresh_Click(object sender, EventArgs e)
        {
            // Save Selection
            Properties.Settings.Default.selectedMods = new System.Collections.ArrayList(clbMods.CheckedIndices);
            Properties.Settings.Default.Save();

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
                        // Try to open this shoServerb
                        try
                        {

                            if (shoSettings.IsAccessible)
                            {
                                return;
                            }

                            if (shoSettings.IsDisposed)
                            {
                                InitializeAppSettings();
                            }
                            shoSettings.Show();
                        }
                        catch (Exception)
                        {
                            // If it is then don't open a new Form
                            // Add nothing here unless it needs a message
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            try
            {
                // Load any Saved Mod Selections Clicked
                if (Properties.Settings.Default.selectedMods != null)
                {
                    foreach (int i in Properties.Settings.Default.selectedMods)
                    {
                        clbMods.SetItemChecked(i, true);
                    }
                }
            }
            catch (Exception)
            {
                // Show Error Message
                MessageBox.Show("It seems you have removed a mod that you had selected when you hit the refresh button, your mod list needs to be re-checked.", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void clbMods_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.selectedMods = new System.Collections.ArrayList(clbMods.CheckedIndices);
           // Properties.Settings.Default.selectedMods = new System.Collections.
            Properties.Settings.Default.Save();
        }

        private void chkParaEnabled_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ParameterEnabled = chkParaEnabled.Checked;
            Properties.Settings.Default.Save();

            if (chkParaEnabled.Checked)
            {
                groupBox4.Text = "Parameters On";
            }
            else
            {
                groupBox4.Text = "Parameters Off";
            }
        }

        private void chkLauncherClose_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CloseLauncher = chkLauncherClose.Checked;
            Properties.Settings.Default.Save();

            if (chkLauncherClose.Checked)
            {
                groupBox5.Text = "Close Launcher Is On";
            }
            else
            {
                groupBox5.Text = "Close Launcher Is Off";
            }
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {

            // Start Selection
            string arma3Path = Properties.Settings.Default["ArmaPath"].ToString();
            string armaPath = "";
            string selectedMods = string.Empty;
            string selectedPara = string.Empty;
            string selectedAdvancePara = string.Empty;
            string gLaunch = string.Empty;
            string paraMeMx = Properties.Settings.Default["paraMemMax"].ToString();
            string paraVRAMMx = Properties.Settings.Default["paraVRAMMax"].ToString();
            string paraCPUCt = Properties.Settings.Default["paraCPUCount"].ToString();
            string paraExTs = Properties.Settings.Default["paraexThreads"].ToString();
            string paraMc = Properties.Settings.Default["paraMalloc"].ToString();
            string paraIt = Properties.Settings.Default["paraInit"].ToString();
            string adParaMemMax = string.Empty;
            string adParaVRam = string.Empty;
            string adParaCPUc = string.Empty;
            string adParaExTs = string.Empty;
            string adParaMC = string.Empty;
            string adParaIt = string.Empty;
            string selectedBothPara = string.Empty;
            

            if (arma3Path != null)
            {
                armaPath = arma3Path;
            }

            // If Statements for Advance Parameters Boxes Checked or Not
            if (chkmaxMem.Checked != false)
            {
                adParaMemMax = " -maxMem=" + paraMeMx;
            }

            if (chkmaxVRAM.Checked != false)
            {
                adParaVRam = " -maxVRAM=" + paraVRAMMx;
            }

            if (chkcpuCount.Checked != false)
            {
                adParaCPUc = " -cpuCount=" + paraCPUCt;
            }

            if (chkexThreads.Checked != false)
            {
                adParaExTs = " -exThreads=" + paraExTs;
            }

            if (chkMalloc.Checked != false)
            {
                adParaMC = " -malloc=" + paraMc;
            }

            if (chkInit.Checked != false)
            {
                adParaIt = " -init=" + paraIt;
            }

            // Start Checking if arma3Path currently exsist
            if (File.Exists(armaPath))
            {
                // Advance Parameters Box Checked
                if (chkAdvancePara.Checked != false)
                {
                    if (adParaMemMax != null)
                    {
                        selectedAdvancePara = adParaMemMax;
                    }
                    else if (adParaCPUc != null)
                    {
                        selectedAdvancePara = adParaCPUc;
                    }
                    else if (adParaExTs != null)
                    {
                        selectedAdvancePara = adParaExTs;
                    }
                    else if (adParaIt != null)
                    {
                        selectedAdvancePara = adParaIt;
                    }
                    else if (adParaMC != null)
                    {
                        selectedAdvancePara = adParaMC;
                    }
                    else if (adParaVRam != null)
                    {
                        selectedAdvancePara = adParaVRam;
                    }
                    // CPU Count Twos
                    else if (adParaCPUc + adParaExTs != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaExTs;
                    }
                    else if (adParaCPUc + adParaIt != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaIt;
                    }
                    else if (adParaCPUc + adParaMC != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaMC;
                    }
                    else if (adParaCPUc + adParaMemMax != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaMemMax;
                    }
                    else if (adParaCPUc + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaVRam;
                    }
                    // CPU + Ex Count Threes
                    else if (adParaCPUc + adParaExTs + adParaIt != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaExTs + adParaIt;
                    }
                    else if (adParaCPUc + adParaExTs + adParaMC != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaExTs + adParaMC;
                    }
                    else if (adParaCPUc + adParaExTs + adParaMemMax != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaExTs + adParaMemMax;
                    }
                    else if (adParaCPUc + adParaExTs + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaExTs + adParaVRam;
                    }
                    // CPU + IT Count 3
                    else if (adParaCPUc + adParaMC + adParaIt != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaMC + adParaIt;
                    }
                    else if (adParaCPUc + adParaIt + adParaMemMax != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaIt + adParaMemMax;
                    }
                    else if (adParaCPUc + adParaIt + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaIt + adParaVRam;
                    }
                    // CPU + MC Count 3 - 2
                    else if (adParaCPUc + adParaMC + adParaMemMax != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaMC + adParaMemMax;
                    }
                    else if (adParaCPUc + adParaVRam + adParaMC != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaMC + adParaVRam;
                    }
                    // CPU + MemMax Count 3 - 1
                    else if (adParaCPUc + adParaMemMax + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaMemMax + adParaVRam;
                    }
                    // CPU Count Four - CPU + Ex + It + 4th
                    else if (adParaCPUc + adParaExTs + adParaIt + adParaMC != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaExTs + adParaIt + adParaMC;
                    }
                    else if (adParaCPUc + adParaExTs + adParaIt + adParaMemMax != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaExTs + adParaIt + adParaMemMax;
                    }
                    else if (adParaCPUc + adParaExTs + adParaIt + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaExTs + adParaIt + adParaVRam;
                    }
                    // CPU Count Four - CPU + Ex + MC + 4th
                    else if (adParaCPUc + adParaExTs + adParaMemMax + adParaMC != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaExTs + adParaMemMax + adParaMC;
                    }
                    else if (adParaCPUc + adParaExTs + adParaVRam + adParaMC != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaExTs + adParaVRam + adParaMC;
                    }
                    // CPU Count Four - CPU + Ex + MemMax  + 4th
                    else if (adParaCPUc + adParaExTs + adParaMemMax + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaExTs + adParaMemMax + adParaVRam;
                    }
                    // CPU Count Four - CPU + It + MC + 4th
                    else if (adParaCPUc + adParaIt + adParaMC + adParaMemMax != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaIt + adParaMC + adParaMemMax;
                    }
                    else if (adParaCPUc + adParaIt + adParaMC + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaIt + adParaMC + adParaVRam;
                    }
                    // CPU Count Four - CPU + IT + MemMax + 4th
                    else if (adParaCPUc + adParaIt + adParaMemMax + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaIt + adParaMemMax + adParaVRam;
                    }
                    // CPU Count Five - CPU + Ex + IT + MC + 5th
                    else if (adParaCPUc + adParaExTs + adParaIt + adParaMC + adParaMemMax != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaExTs + adParaIt + adParaMC + adParaMemMax;
                    }
                    else if (adParaCPUc + adParaExTs + adParaIt + adParaMC + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaExTs + adParaIt + adParaMC + adParaVRam;
                    }
                    // CPU Count Five - CPU + Ex + IT + MemMax + 5th
                    else if (adParaCPUc + adParaExTs + adParaIt + adParaMemMax + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaExTs + adParaIt + adParaMemMax + adParaVRam;
                    }
                    // CPU Count Five - CPU + IT + MC + MemMax + 5th
                    else if (adParaCPUc + adParaIt + adParaMC + adParaMemMax + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaIt + adParaMC + adParaMemMax + adParaVRam;
                    }
                    // CPU Count Five - CPU + Ex + MC + MemMax + 5th
                    else if (adParaCPUc + adParaExTs + adParaMC + adParaMemMax + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaExTs + adParaMC + adParaMemMax + adParaVRam;
                    }
                    // CPU Count Six - CPU + Ex + IT + MC + MemMax + VRam
                    else if (adParaCPUc + adParaExTs + adParaIt + adParaMC + adParaMemMax + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaCPUc + adParaExTs + adParaIt + adParaMC + adParaMemMax + adParaVRam;
                    }
                    // Ex Count Twos
                    else if (adParaExTs + adParaIt != null)
                    {
                        selectedAdvancePara = adParaExTs + adParaIt;
                    }
                    else if (adParaExTs + adParaMC != null)
                    {
                        selectedAdvancePara = adParaExTs + adParaMC;
                    }
                    else if (adParaExTs + adParaMemMax != null)
                    {
                        selectedAdvancePara = adParaExTs + adParaMemMax;
                    }
                    else if (adParaExTs + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaExTs + adParaVRam;
                    }
                    // Ex + It Count Threes
                    else if (adParaExTs + adParaIt + adParaMC != null)
                    {
                        selectedAdvancePara = adParaExTs + adParaIt + adParaMC;
                    }
                    else if (adParaExTs + adParaIt + adParaMemMax != null)
                    {
                        selectedAdvancePara = adParaExTs + adParaIt + adParaMemMax;
                    }
                    else if (adParaExTs + adParaIt + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaExTs + adParaIt + adParaVRam;
                    }
                    // Ex + Mc Count 3
                    else if (adParaExTs + adParaMC + adParaMemMax != null)
                    {
                        selectedAdvancePara = adParaExTs + adParaMC + adParaMemMax;
                    }
                    else if (adParaExTs + adParaMC + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaExTs + adParaMC + adParaVRam;
                    }
                    // Ex + MemMax Count 3 - 1
                    else if (adParaExTs + adParaMemMax + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaExTs + adParaMemMax + adParaVRam;
                    }
                    // Ex Count Four - Ex + It + MC + 4th
                    else if (adParaExTs + adParaIt + adParaMC + adParaMemMax != null)
                    {
                        selectedAdvancePara = adParaExTs + adParaIt + adParaMC + adParaMemMax;
                    }
                    else if (adParaExTs + adParaIt + adParaMC + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaExTs + adParaIt + adParaMC + adParaVRam;
                    }
                    // Ex Count Four - Ex + MC + MemMax + 4th
                    else if (adParaExTs + adParaMemMax + adParaMC + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaExTs + adParaMemMax + adParaMC + adParaVRam;
                    }
                    // Ex Count Five - Ex + IT + MC + MemMax + 5th
                    else if (adParaExTs + adParaIt + adParaMC + adParaMemMax + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaExTs + adParaIt + adParaMC + adParaMemMax + adParaVRam;
                    }
                    // It Count Twos
                    else if (adParaIt + adParaMC != null)
                    {
                        selectedAdvancePara = adParaIt + adParaMC;
                    }
                    else if (adParaIt + adParaMemMax != null)
                    {
                        selectedAdvancePara = adParaIt + adParaMemMax;
                    }
                    else if (adParaIt + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaIt + adParaVRam;
                    }
                    // It + Mc Count Threes
                    else if (adParaIt + adParaMC + adParaMemMax != null)
                    {
                        selectedAdvancePara = adParaIt + adParaMC + adParaMemMax;
                    }
                    else if (adParaIt + adParaMC + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaIt + adParaMC + adParaVRam;
                    }
                    // It + MemMax Count 3
                    else if (adParaIt + adParaMemMax + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaIt + adParaMemMax + adParaVRam;
                    }
                    // It Count Four - It + MC + MemMax + 4th
                    else if (adParaIt + adParaMC + adParaMemMax + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaIt + adParaMC + adParaMemMax + adParaVRam;
                    }
                    // MC Count Twos
                    else if (adParaMC + adParaMemMax != null)
                    {
                        selectedAdvancePara = adParaMC + adParaMemMax;
                    }
                    else if (adParaMC + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaMC + adParaVRam;
                    }
                    // MC + MemMax Count Threes
                    else if (adParaMC + adParaMemMax + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaMC + adParaMemMax + adParaVRam;
                    }
                    // MemMax Count Twos
                    else if (adParaMemMax + adParaVRam != null)
                    {
                        selectedAdvancePara = adParaMemMax + adParaVRam;
                    }
                    else
                    {
                        selectedAdvancePara = string.Empty;
                    }

                }

                // Check Box List if not Null then selectedMods
                if (clbMods.CheckedItems != null)
                {
                        // For each mod selected
                        foreach (string s in clbMods.CheckedItems)
                        {
                            // For each parameter selected - launch game with selected check box list items
                            selectedMods += "" + s + ";";
                            gLaunch = " -mod=" + selectedMods;
                        }
                    }

                // Same up above but for parameters
                if (clbParameters.CheckedItems != null)
                {
                    foreach (string x in clbParameters.CheckedItems)
                    {
                        selectedPara += " " + x;
                    }
                }
                else
                {
                    selectedPara = string.Empty;
                }

                // If No Mod Radio Button is Checked
                if (rdoModsDisabled.Checked)
                {
                    // If Parameters is checked
                    if (chkParaEnabled.Checked != false)
                    {
                        if (chkAdvancePara.Checked != false)
                        {
                            ProcessStartInfo painfo = new ProcessStartInfo();
                            painfo.FileName = armaPath;
                            painfo.Arguments = selectedAdvancePara + selectedPara;
                            Process.Start(painfo);
                        }
                        else
                        {
                            ProcessStartInfo pinfo = new ProcessStartInfo();
                            pinfo.FileName = armaPath;
                            pinfo.Arguments = selectedPara;
                            Process.Start(pinfo);
                        }
                    }
          //          else if (chkParaEnabled.Checked != false && chkAdvancePara.Checked != false)
          //          {
          //              selectedBothPara = selectedPara + selectedAdvancePara;
          //              ProcessStartInfo painfo = new ProcessStartInfo();
          //              painfo.FileName = armaPath;
          //              painfo.Arguments = selectedBothPara;
          //              Process.Start(painfo);
          //          }
          //          else if (chkAdvancePara.Checked != false)
          //          {
          //              ProcessStartInfo ainfo = new ProcessStartInfo();
          //              ainfo.FileName = armaPath;
          //              ainfo.Arguments = selectedAdvancePara;
          //              Process.Start(ainfo);
          //          }
                    else
                    {
                        if(chkAdvancePara.Checked != false)
                        {
                            ProcessStartInfo ainfo = new ProcessStartInfo();
                            ainfo.FileName = armaPath;
                            ainfo.Arguments = selectedAdvancePara;
                            Process.Start(ainfo);
                        }
                        else
                        {
                            selectedBothPara = string.Empty;
                            // Start Game
                            Process.Start(armaPath);
                        }
                    }
                }

                // If With Mod Radio Button is Checked
                else if (rdoModsEnabled.Checked)
                {
                    if (chkParaEnabled.Checked != false)
                    {
                        if (chkAdvancePara.Checked != false)
                        {
                            // Start Game With Mods
                            ProcessStartInfo info = new ProcessStartInfo();
                            info.FileName = armaPath;
                            // Start game with mods added to the line
                            info.Arguments = selectedAdvancePara + selectedPara + gLaunch;
                            Process.Start(info);
                        }
                        else
                        {
                            // Start Game With Mods
                            ProcessStartInfo info = new ProcessStartInfo();
                            info.FileName = armaPath;
                            // Start game with mods added to the line
                            info.Arguments = selectedPara + gLaunch;
                            Process.Start(info);
                        }
                    }
      //            else if (chkParaEnabled.Checked != false && chkAdvancePara.Checked != false)
      //            {
      //                selectedBothPara = selectedPara + selectedAdvancePara;
      //                ProcessStartInfo info = new ProcessStartInfo();
      //                info.FileName = armaPath;
      //                info.Arguments = selectedBothPara + gLaunch;
      //                Process.Start(info);
      //            }
      //            else if (chkAdvancePara.Checked != false)
      //            {
      //                ProcessStartInfo info = new ProcessStartInfo();
      //                info.FileName = armaPath;
      //                info.Arguments = selectedAdvancePara + gLaunch;
      //                Process.Start(info);
      //            }
                    else
                    {
                        if (chkAdvancePara.Checked != false)
                        {
                            // Start Game With Mods
                            ProcessStartInfo info = new ProcessStartInfo();
                            info.FileName = armaPath;
                            // Start game with mods added to the line
                            info.Arguments = selectedAdvancePara + gLaunch;
                            Process.Start(info);
                        }
                        else
                        {
                            selectedBothPara = string.Empty;
                            // Launch 
                            ProcessStartInfo info = new ProcessStartInfo();
                            info.FileName = armaPath;
                            info.Arguments = gLaunch;
                            Process.Start(info);
                        }
                    }
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
                Properties.Settings.Default.ModsOnOff = (int)ModsOnOff.modsdisabled;
                Properties.Settings.Default.ModsOnOff = (int)ModsOnOff.modsenabled;
                Properties.Settings.Default.Save();
                this.Close();
            }
            else
            {
                Properties.Settings.Default.CloseLauncher = chkLauncherClose.Checked;
                Properties.Settings.Default.ModsOnOff = (int)ModsOnOff.modsdisabled;
                Properties.Settings.Default.ModsOnOff = (int)ModsOnOff.modsenabled;
                Properties.Settings.Default.Save();
                this.WindowState = FormWindowState.Minimized;
            }


            // Save Settings
            Properties.Settings.Default.selectedMods = new System.Collections.ArrayList(clbMods.CheckedIndices);
            Properties.Settings.Default.ParameterEnabled = chkParaEnabled.Checked;
            Properties.Settings.Default.CloseLauncher = chkLauncherClose.Checked;
            Properties.Settings.Default.ModsOnOff = (int)ModsOnOff.modsdisabled;
            Properties.Settings.Default.ModsOnOff = (int)ModsOnOff.modsenabled;
            Properties.Settings.Default.Save();
        }

        private void rdoModsEnabled_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ModsOnOff = (int)ModsOnOff.modsenabled;
            Properties.Settings.Default.Save();

            groupBox3.Text = "Mods On";
        }

        private void rdoModsDisabled_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ModsOnOff = (int)ModsOnOff.modsdisabled;
            Properties.Settings.Default.Save();

            groupBox3.Text = "Mods Off";
        }

        private void clbMods_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int aCount = clbMods.Items.Count;
            int sCount = clbMods.CheckedItems.Count;

            if (e.NewValue == CheckState.Checked) { ++sCount; }
            if (e.NewValue == CheckState.Unchecked) { --sCount; }

            groupBox1.Text = "Mods List" + " " + sCount + "/" + aCount;
        }

        private void chkAdvancePara_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ParameterAdva = chkAdvancePara.Checked;
            Properties.Settings.Default.Save();

            if (chkAdvancePara.Checked)
            {
                groupBox6.Text = "Advance Parameters On";
            }
            else
            {
                groupBox6.Text = "Advance Parameters Off";
            }
        }

        // About Tool Strip Button
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Try to open this shoServerb
            try
            {

                if (shoAbouts.IsAccessible)
                {
                    return;
                }

                if (shoAbouts.IsDisposed)
                {
                    InitializeAboutBox1();
                }
                shoAbouts.Show();
            }
            catch (Exception)
            {
                // If it is then don't open a new Form
                // Add nothing here unless it needs a message
            }
        }

        // Settings Tool Strip Button
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Try to open this shoServerb
            try
            {

                if (shoSettings.IsAccessible)
                {
                    return;
                }

                if (shoSettings.IsDisposed)
                {
                    InitializeAppSettings();
                }
                shoSettings.Show();
            }
            catch (Exception)
            {
                // If it is then don't open a new Form
                // Add nothing here unless it needs a message
            }
        }

        // Restart Tool Strip Button
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        // Exit Tool Strip Button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Mod Pack Downloads
        private void modPackToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Server Browser Tool Strip Button
        private void serverBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Try to open this shoServerb
            try
            {

                if (shoServerb.IsAccessible)
                {
                    return;
                }

                if (shoServerb.IsDisposed)
                {
                    InitializeServerBrowser();
                }

                shoServerb.Show();
            }
            catch (Exception)
            {
                // If it is then don't open a new Form
                // Add nothing here unless it needs a message
            }
        }

        // FAQ Tool Strip Button
        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Support Page Tool Strip Button
        private void supportPageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // TeamSpeak Tool Strip Button
        private void teamSpeak3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tsUrl = "ts3server://ts.1stcavdiv.us/?port=9987&nickname=";
            string tsName = Properties.Settings.Default["tsUserName"].ToString();
            Process.Start(tsUrl + tsName);
        }

        // TeamSpeak Tool Strip Button
        private void btnJoinTS_Click(object sender, EventArgs e)
        {
            string tsUrl = "ts3server://ts.1stcavdiv.us/?port=9987&nickname=";
            string tsName = Properties.Settings.Default["tsUserName"].ToString();
            Process.Start(tsUrl + tsName);
        }

        // Play With SIX Download
        private void pWSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = "PWS://six.1stcavdiv.us";
            Process.Start(path);
        }

        //Torrent Download
        private void torrentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmMain = new frmMain();
           // NATO_TF_Torrent.frmMain theTorrent = new NATO_TF_Torrent.frmMain();
          //  theTorrent.Show();
        }
    }
}

using IWshRuntimeLibrary;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1stCavDiv_Launcher
{
    public partial class AppSettings : Form
    {
        //Arma 3 Path
        string dirName;

        // Mod Collection Set up
        protected internal ArrayList modAllList = new ArrayList();
        private OrderedDictionary Groups = new OrderedDictionary();
        private OrderedDictionary Presets = new OrderedDictionary();
        //private StringCollection Groups = new StringCollection();
        //private StringCollection Presets = new StringCollection();
        string preset;
        string group;

        // Icon Parameters strings
        string maxMe = string.Empty;
        string maxVr = string.Empty;
        string cpuCo = string.Empty;
        string exThr = string.Empty;
        string malLo = string.Empty;
        string selectedPara = string.Empty;
        string selectedMods = string.Empty;
        string modLaunch = string.Empty;
        string glString = string.Empty;
        // Load Arma Path Saved Setting
        string arma3Path = Properties.Settings.Default["ArmaPath"].ToString();
        // Defile armaPath
        string armaPath = "";
        // Define Mod Names
        string modName = "@*";

        public void loadPresets()
        {
            Presets.Clear();
            foreach (string prset in Properties.Settings.Default.PresetList)
            {
                preset = prset;
                string key = preset.Substring(0, preset.IndexOf(";"));
                string value = preset.Substring(preset.IndexOf(";") + 1);
                Presets.Add(key, value);
            }
        }

        public void loadGroups()
        {
            Groups.Clear();
            foreach (string grup in Properties.Settings.Default.GroupList)
            {
                group = grup;
                string key = group.Substring(0, group.IndexOf(";"));
                string value = group.Substring(group.IndexOf(";") + 1);
                Groups.Add(key, value);
            }
        }

        public void savePresets()
        {
            //Properties.Settings.Default.PresetList = new System.Collections.Specialized.StringCollection(Presets);
            Properties.Settings.Default.PresetList.Clear();
            foreach (string prst in Presets.Keys)
            {
                preset = prst;
               // Properties.Settings.Default.PresetList.Add(preset + ";" + Presets.Item[preset]);
                //Properties.Settings.Default.PresetList.Add(preset + ";" + Presets.Contains(preset));
            }
            Properties.Settings.Default.Save();
        }

        public void saveGroups()
        {            
            //Properties.Settings.Default.PresetList = new System.Collections.Specialized.StringCollection(Presets);
            Properties.Settings.Default.GroupList.Clear();
            foreach (string grup in Groups.Keys)
            {
                group = grup;
                //Properties.Settings.Default.PresetList.Add(preset + ";" + Presets.Item(preset));
                Properties.Settings.Default.GroupList.Add(group + ";" + Groups.Contains(group));
            }
            Properties.Settings.Default.Save();
        }

        public void refreshcmbPresets()
        {
            //string oldSelected = cmbPreset.SelectedItem;
            object oldSelected = cmbPreset.SelectedItem;

            cmbPreset.Items.Clear();

            foreach (string prsts in Presets.Keys)
            {
                preset = prsts;
                cmbPreset.Items.Add(preset);
            }
            cmbPreset.SelectedItem = oldSelected;
        }

        private string getGroupNameFromString(string @group)
        {
            return
            @group.Substring(0, @group.IndexOf(";"));
        }

        private ArrayList getGroupModsFromString(string @group)
        {
            ArrayList mods = new ArrayList();

            if (string.IsNullOrEmpty(@group))
            {
                return mods;
            }
            loadGroups();
            if (@group.Contains(";"))
            {
                @group = @group.Substring(0, @group.IndexOf(";"));
            }
            
        //    string modsStr = Groups.Item(@group);

       //     if ((!string.IsNullOrEmpty(modsStr)))
        //    {
        //        mods.AddRange(modStr.Split(","));
         //   }

            return mods;
        }

        private void refreshPresetCmb()
        {
            // Was string
            object oldSelected = cmbPreset.SelectedItem;

            cmbPreset.Items.Clear();

            foreach (string prset in Presets.Keys)
            {
                preset = prset;
                cmbPreset.Items.Add(preset);
            }
            cmbPreset.SelectedItem = oldSelected;
        }

        private object getPreset(string preset)
        {
          //  dynamic presetArray = Presets.Item(preset).Split(",");
            dynamic presetArrayList = new ArrayList();
         //   presetArrayList.AddRange(presetArray);
            return presetArrayList;
        }

        private void savePresets(string preset, ArrayList mods)
        {
         //   string modStr = string.Join(",", mods.ToArray);
         //   Presets.Item(preset) = modStr;
        }

       // private bool modIsActiveInGroup(string _mod)
       // {
       //     foreach (ListViewItem item in lvMods.Items)
       //     {
       //         if (!item.Text.StartsWith("@"))
       //         {
       //             if (getGroupModsFromString(item.Text).Contains(_mod))
       //             {
       //                 return true;
       //             }
       //         }
       //         return false;
       //     }
       // }

        private void addModsToCurrent()
        {
            dynamic modsToAdd = lvMods.SelectedItems;

            if (modsToAdd.Count == 0)
            {
                // Do nothing Here
            }
            if ((cmbPreset.SelectedItem == null))
            {
                Presets.Add("New Preset", "");
                refreshPresetCmb();
                cmbPreset.SelectedItem = "New Preset";
                savePresets();
            }
        //    ArrayList preset = getPreset(cmbPreset.SelectedItem);
         //   int numAdded = 0;
            ArrayList modsAdded = new ArrayList();

            modsAdded.AddRange(modsToAdd);
            foreach (ListViewItem m in modsToAdd)
            {
                dynamic modname = m.Text;
                if (!preset.Contains(modname) & !string.IsNullOrEmpty(modname))
                {
                 //   preset.Add(modname);
                 //   numAdded += 1;
                }
                else
                {
                    modsAdded.Remove(m);
                }
            }

            if (preset.Contains(""))
            {
           //     preset.Remove("");
            }
           // savePresets(cmbPreset.SelectedItem, preset);
           // updateCurrentPreset();
            lvGroupMods.Focus();
            foreach (string m_loopVariable in modsAdded)
            {
                //m = m_loopVariable;
               // lvGroupMods.FindItemWithText(m.Text, true, 0).Selected = true;
            }
            if (modsToAdd.Count == 1)
            {
                if (modsAdded.Count == 1)
                {
                 //   string itemText = modsAdded.Item(0).Text;
                }
            }
        }

        private void removeModsFromCurrent()
        {
            dynamic modsToRemove = lvGroupMods.SelectedItems;

       //     ArrayList preset = getPreset(cmbPreset.SelectedItem);
            //int numRemoved = 0
            ArrayList modsRemoved = new ArrayList();

            modsRemoved.AddRange(modsToRemove);
            foreach (object m_loopVariable in modsToRemove)
            {
       //         m = m_loopVariable;
       //         preset.Remove(m.Text);

       //         savePresets(cmbPreset.SelectedItem, preset);
      //          updateCurrentPreset();
                lvGroupMods.Focus();
            }
        }

        public void updateAllModsList()
        {
            modAllList.Clear();
            lvMods.Items.Clear();

            if((Properties.Settings.Default.GroupList != null))
            {
                if (Properties.Settings.Default.GroupList.Count > 0)
                {
                    foreach (string grp in Properties.Settings.Default.GroupList)
                    {
                        @group = grp;
                        dynamic groupName = getGroupNameFromString(@group);
                    }
                }
                // Arma 3 Path
                armaPath = arma3Path.Substring(0, arma3Path.Length - "arma3.exe".Length);
                // Try Catch For Arma 3 Path
                try
                {
                    string[] dirs = Directory.GetDirectories(armaPath, modName);

                    lvMods.Items.Clear();

                    for (int i = 0; i < dirs.Length; i++)
                    {
                        string folderName = Path.GetFileName(dirs[i]);
                        //lvMods.Items.Add(folderName);
                        modAllList.Add(folderName);

                        dynamic listItem = lvMods.Items.Add(folderName);
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
                           // AppSettings shoOptions = new AppSettings();
                           // AppSettings = (Form) new AppSettings(frmTorrentDownload.reg);
                            //shoOptions.ShowDialog();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

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
            // Cancel Button Disable
            //btnCancelsettings.Enabled = false;
            // Load Settings
            txtArmabrowse.Text = Properties.Settings.Default.ArmaPath;
            txtTsuName.Text = Properties.Settings.Default.tsUserName;
            txtCpuCount.Text = Properties.Settings.Default.paraCPUCount;
            txtExThreads.Text = Properties.Settings.Default.paraexThreads;
            txtInit.Text = Properties.Settings.Default.paraInit;
            txtMalloc.Text = Properties.Settings.Default.paraMalloc;
            txtMaxMem.Text = Properties.Settings.Default.paraMemMax;
            txtMaxVRAM.Text = Properties.Settings.Default.paraVRAMMax;
            txtWUserName.Text = Properties.Settings.Default.WebsiteUserName;
            txtWUPassword.Text = Properties.Settings.Default.WebsiteUserPass;
            chkmaxMem.Checked = Properties.Settings.Default.cparaMemMax;
            chkmaxVRAM.Checked = Properties.Settings.Default.cparaVRAMMax;
            chkexThreads.Checked = Properties.Settings.Default.cparaexThreads;
            chkcpuCount.Checked = Properties.Settings.Default.cparaCPUCount;
            chkMalloc.Checked = Properties.Settings.Default.cparaMalloc;
            chkInit.Checked = Properties.Settings.Default.cparaInit;
            // Load Checked List Box of Parameters
            if(Properties.Settings.Default.selectedParameters != null)
            {
                foreach (int i in Properties.Settings.Default.selectedParameters)
                {
                    clbParameters.SetItemChecked(i, true);
                }
            }
            // Preset Section
           // if ((Properties.Settings.Default.PresetList == null))
           // {
           //     Properties.Settings.Default.PresetList = new StringCollection();
           //     Presets = new OrderedDictionary();
           //     Presets.Add("Vanilla", "");
           //     Properties.Settings.Default.Save();
           // }
           // else if (Properties.Settings.Default.PresetList.Count == 0)
           // {
           //     Presets.Add("Vanilla", "");
           //     Properties.Settings.Default.Save();
           // }
           // else
           // {
           //     loadPresets();
           // }

           // refreshcmbPresets();
           // updateAllModsList();
           // cmbPreset.SelectedIndex = 0;

            // Declair armaPath with Arma3Path
            armaPath = arma3Path.Substring(0, arma3Path.Length - "arma3.exe".Length);

            // Comment
            try
            {
                string[] dirs = Directory.GetDirectories(armaPath, modName);

                lvMods.Items.Clear();
                clbMods.Items.Clear();

                for (int i = 0; i < dirs.Length; i++)
                {
                    string folderName = Path.GetFileName(dirs[i]);
                    lvMods.Items.Add(folderName);
                    clbMods.Items.Add(folderName);
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
                     //   AppSettings shoOptions = new AppSettings();
                     //   shoOptions.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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
            Properties.Settings.Default.WebsiteUserName = txtWUserName.Text;
            Properties.Settings.Default.WebsiteUserPass = txtWUPassword.Text;
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

        // Get Arma3.exe Path Function
        private void btnArmabrowse_Click(object sender, EventArgs e)
        {
            GetFile();
        }

        // Close Button Function
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the settings window
            this.Close();
        }

        // Forget Password LinkLabel
        private void linkWForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string forgotPass = "http://natotaskforce.com/fpw.php";

            Process.Start(forgotPass);
        }

        // Register Account LinkLabel
        private void linklWRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string registerAccount = "http://natotaskforce.com/signup.php";

            Process.Start(registerAccount);
        }

        // Login Function
        private void btnWlogIn_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        // Add Mod/s to Collection
        private void btnAddMod_Click(object sender, EventArgs e)
        {
            // addModsToCurrent
            addModsToCurrent();
        }

        // Remove Mod/s from Collection
        private void btnRemoveMod_Click(object sender, EventArgs e)
        {
            // removeModsFromCurrent
            removeModsFromCurrent();
        }

        // Add Mods To Collection
        private void addModsToCollection()
        {

        }
        // tab Menu Mod Groups
        private void tabModGroups_Click(object sender, EventArgs e)
        {   

        }

        private void cmbPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
     //       updateCurrentPreset();
        }

        private void btnNewSetList_Click(object sender, EventArgs e)
        {
            string title = txtPrStName.Text;

        }

        // Create Desktop Icon for user
        private void btnCreateIcon_Click(object sender, EventArgs e)
        {
            // Try and catch my unknown errors
            try
            {
                // If Checks Value Null
                if (chkMaxMemIcon.Checked == true)
                {
                    if (txtMaxMemIcon.Text == null)
                    {
                        // Needs Error Message
                        string str = String.Format("You left the text area for Max Memeory Blank - Make sure you know what you are doing.");
                    }
                    else
                    {
                        // String gets vlue
                        maxMe = " -maxMe=" + txtMaxMemIcon.Text;
                    }
                }
                else
                {
                    maxMe = string.Empty;
                }

                if (chkMaxVRAMIcon.Checked == true)
                {
                    if (txtMaxVRAMIcon.Text == null)
                    {
                        // Needs Error Message
                        string str = String.Format("You left the text area for Max VRAM Blank - Make sure you know what you are doing.");

                    }
                    else
                    {
                        // String gets vlue
                        maxVr = " -maxVRAM=" + txtMaxVRAMIcon.Text;
                    }
                }
                else
                {
                    maxVr = string.Empty;
                }

                if (chkCPUCountIcon.Checked == true)
                {
                    if (cmbCPUCointIcon.SelectedIndex == -1)
                    {
                        // Needs Error Message
                        string str = String.Format("You did not select a value in CPU Count - Make sure you know what you are doing.");
                    }
                    else
                    {
                        // String gets vlue
                        cpuCo = " -cpuCount=" + cmbCPUCointIcon.SelectedItem;
                    }
                }
                else
                {
                    cpuCo = string.Empty;
                }

                if (chkExThreadsIcon.Checked == true)
                {
                    if (cmbExThreadsIcon.SelectedIndex == -1)
                    {
                        // Needs Error Message
                        string str = String.Format("You did not select a value in Ex Threads - Make sure you know what you are doing.");
                    }
                    else
                    {
                        // String gets vlue
                        exThr = " -exThreads=" + cmbExThreadsIcon.SelectedItem;
                    }
                }
                else
                {
                    exThr = string.Empty;
                }

                if (chkMallocIcon.Checked == true)
                {
                    if (cmbMallocIcon.SelectedIndex == -1)
                    {
                        // Needs Error Message
                        string str = String.Format("You did not select a value in Malloc - Make sure you know what you are doing.");
                    }
                    else
                    {
                        // String gets vlue
                        malLo = " -malloc=" + cmbMallocIcon.SelectedItem;
                    }
                }
                else
                {
                    malLo = string.Empty;
                }

                if (txtShortCutName.Text == null)
                {
                    // Error
                    string str = String.Format("You for got to give your short cut a name - Make sure you know what you are doing.");
                }

                if (clbMods.CheckedItems != null)
                {
                    // For each mod selected
                    foreach (string s in clbMods.CheckedItems)
                    {
                        // For each parameter selected - launch game with selected check box list items
                        selectedMods += "" + s + ";";
                        modLaunch = " -mod=" + selectedMods;
                    }
                }
                else
                {
                    modLaunch = string.Empty;
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
            }
            catch (Exception)
            {
                // Do Nothing
            }

            try
            {
                //    object wsh = Interaction.CreateObject("WScript.Shell");
                //    dynamic desktopPath = wsh.SpecialFolders("Desktop");
                //    string shortcutName = null;

                //    if ((cmbPreset.SelectedItem == null))
                //    {
                //        shortcutName = "Arma 3 with Parameters";
                //    }
                //    else
                //    {
                //        shortcutName = cmbPreset.SelectedItem;
                //    }

                //    dynamic shortcut = wsh.CreateShortcut(desktopPath + "\\" + shortcutName + ".lnk");

                //    shortcut.TargetPath = wsh.ExpandEnvironmentStrings("\"" + steamExe + "\"");
                //    shortcut.Arguments = wsh.ExpandEnvironmentStrings("-applaunch 107410 " + launchString);
                //    shortcut.IconLocation = wsh.ExpandEnvironmentStrings(My.Settings.A3Path);
                //    shortcut.WindowStyle = 4;

                //    shortcut.save();
                //    setStatus("Shortcut of preset " + cmbPreset.SelectedItem + " created", true);

               // if (chkAdvancePara.Checked != false)
               // {
               //     ProcessStartInfo painfo = new ProcessStartInfo();
               //     painfo.FileName = armaPath;
               //     painfo.Arguments = selectedAdvancePara + selectedPara;
               //     Process.Start(painfo);
               // }
               // else
               // {
               //     ProcessStartInfo pinfo = new ProcessStartInfo();
               //     pinfo.FileName = armaPath;
               //     pinfo.Arguments = selectedPara;
               //     Process.Start(pinfo);
               // }


               // arma3Path
               // object wsh = Interaction.CreateObject("WScript.Shell");
               // dynamic desktopPath = wsh.SpecialFolders("Desktop");
               // string deskDir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string shortcutName = txtShortCutName.Text;
               // object shDesktop = (object)"Desktop";
                WshShell shell = new WshShell();
                IWshShortcut shortcut = shell.CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + shortcutName + ".lnk") as IWshShortcut;
                shortcut.Arguments = selectedPara + maxMe + maxVr + cpuCo + exThr + malLo + modLaunch;
                shortcut.TargetPath = arma3Path;
                shortcut.WindowStyle = 1;
                shortcut.Description = "Shortcut created by LaocheXe 1st Cavalry Division Launcher";
                shortcut.WorkingDirectory = armaPath;
                shortcut.IconLocation = arma3Path;
                shortcut.Save();
            }
            catch (Exception)
            {
                // Do nothing
            }


        }
    }
}

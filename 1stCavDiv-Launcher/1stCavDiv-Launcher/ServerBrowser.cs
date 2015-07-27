//using BrightIdeasSoftware;
//using BrightIdeasSoftware.Design;
using System;
using System.Collections;
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
using System.Windows;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XmlConfiguration;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Xml.Resolvers;
using System.Xml.Linq;

namespace _1stCavDiv_Launcher
{
    public partial class ServerBrowser : Form
    {
        // public Main MainForm { get; set; }
        // Public const for movement
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        // Import DLL For Movement
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // Radio Buttons
        public enum ModsOnOff { modsenabled = 1, modsdisabled = 0 };
        // Load Arma Path Saved Setting
        string arma3Path = Properties.Settings.Default["ArmaPath"].ToString();
        // Defile armaPath
        string armaPath = "";
        // Define Mod Names
        string modName = "@*";
        // Document Gloval Veriable
       // XDocument doc = XDocument.Load("http://arma3.swec.se/server/list.xml");


        // Initializing the Component ServerBrowser Form
        public ServerBrowser()
        {
            InitializeComponent(); // Must Have To Work
        }
        // To move the ServerBrowser Form
        private void ServerBrowser_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Main ServerBrowser Form Load
        private void ServerBrowser_Load(object sender, EventArgs e)
        {
            cmbServerSelect.SelectedIndex = 0;

            if (lvServerBrowser.Items.Count == 0)
            {
                btnRefresh.Text = "Get List";
            }

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

            // Load Other Settings
            chkParaEnabled.Checked = Properties.Settings.Default.ParameterEnabled;
            chkAdvancePara.Checked = Properties.Settings.Default.ParameterAdva;

            // Load Checked List Box of Parameters
            if (Properties.Settings.Default.selectedParameters != null)
            {
                foreach (int i in Properties.Settings.Default.selectedParameters)
                {
                    clbParameters.SetItemChecked(i, true);
                }
            }

            // Yeah Needs clair
            armaPath = arma3Path.Substring(0, arma3Path.Length - "arma3.exe".Length);
            string[] dirs = Directory.GetDirectories(armaPath, modName);
            clbMods.Items.Clear();
            for (int i = 0; i < dirs.Length; i++)
            {
                string folderName = Path.GetFileName(dirs[i]);
                clbMods.Items.Add(folderName, false);
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

        // Button Refresh to get new/updated server list
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (lvServerBrowser.Items.Count != 0)
            {
                lvServerBrowser.Items.Clear();
            }
            XDocument doc = XDocument.Load("http://arma3.swec.se/server/list.xml");
            // Gets the Elements set from the Document
            IEnumerable<XElement> serverElements = doc.Descendants("server");
            // Start the Foreach Elements Values
            foreach (XElement serverElement in serverElements)
            {
                // Getting the XML Elelmets line up with ListViewItems
                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                        serverElement.Element("passworded").Value, // Password
                        serverElement.Element("name").Value,       // Server Name
                        serverElement.Element("mission").Value,    // Mission Name
                        serverElement.Element("mode").Value,       // Mission Type
                        serverElement.Element("island").Value,     // Mission Map
                        serverElement.Element("players").Value,    // Current Players
                        serverElement.Element("version").Value,    // Current Version
                        serverElement.Element("state").Value,      // Current State
                        serverElement.Element("host").Value,       // Host IP/Server Address
                        serverElement.Element("port").Value,       // Server Port
                        serverElement.Element("battleye").Value,   // BattlEye
                        serverElement.Element("mod").Value         // Server Mods
                    });
                // List the XML Elemets to the ListView
                lvServerBrowser.Items.Add(item);
            }
            btnRefresh.Text = "Refresh";
        }

        // ListView SelectedIndex
        private void lvServerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sHost = string.Empty;
            string sPort = string.Empty;
            string sMap = string.Empty;
            string sMName = string.Empty;
            string sMType = string.Empty;
            string sName = string.Empty;
            string sStatus = string.Empty;
            string sCUsers = string.Empty;
            string sCVersion = string.Empty;
            string sBattleye = string.Empty;
            string sMods = string.Empty;

            try
            {
                sHost = lvServerBrowser.SelectedItems[0].SubItems[8].Text;
                sPort = lvServerBrowser.SelectedItems[0].SubItems[9].Text;
                sMap = lvServerBrowser.SelectedItems[0].SubItems[4].Text;
                sMName = lvServerBrowser.SelectedItems[0].SubItems[2].Text;
                sMType = lvServerBrowser.SelectedItems[0].SubItems[3].Text;
                sName = lvServerBrowser.SelectedItems[0].SubItems[1].Text;
                sStatus = lvServerBrowser.SelectedItems[0].SubItems[7].Text;
                sCUsers = lvServerBrowser.SelectedItems[0].SubItems[5].Text;
                sCVersion = lvServerBrowser.SelectedItems[0].SubItems[6].Text;
                sBattleye = lvServerBrowser.SelectedItems[0].SubItems[10].Text;
                sMods = lvServerBrowser.SelectedItems[0].SubItems[11].Text;
                //lblDebug.Text = sHost + " " + sPort;
                txtServerAddressHI.Text = sHost;
                txtServerPortHI.Text = sPort;
                txtBattlEye.Text = sBattleye;
                //txtCurrentVersion.Text = sCVersion;
                //txtCurrentPlayers.Text = sCUsers;
                txtServerName.Text = sName;
                //txtServerStatus.Text = sStatus;
                txtMissionType.Text = sMType;
                txtMissionName.Text = sMName;
                txtMissionMap.Text = sMap;
                txtServerName.Text = sName;
                rtxtServerMods.Text = sMods;

                if (bool.Parse(lvServerBrowser.SelectedItems[0].SubItems[0].Text) != false)
                {
                    grpServerPassword.Enabled = true;
                    txtServerPassword.Focus();
                }
                else
                {
                    grpServerPassword.Enabled = false;
                }
            }
            catch(Exception)
            {
                // Error Message
            }
        }

        // Join Button
        private void btnJoin_Click(object sender, EventArgs e)
        {
            //ListViewItem lvi = new ListViewItem("");
            string sHost = "";
            string sPort = "";
            string sPassword = string.Empty;
            string steamPass = "";
            string steamLinfo = "steam://rungameid/107410//";
            string steamConnect = "";
            string steamPort = "";
            string gameLaunch = string.Empty;
            string gamepLaunch = string.Empty;
            string gamemLaunch = string.Empty;
            string selectedMods = string.Empty;
            string selectedPara = string.Empty;
            string gLaunch = string.Empty;

            sHost = lvServerBrowser.SelectedItems[0].SubItems[8].Text;
            sPort = lvServerBrowser.SelectedItems[0].SubItems[9].Text;
            sPassword = txtServerPassword.Text;

            lblDebug.Text = sHost + " " + sPort;

            steamConnect = "-connect=" + sHost;
            steamPort = "%20-port=" + sPort;
            steamPass = "%20-password=" + sPassword;

            if (bool.Parse(lvServerBrowser.SelectedItems[0].SubItems[0].Text) != false)
            {
                gameLaunch = steamLinfo + steamConnect + steamPort + steamPass;
            }
            else
            {
                gameLaunch = steamLinfo + steamConnect + steamPort;
            }

                // Check Box List if not Null then selectedMods
                if (clbMods.CheckedItems != null)
                {
                    // For each mod selected
                    foreach (string s in clbMods.CheckedItems)
                    {
                        selectedMods += "" + s + ";";
                        gamemLaunch = "%20-mod=" + selectedMods;
                    }
                }

                if (clbParameters.CheckedItems != null)
                {
                    foreach (string x in clbParameters.CheckedItems)
                    {
                        selectedPara += "%20" + x;
                        gamepLaunch = "%20" + selectedPara;
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
                        gLaunch = gameLaunch + gamepLaunch;
                        // Launch game with Parmaters
                        Process.Start(gLaunch);
                    }
                    else
                    {
                        gLaunch = gameLaunch;
                        // Start Game
                        Process.Start(gLaunch);
                    }
                }

                // If With Mod Radio Button is Checked
                else if (rdoModsEnabled.Checked)
                {
                    if (chkParaEnabled.Checked != false)
                    {
                        // Start Game With Mods
                        gLaunch = gameLaunch + gamepLaunch + gamemLaunch;
                        Process.Start(gLaunch);
                    }
                    else
                    {
                        gLaunch = gameLaunch + gamemLaunch;
                        Process.Start(gLaunch);
                    }
                }
        }

        private void lvServerBrowser_DrawSubItem(Object sender, DrawListViewSubItemEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Image imgLock = Properties.Resources.theLock;
                Image imgUnlock = Properties.Resources.theUnlock;

                if (lvServerBrowser.Items[e.ItemIndex].SubItems[e.ColumnIndex].Text.Equals("true"))
                {
                    e.Graphics.DrawImage(imgLock, lvServerBrowser.Items[e.ItemIndex].SubItems[e.ColumnIndex].Bounds.Location);
                }
                else
                {
                    e.Graphics.DrawImage(imgUnlock, lvServerBrowser.Items[e.ItemIndex].SubItems[e.ColumnIndex].Bounds.Location);
                }
                e.DrawFocusRectangle(lvServerBrowser.Items[e.ItemIndex].SubItems[e.ColumnIndex].Bounds);
            }
            else
            {
                e.DrawText();
            }
        }

        private void lvServerBrowser_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawText();
        }

        // Fliter Textbox Name
        private void txtNameFilter_TextChanged(object sender, System.EventArgs e)
        {
        }
        // Button Finder
        private void btnNameFilter_Click(object sender, EventArgs e)
        {
            lvServerBrowser.Groups.Clear();
            lvServerBrowser.Groups.Add(new ListViewGroup(txtNameFilter.Text, HorizontalAlignment.Left));
            lvServerBrowser.Groups.Add(new ListViewGroup("Servers", HorizontalAlignment.Left));
            // Gets XML Document from URL
            //lvServerBrowser.Items.Clear();
            //IEnumerable<XElement> serverElements = doc.Descendants("server");
            //foreach (XElement serverElement in serverElements)
            //{
            //    ListViewItem item = new ListViewItem(new string[]
            //        {
            //            serverElement.Element("passworded").Value.ToString(),
            //            serverElement.Element("name").Value.ToString(),
            //            serverElement.Element("mission").Value.ToString(),
            //            serverElement.Element("mode").Value.ToString(),
            //            serverElement.Element("island").Value.ToString(),
            //            serverElement.Element("players").Value.ToString(),
            //            serverElement.Element("version").Value.ToString(),
            //            serverElement.Element("state").Value.ToString(),
            //            serverElement.Element("host").Value.ToString(),
            //            serverElement.Element("port").Value.ToString()
            //        });
            //    if (serverElement.Element("name").Value.ToString().Contains(txtNameFilter.Text) || string.IsNullOrEmpty(txtNameFilter.Text))
            //    {
            //        lvServerBrowser.Items.Add(item);
            //    }
            foreach (ListViewItem item in lvServerBrowser.Items)
            {
                string subItemText = txtNameFilter.Text;
                if (item.SubItems[1].Text.Contains(txtNameFilter.Text))
                {
                    item.Group = lvServerBrowser.Groups[0];
                }
                else
                {
                    item.Group = lvServerBrowser.Groups[1];
                }
            }
            
        }

        // Remote - CheckBox Password Click Event
        private void chksPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chksPassword.Checked != false)
            {
                grpRemotePass.Enabled = true;
            }
            else
            {
                grpRemotePass.Enabled = false;
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  if (tabControl1.TabPages[0])
          //  {

          //  }
           // if (tabPage1)
           // {

            //}
        }

        // Remote - Join Button
        private void btnRemoteJoin_Click(object sender, EventArgs e)
        {
            string sHost = string.Empty;
            string sPort = string.Empty;
            string sPassword = string.Empty;
            string steamPass = "";
            string steamLinfo = "steam://rungameid/107410//";
            string steamConnect = "";
            string steamPort = "";
            string gameLaunch = string.Empty;
            string gamepLaunch = string.Empty;
            string gamemLaunch = string.Empty;
            string selectedMods = string.Empty;
            string selectedPara = string.Empty;
            string gLaunch = string.Empty;

            sHost = txtRemoteHost.Text;
            sPort = txtRemotePort.Text;
            sPassword = txtRemotePassword.Text;

            lblDebug.Text = sHost + " " + sPort;

            steamConnect = "-connect=" + sHost;
            steamPort = "%20-port=" + sPort;
            steamPass = "%20-password=" + sPassword;

            if (chksPassword.Checked != false)
            {
                //grpRemotePass.Enabled = true;
                gameLaunch = steamLinfo + steamConnect + steamPort + steamPass;
            }
            else
            {
                //grpRemotePass.Enabled = false;
                gameLaunch = steamLinfo + steamConnect + steamPort;
            }

            // Check Box List if not Null then selectedMods
            if (clbMods.CheckedItems != null)
            {
                // For each mod selected
                foreach (string s in clbMods.CheckedItems)
                {
                    selectedMods += "" + s + ";";
                    gamemLaunch = "%20-mod=" + selectedMods;
                }
            }

            if (clbParameters.CheckedItems != null)
            {
                foreach (string x in clbParameters.CheckedItems)
                {
                    selectedPara += "%20" + x;
                    gamepLaunch = "%20" + selectedPara;
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
                    gLaunch = gameLaunch + gamepLaunch;
                    // Launch game with Parmaters
                    Process.Start(gLaunch);
                }
                else
                {
                    gLaunch = gameLaunch;
                    // Start Game
                    Process.Start(gLaunch);
                }
            }

            // If With Mod Radio Button is Checked
            else if (rdoModsEnabled.Checked)
            {
                if (chkParaEnabled.Checked != false)
                {
                    // Start Game With Mods
                    gLaunch = gameLaunch + gamepLaunch + gamemLaunch;
                    Process.Start(gLaunch);
                }
                else
                {
                    gLaunch = gameLaunch + gamemLaunch;
                    Process.Start(gLaunch);
                }
            }
        }

        // Remote - Selected Server Selection
        private void cmbServerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
           // if (cmbServerSelect.SelectedItem(""))
            if (cmbServerSelect.SelectedIndex == -1)
            {
                txtRemoteHost.Text = string.Empty;
                txtRemotePort.Text = string.Empty;
                txtRemotePassword.Text = string.Empty;
                chksPassword.Checked = false;
            }
            else if (cmbServerSelect.SelectedIndex == 0)
            {
                txtRemoteHost.Text = string.Empty;
                txtRemotePort.Text = string.Empty;
                txtRemotePassword.Text = string.Empty;
                chksPassword.Checked = false;
            }
            else if (cmbServerSelect.SelectedIndex == 1) // Pub Server
            {
                txtRemoteHost.Text = "server.natotaskforce.com";
                txtRemotePort.Text = "2322";
                chksPassword.Checked = false;
            }
            else if (cmbServerSelect.SelectedIndex == 2) // Tradoc
            {
                txtRemoteHost.Text = "server.natotaskforce.com";
                txtRemotePort.Text = "2312";
                chksPassword.Checked = true;
                txtRemotePassword.Text = "NATOTF";
            }
            else if (cmbServerSelect.SelectedIndex == 3) // Dynamic
            {
                txtRemoteHost.Text = "server.natotaskforce.com";
                txtRemotePort.Text = "2302";
                chksPassword.Checked = true;
                txtRemotePassword.Text = "NATOTF";
            }
            else if (cmbServerSelect.SelectedIndex == 4) // Test
            {
                txtRemoteHost.Text = "server.natotaskforce.com";
                txtRemotePort.Text = "2332";
                chksPassword.Checked = true;
                txtRemotePassword.Text = "NATOTF";
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
            // Now Close The Form
            this.Close();
        }

        // Close Button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}

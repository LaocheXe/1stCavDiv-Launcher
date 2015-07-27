using SharpCompress;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Ionic.Zip;

namespace _1stCav_Updator
{
    public partial class Main : Form
    {
        Stopwatch sw1 = new Stopwatch();

        public Main()
        {
            InitializeComponent();

            // Disable Buttons
            btnFinish.Enabled = false;
            btnStop.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string arma3Path = Properties.Settings.Default["ArmaPath"].ToString();
            // Make sure they add arma path and saved
            if (arma3Path != null)
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
            else
            {
                // Do Nothing
            }

            // Debug Label
            string armaPath;

            // If arma3Path is not null
            if (arma3Path != null)
            {
                armaPath = arma3Path.Substring(0, arma3Path.Length - "arma3.exe".Length);
                lblArmaPath.Text = armaPath;
            }
            else
            {
                MessageBox.Show("Wait, This should be fixed.", "Error: 101", MessageBoxButtons.OK, MessageBoxIcon.Error);
                armaPath = " "; // Added for 'Use of unassigned local variable'
            }

        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            AppSettings shoOptions = new AppSettings();
            shoOptions.ShowDialog();
        }

        //Delete File
        static bool deleteFile(string f)
        {
            try
            {
                File.Delete(f);
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblDownload.Text = "Download Mod Pack/Updates";
        }

        private void backgroundWorker1_RunWorkerComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            btnFinish.Enabled = true;
            lblDownload.Text = "Mod Pack Downloaded and Up to date";
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            // Call Background Worker1 to Download
            //backgroundWorker1.RunWorkerAsync();

            if (backgroundWorker1.IsBusy)
            {
                btnStop.Enabled = false;
                btnDownload.Enabled = true;
            }
            else
            {
                backgroundWorker1.RunWorkerAsync();
                btnDownload.Enabled = false;
                btnStop.Enabled = true;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Download Progress with background Worker
            // backgroundWorker1.RunWorkerAsync();

            // Define Server IP/url
            string Server = "http://modpacks.1stcavdiv.us/";
            string arma3Path = Properties.Settings.Default["ArmaPath"].ToString();
            string armaPath = arma3Path.Substring(0, arma3Path.Length - "arma3.exe".Length);
            string lclVersion;

            if (armaPath == "")
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
            else
            {
                // Do Nothing
            }

            BackgroundWorker worker = sender as BackgroundWorker;
            while (true)
            {
                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    FileStream fs = null;
                    if (!File.Exists(armaPath + "version"))
                    {
                        using (fs = File.Create(armaPath + "version"))
                        {
                            // Blank Area - Do Nothing
                        }

                        // Create version
                        using (StreamWriter sw = new StreamWriter("version"))
                        {
                            sw.Write("0.0");
                        }
                    }

                    // Read Version
                    using (StreamReader reader = new StreamReader("version"))
                    {
                        lclVersion = reader.ReadLine();
                    }

                    decimal localVersion = decimal.Parse(lclVersion);

                    // Starting the Download/Update Process - Getting List
                    XDocument serverXML = XDocument.Load(@Server + "Updates.xml");

                    // Starting the Download/Update Process - Start
                    foreach (XElement update in serverXML.Descendants("update"))
                    {
                        string version = update.Element("version").Value;
                        string file = update.Element("file").Value;
                        decimal serverVersion = decimal.Parse(version);
                        string serverUrlToReadFileFrom = Server + file;
                        string serverFilePathToWriteTo = armaPath + file;

                        if (serverVersion > localVersion)
                        {
                            Uri url = new Uri(serverUrlToReadFileFrom);
                            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
                            System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
                            response.Close();


                            //Int64 iSize = response.ContentLength;

                            Int64 iSize = 2000;

                            Int64 iRunningByteTotal = 0;

                            using (System.Net.WebClient client = new System.Net.WebClient())
                            {
                                using (System.IO.Stream streamRemote = client.OpenRead(new Uri(serverUrlToReadFileFrom)))
                                {
                                    // using (Stream streamLocal = new FileStream(serverUrlToReadFileFrom, FileMode.Create, FileAccess.Write, FileShare.None))
                                    using (Stream streamLocal = new FileStream(serverFilePathToWriteTo, FileMode.Create, FileAccess.Write, FileShare.None))
                                    {
                                        int iByteSize = 0;
                                        byte[] byteBuffer = new byte[iSize];
                                        while ((iByteSize = streamRemote.Read(byteBuffer, 0, byteBuffer.Length)) > 0)
                                        {
                                            streamLocal.Write(byteBuffer, 0, iByteSize);
                                            iRunningByteTotal += iByteSize;

                                            double dIndex = (double)(iRunningByteTotal);
                                            double dTotal = (double)byteBuffer.Length;
                                            double dProgressPercentage = (dIndex / dTotal);
                                            int iProgressPercentage = (int)(dProgressPercentage * 100);

                                           // progressBar1.Maximum = byteBuffer.Length;

                                            //lblSpeed.Text = string.Format("Speed: {0} kb/s", (iRunningByteTotal / 1024d / sw1.Elapsed.TotalSeconds).ToString("0.00"));
                                           // lblPresent.Text = dProgressPercentage.ToString() + "%";
                                           // lblDownloadTotal.Text = string.Format("Download: {0} MB's / {1} MB's", (iRunningByteTotal / 1024d / 1024d).ToString("0.00"), (iByteSize / 1024d / 1024d).ToString("0.00"));
                                            backgroundWorker1.ReportProgress(iProgressPercentage);

                                            int precent = (int)(((double)progressBar1.Value / (double)progressBar1.Maximum) * 100);
                                           // lblPresent.Text = precent.ToString() + "%";
                                            progressBar1.CreateGraphics().DrawString(precent.ToString() + "%", new Font("Arial", (float)8.25, FontStyle.Regular), Brushes.Black, new PointF(progressBar1.Width / 2 - 10, progressBar1.Height / 2 - 7));
                                            
                                        }

                                        streamLocal.Close();
                                    }

                                    streamRemote.Close();
                                }
                            }
                        }

                        // Start Unzipping
                        using (ZipFile zip = ZipFile.Read(armaPath + file))
                        //rar
                        {
                            foreach (ZipEntry zipFiles in zip)
                            {
                                //zipFiles.ExtractAll(arma3Path + "\\@1stCav\\", true);
                                //zipFiles.Extract(armaPath); // File Already Exsists
                                zipFiles.Extract(armaPath, ExtractExistingFileAction.OverwriteSilently);
                            }

                        }


                        WebClient webClient = new WebClient();
                        webClient.DownloadFile(Server + "version.txt", @armaPath + "version");


                        // Delete Zip File
                        //  deleteFile(file); // Disable due to not wanting to delete file
                    }
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();
                btnDownload.Enabled = true;
                btnStop.Enabled = false;
            }
            else
            {
                btnStop.Enabled = false;
            }
        }

        private void btnDownloadBMod_Click(object sender, EventArgs e)
        {

        }
    }
}

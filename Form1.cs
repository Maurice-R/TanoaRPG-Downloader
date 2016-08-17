using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        Stopwatch sw = new Stopwatch();

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }    

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (File.Exists(downloadlocation))
            {

                labelSV.Text = "      Deine Version ist aktuell";
                button_1.Visible = false;

            }
            else
            {

                labelSV.Text = "Deine Version ist NICHT aktuell";
                button_1.Visible = true;

            }

            this.Text = "TanoaRPG Downloader";
            this.BackColor = Color.White;
            this.Location = new Point(300, 300);
            this.MaximizeBox = false;
            progressBar1.Visible = false;
            labelSpeed.Visible = false;
            labelDLServer.Visible = false;
            labelNVersion.Text = "Aktuellste Version: " + getnewestversion();
            labelDF.Visible = false;
            labelDLT.Visible = false;
            labelCL.Visible = true;
            labelCL.Text = "Changelog";

        }

        private bool IsRunning(Process process)
        {
            if (process == null)
                throw new ArgumentNullException("process");

            try
            {
                Process.GetProcessById(process.Id);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }

        string url = "";

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int srv = rnd.Next(1, 11);

            if (srv == 1) { url = "https://cdn.cat24max.de/tanoarpg/files/"; labelDLServer.Text = "Aktuell verwendeter Download-Server: 2"; }
            if (srv == 2) { url = "http://89.163.144.28/MissionPreload/"; labelDLServer.Text = "Aktuell verwendeter Download-Server: 1"; }
            if (srv == 3) { url = "http://89.163.144.28/MissionPreload/"; labelDLServer.Text = "Aktuell verwendeter Download-Server: 1"; }
            if (srv == 4) { url = "http://89.163.144.28/MissionPreload//"; labelDLServer.Text = "Aktuell verwendeter Download-Server: 1"; }
            if (srv == 5) { url = "http://89.163.144.28/MissionPreload/"; labelDLServer.Text = "Aktuell verwendeter Download-Server: 1"; }
            if (srv == 6) { url = "http://89.163.144.28/MissionPreload/"; labelDLServer.Text = "Aktuell verwendeter Download-Server: 1"; }
            if (srv == 7) { url = "https://cdn.cat24max.de/tanoarpg/files/"; labelDLServer.Text = "Aktuell verwendeter Download-Server: 2"; }
            if (srv == 8) { url = "http://89.163.144.28/MissionPreload/"; labelDLServer.Text = "Aktuell verwendeter Download-Server: 1"; }
            if (srv == 9) { url = "http://89.163.144.28/MissionPreload/"; labelDLServer.Text = "Aktuell verwendeter Download-Server: 1"; }
            if (srv == 10) { url = "http://89.163.144.28/MissionPreload/"; labelDLServer.Text = "Aktuell verwendeter Download-Server: 1"; }

            Thread download = new Thread(() =>
            {
                startDownload();
            });
            download.Start();
            button_1.Visible = false;
            progressBar1.Visible = true;
            labelSpeed.Visible = true;
            labelDLServer.Visible = true;
            labelDLT.Visible = true;

        }

        private void startDownload()
        {

            Thread thread = new Thread(() =>
            {

                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri(url + getcontent2()), downloadlocation);
                sw.Start();
            });
            thread.Start();

        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
                labelSpeed.Text = string.Format("{0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));
                labelDLT.Text = string.Format("{0} Sekunden verbleibend", Math.Round(((e.TotalBytesToReceive / 1024) - (e.BytesReceived / 1024d)) / (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds)));

            });
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                labelSpeed.Visible = false;
                sw.Reset();
                labelSV.Text = "      Deine Version ist aktuell";
                labelDF.Visible = true;
                labelDF.Text = "Download abgeschlossen";
                progressBar1.Visible = false;
                labelDLServer.Visible = false;
                labelDLT.Visible = false;
            });
        }

        public static string downloadlocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\..\\Local\\Arma 3\\MPMissionsCache\\" + getcontent2();

        public static string getcontent2() => new StreamReader(new WebClient().OpenRead("https://cdn.cat24max.de/tanoarpg/currentVersionFile.txt")).ReadToEnd();

        public static string getnewestversion() => new StreamReader(new WebClient().OpenRead("https://cdn.cat24max.de/tanoarpg/currentVersionString.txt")).ReadToEnd();

        private void labelCL_Click(object sender, EventArgs e) => Process.Start(new StreamReader(new WebClient().OpenRead("https://cdn.cat24max.de/tanoarpg/currentVersionChangelog.txt")).ReadToEnd());

    }

}

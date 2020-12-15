using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace FilesProject
{
    public partial class Download : Form
    {
        string filePath;
        string specFile;
        public Download(String fileP,string specF)
        {
            InitializeComponent();
            filePath = fileP;
            specFile = specF;
            
        }

        private void Download_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri(filePath), @specFile);

        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed!"); 
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Maximum = (int)e.TotalBytesToReceive / 100;
            progressBar1.Value = (int)e.BytesReceived / 100;
        }
    }
}

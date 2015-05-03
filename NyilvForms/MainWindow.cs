using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Http;
using NyilvForms.Entities;
using System.Net;
using System.Data.Entity;

namespace NyilvForms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            //GetAllClients();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            var a = new {Cegnev = "Y"};
            using (var client = new HttpClient())
            {
                var resp = client.PutAsJsonAsync("http://localhost:5112/api/Alapadatok/find", a).Result;
                resp.EnsureSuccessStatusCode();

                var adat = resp.Content.ReadAsAsync<Alapadatok>().Result;
                alapadatokBindingSource.Add(adat as Alapadatok);
            }
        }

        private void importalasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdImport.ShowDialog();
        }
        private void ofdImport_FileOk(object sender, CancelEventArgs e)
        {
            using (var client = new WebClient())
            {
                string s = ofdImport.FileName;
                client.UploadFileAsync(new Uri("http://localhost:5112/api/import"), ofdImport.FileName.ToString());

               /* resp.EnsureSuccessStatusCode();

                var adat = resp.Content.ReadAsAsync<Alapadatok>().Result;
                alapadatokBindingSource.Add(adat as Alapadatok);*/
            }
        }
        private void GetAllClients()
        {
            var a = new { Cegnev = "Y" };
            using (var client = new HttpClient())
            {
                var resp = client.GetAsync("http://localhost:5112/api/Alapadatok/all").Result;
                resp.EnsureSuccessStatusCode();

                var adat = resp.Content.ReadAsAsync<DbSet<Alapadatok>>().Result;

                foreach (var ceg in adat)
                {
                    var newNode = new TreeNode(ceg.Cegnev){Tag = ceg.CegID};
                    //newNode.Nodes.Add("");
                    treeViewCeg.Nodes.Add(newNode);
                }
            }
 
        }
    }
}

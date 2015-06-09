using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NyilvForms.Auth;
using NyilvLib;
using System.Net.Http;

namespace NyilvForms
{
    public partial class Login : Form
    {
        string encryptedPassword;
        string userName;
        string text;
        HttpClient client;
        public string Username { get { return userName; } }
        public string EncryptedPassword { get { return encryptedPassword; } }
        public HttpClient Client { get { return client; } }
        public Login(string text)
        {
            InitializeComponent();

            this.text = text;
            labelText.Text = text;

            StartPosition = FormStartPosition.CenterParent;

            progressBar.Visible = false;
            progressBar.Maximum = 10;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            labelText.Text = "Autentikáció...";
            progressBar.Visible = true;
            progressBar.Value = 2;
            userName = textBoxUsername.Text;
            encryptedPassword = Encryption.Encrypt(textBoxPassword.Text);
            progressBar.Value = 5;
            UserData data = new UserData(userName, encryptedPassword);
            client = new HttpClient();
            progressBar.Value = 7;
            var resp = client.PostAsJsonAsync(ControllerFormats.Authenticate.ControllerUrl, data).Result;
            progressBar.Value = 10;
            labelText.Text = text;
            progressBar.Visible = false;
            if (resp.StatusCode == System.Net.HttpStatusCode.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Érvénytelen felhasználónév/jelszó kombináció!");
            }       

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonOK_Click(sender, (EventArgs)e);
            }
        }
    }
}

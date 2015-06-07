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
        HttpClient client;
        public string Username { get { return userName; } }
        public string EncryptedPassword { get { return encryptedPassword; } }
        public HttpClient Client { get { return client; } }
        public Login(string text)
        {
            InitializeComponent();

            labelText.Text = text;

            StartPosition = FormStartPosition.CenterParent;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            userName = textBoxUsername.Text;
            encryptedPassword = Encryption.Encrypt(textBoxPassword.Text);

            UserData data = new UserData(userName, encryptedPassword);
            client = new HttpClient();
            var resp = client.PostAsJsonAsync(ControllerFormats.Authenticate.ControllerUrl, data).Result;
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
    }
}

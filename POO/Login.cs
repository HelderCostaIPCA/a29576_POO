using System;
using System.Windows.Forms;
using POO.Controllers;
using POO.Users;

namespace POO
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Tbx_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginApp();
            }
        }
        private void LoginApp()
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            if (LoginController.Authenticate(username, password, out User user))
            {
                if (user == null) 
                {
                    OpenMainForm();
                }
                else
                {
                    MessageBox.Show($"Bem-vindo {user.Username}!");
                    OpenMainForm();
                }
            }
            else
            {
                MessageBox.Show("Utilizador ou senha incorretos!");
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            LoginApp();
        }

        private void OpenMainForm()
        {
            Main mainForm = new Main();
            mainForm.Show();
            this.Hide();  
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_EditOccurrence formEditOccurrence = new Form_EditOccurrence();
            var result = formEditOccurrence.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

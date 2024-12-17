using System;
using System.Windows.Forms;
using POO_User;

namespace POO
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txt_username.Text;
                string password = txt_password.Text;

                // Caso especial para o admin
                if (username == "admin" && password == "admin")
                {
                    MessageBox.Show("Login de administrador bem-sucedido!");
                    OpenMainForm();
                    return;
                }

                // Autentica o usuário no banco de dados
                User user = User.AuthenticateUser(username, password);

                if (user != null)
                {
                    user.UpdateLastLogin(); // Atualiza o último login
                    MessageBox.Show($"Bem-vindo {user.Username}!");

                    OpenMainForm(); // Abre o formulário principal
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar login: " + ex.Message);
            }
        }

        private void OpenMainForm()
        {
            Main mainForm = new Main();
            mainForm.Show();
            this.Hide(); // Fecha o formulário de login
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

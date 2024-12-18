using POO.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class Form_EditUser : Form
    {
        public int? UserId { get; set; }

        public Form_EditUser(int? userId = null)
        {
            InitializeComponent();
            UserId = userId;
        }

        private void Form_EditUser_Load(object sender, EventArgs e)
        {
            if (UserId.HasValue)
            {
                LoadUserData(UserId.Value);
            }
        }

        private void LoadUserData(int id)
        {
            try
            {
                User user = User.ReadById(id);

                txt_id.Text = user.Id.ToString();
                txt_username.Text = user.Username;
                txt_password.Text = user.Password;
                txt_mail.Text = user.Mail;
                cbx_Enable.Checked = user.Enable; // Supondo que temos um campo para indicar se o usuário está ativo
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados do usuário: " + ex.Message);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (!UserId.HasValue)
                {
                    User newUser = new User(
                    0,           // ID do usuário
                    txt_username.Text,                // Nome de usuário
                    txt_password.Text,                // Senha
                    txt_mail.Text,                    // E-mail
                    null,                             // Último login (null se não for usado)
                    cbx_Enable.Checked                // Ativo
                    );

                    newUser.CreateUser();  // Criar novo usuário
                    MessageBox.Show("Usuário adicionado com sucesso!");
                }
                else
                {
                    User existingUser = new User(
                    int.Parse(txt_id.Text),           // ID do usuário
                    txt_username.Text,                // Nome de usuário
                    txt_password.Text,                // Senha
                    txt_mail.Text,                    // E-mail
                    null,                             // Último login (null se não for usado)
                    cbx_Enable.Checked                // Ativo
                    );
                    existingUser.UpdateUser();  // Atualizar o usuário existente
                    MessageBox.Show("Usuário atualizado com sucesso!");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados do usuário: " + ex.Message);
            }
        }
    }
}

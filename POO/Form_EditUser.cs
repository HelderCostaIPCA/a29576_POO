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
                cbx_Enable.Checked = user.Enable; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados do utilizador: " + ex.Message);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (!UserId.HasValue)
                {
                    User newUser = new User(
                    0,         
                    txt_username.Text,            
                    txt_password.Text,           
                    txt_mail.Text,                  
                    null,                          
                    cbx_Enable.Checked             
                    );

                    newUser.CreateUser();
                    MessageBox.Show("Utilizador adicionado com sucesso!");
                }
                else
                {
                    User existingUser = new User(
                    int.Parse(txt_id.Text),          
                    txt_username.Text,              
                    txt_password.Text,              
                    txt_mail.Text,                  
                    null,                           
                    cbx_Enable.Checked           
                    );
                    existingUser.UpdateUser(); 
                    MessageBox.Show("Utilizador atualizado com sucesso!");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar os dados do utilizador: " + ex.Message);
            }
        }
    }
}

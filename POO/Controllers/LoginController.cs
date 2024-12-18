using System;
using POO.Users;
using System.Windows.Forms;

namespace POO.Controllers
{
    public static class LoginController
    {
        public static bool Authenticate(string username, string password, out User user)
        {
            try
            {
                // Caso especial para o login de administrador
                if (username == "admin" && password == "admin")
                {
                    MessageBox.Show("Login de administrador bem-sucedido!");
                    user = null;
                    return true;
                }

                // Autenticar no banco de dados
                user = User.AuthenticateUser(username, password);

                if (user != null)
                {
                    user.UpdateLastLogin();  // Atualizar último login
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar login: " + ex.Message);
                user = null;
                return false;
            }
        }
    }
}

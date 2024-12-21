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
              if (username == "admin" && password == "admin")
                {
                    MessageBox.Show("Login de administrador bem-sucedido!");
                    user = null;
                    return true;
                }

              user = User.AuthenticateUser(username, password);

                if (user != null)
                {
                    user.UpdateLastLogin();  
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

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using POO.Users;
public class UsersController : BaseController
{
    public static void LoadUsers(DataGridView grid)
    {
        try
        {
            List<User> lista = User.GetAllUsers();
            grid.DataSource = null;
            grid.DataSource = lista;

            ConfigureDataGridView(grid, "LastLogin");

            if (grid.Columns["Enable"] != null)
                grid.Columns["Enable"].HeaderText = "Ativo";

            if (grid.Columns["Password"] != null)
                grid.Columns["Password"].Visible = false;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao carregar os utilizadores: " + ex.Message);
        }
    }
}

using POO.Resources;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class FiremenController : BaseController
{
    public static void LoadFiremen(DataGridView grid)
    {
        try
        {
            List<Fireman> firemenList = Fireman.ReadAllFiremen();
            grid.DataSource = null;
            grid.DataSource = firemenList;
            ConfigureDataGridView(grid, "DateOfBirth");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao carregar os bombeiros: " + ex.Message);
        }
    }
}

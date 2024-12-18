using System;
using System.Collections.Generic;
using System.Windows.Forms;
using POO.Resources;

public class ResourcesController : BaseController
{
    public static void LoadResources(DataGridView grid)
    {
        try
        {
            List<Resource> lista = Resource.ReadAll();
            grid.DataSource = null;
            grid.DataSource = lista;
            ConfigureDataGridView(grid, "DateOfBirth");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao carregar os recursos: " + ex.Message);
        }
    }
}

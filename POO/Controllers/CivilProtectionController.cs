using POO.Resources;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class CivilProtectionController : BaseController
{
    public static void LoadCivilProtections(DataGridView grid)
    {
        try
        {
            List<CivilProtection> lista = CivilProtection.ReadAllCivilProtections();
            grid.DataSource = null;
            grid.DataSource = lista;
            ConfigureDataGridView(grid, "DateOfBirth");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao carregar dados de Proteção Civil: " + ex.Message);
        }
    }
}

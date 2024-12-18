using POO.Occurrences;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class OccurrencesController : BaseController
{
    public static void LoadOccurrences(DataGridView grid)
    {
        try
        {
            List<Occurrence> occurrences = Occurrence.GetAllOccurrences();
            grid.DataSource = null;
            grid.DataSource = occurrences;
            ConfigureDataGridView(grid, "Date");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao carregar as ocorrências: " + ex.Message);
        }
    }
}

using POO.TypeOccurrences;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class TypeOccurrenceController : BaseController
{
    public static void LoadTypeOccurrences(DataGridView grid)
    {
        try
        {
            List<TypeOccurrence> lista = TypeOccurrence.ReadAll();
            grid.DataSource = null;
            grid.DataSource = lista;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao carregar os tipos de ocorrências: " + ex.Message);
        }
    }
}

using POO.TypeResources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

public class TypeResourceController : BaseController
{
    public static void LoadTypeResources(DataGridView grid)
    {
        try
        {
            List<TypeResource> lista = TypeResource.ReadAll();
            var table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Enable", typeof(bool));

            foreach (var item in lista)
            {
                table.Rows.Add(item.Id, item.Name, item.Enable);
            }

            grid.DataSource = null;
            grid.DataSource = table;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao carregar os tipos de recursos: " + ex.Message);
        }
    }
}

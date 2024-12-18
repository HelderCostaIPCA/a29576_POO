using System;
using System.Collections.Generic;
using System.Data;

public abstract class BaseController
{
    public static void ConfigureDataGridView(System.Windows.Forms.DataGridView grid, string dateColumnName = null)
    {
        if (!string.IsNullOrEmpty(dateColumnName) && grid.Columns[dateColumnName] != null)
        {
            grid.Columns[dateColumnName].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
    }
}

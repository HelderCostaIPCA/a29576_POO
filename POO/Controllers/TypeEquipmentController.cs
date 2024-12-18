using POO.TypeEquipments;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class TypeEquipmentController : BaseController
{
    public static void LoadTypeEquipments(DataGridView grid)
    {
        try
        {
            List<TypeEquipment> lista = TypeEquipment.ReadAll();
            grid.DataSource = null;
            grid.DataSource = lista;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao carregar os tipos de equipamentos: " + ex.Message);
        }
    }
}

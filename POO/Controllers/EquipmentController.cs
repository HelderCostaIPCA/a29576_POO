using POO.Equipments;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class EquipmentController : BaseController
{
    public static void LoadEquipments(DataGridView grid)
    {
        try
        {
            List<Equipment> lista = Equipment.ReadAll();
            grid.DataSource = null;
            grid.DataSource = lista;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao carregar os equipamentos: " + ex.Message);
        }
    }
}

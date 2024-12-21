using POO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class UpdateClickController
{
      public void HandleSelection(string selected, int selectedId, DataGridView dataGridView)
    {
        switch (selected)
        {
            case "ResourceSelected":
                OpenFormAndLoadData(new Form_EditResource(selectedId), () => Load_DataGridViewResource(dataGridView));
                break;

            case "TypeResourceSelected":
                OpenFormAndLoadData(new Form_EditTypeResource(selectedId), () => Load_DataGridViewTypeResource(dataGridView));
                break;

            case "OccurrenceSelected":
                OpenFormAndLoadData(new Form_EditOccurrence(selectedId), () => Load_DataGridViewResource(dataGridView));
                break;

            case "TypeOccurenceSelected":
                OpenFormAndLoadData(new Form_EditTypeOccurrence(selectedId), () => Load_DataGridViewTypeResource(dataGridView));
                break;
            case "EquipmentsSelected":
                OpenFormAndLoadData(new Form_EditEquipment(selectedId), () => Load_DataGridViewResource(dataGridView));
                break;

            case "TypeEquipmentSelected":
                OpenFormAndLoadData(new Form_EditTypeEquipment(selectedId), () => Load_DataGridViewTypeResource(dataGridView));
                break;

            case "UsersSelected":
                OpenFormAndLoadData(new Form_EditUser(selectedId), () => Load_DataGridViewUsers(dataGridView));
                break;

            default:
                MessageBox.Show("Seleção inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                break;
        }
    }

   private void OpenFormAndLoadData(Form form, Action action)
    {
        var result = form.ShowDialog();
        if (result == DialogResult.OK)
        {
            action?.Invoke();
        }
    }
    private void Load_DataGridViewResource(DataGridView dataGridView)
    {
        ResourcesController.LoadResources(dataGridView);
    }
    private void Load_DataGridViewTypeResource(DataGridView dataGridView)
    {
        TypeResourceController.LoadTypeResources(dataGridView);
    }

    private void Load_DataGridViewOccurrence(DataGridView dataGridView)
    {
        OccurrencesController.LoadOccurrences(dataGridView);
    }

    private void Load_DataGridViewUsers(DataGridView dataGridView)
    {
        UsersController.LoadUsers(dataGridView);
    }

    private void Load_DataGridViewFiremen(DataGridView dataGridView)
    {
        FiremenController.LoadFiremen(dataGridView);
    }

    private void Load_DataGridViewCivilProtections(DataGridView dataGridView)
    {
        CivilProtectionController.LoadCivilProtections(dataGridView);
    }

    private void Load_DataGridViewEquipments(DataGridView dataGridView)
    {
        EquipmentController.LoadEquipments(dataGridView);
    }

    private void Load_DataGridViewTypeEquipment(DataGridView dataGridView)
    {
        TypeEquipmentController.LoadTypeEquipments(dataGridView);
    }

    private void Load_DataGridViewTypeOccurrence(DataGridView dataGridView)
    {
        TypeOccurrenceController.LoadTypeOccurrences(dataGridView);
    }
}

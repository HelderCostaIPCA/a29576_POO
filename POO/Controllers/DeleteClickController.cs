using POO;
using POO.Occurrences;
using POO.Resources;
using POO.TypeResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class DeleteClickController
{
     public void HandleSelection(string selected,int selectedID, DataGridView dataGridView)
    {
        switch (selected)
        {
            case "ResourceSelected":
                OpenFormAndLoadData(new Form_EditResource(), () => Load_DataGridViewResource(dataGridView));
                try
                {
                    DialogResult result = MessageBox.Show("Tem a certeza que pretende eliminar este recurso?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes) 
                    {
                            DerivedResources recurso = new DerivedResources(selectedID, "", 0, DateTime.Now, "", "", "", 0);
                            recurso.Delete();
                            MessageBox.Show("Recurso eliminado com sucesso!");
                            Load_DataGridViewResource(dataGridView);
                      
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao eliminar o recurso: " + ex.Message);
                }
                break;

            case "TypeResourceSelected":
                try
                {
                    DialogResult result = MessageBox.Show("Tem a certeza que pretende eliminar este tipo de recurso?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                           DerivedTypeResources tiporecurso = new DerivedTypeResources(selectedID, "", false);
                            tiporecurso.Delete();
                            MessageBox.Show("Tipo de Recurso eliminado com sucesso!");
                            Load_DataGridViewTypeResource(dataGridView);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao eliminado o tipo recurso: " + ex.Message);
                }
                break;

            case "OccurrenceSelected":
                try
                {
                    DialogResult result = MessageBox.Show("Tem a certeza que pretende eliminar esta ocorrência?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes) 
                    {
                      
                            Occurrence.DeleteOccurrence(selectedID);
                            MessageBox.Show("Ocorrência eliminada com sucesso!");
                            Load_DataGridViewOccurrence(dataGridView); 

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao eliminar a ocorrência: " + ex.Message);
                }
        break;

            case "TypeOccurenceSelected":
              
                break;
            case "EquipmentsSelected":
               
                break;

            case "TypeEquipmentSelected":
                
                break;

            case "UsersSelected":
               
                break;

            default:
                MessageBox.Show("Operação inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

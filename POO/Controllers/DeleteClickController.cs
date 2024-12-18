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
    /// <summary>
    /// Método genérico para abrir formulários e executar ações com base na seleção.
    /// </summary>
    /// <param name="selected">A string que determina qual formulário abrir.</param>
    public void HandleSelection(string selected,int selectedID, DataGridView dataGridView)
    {
        switch (selected)
        {
            case "ResourceSelected":
                OpenFormAndLoadData(new Form_EditResource(), () => Load_DataGridViewResource(dataGridView));
                try
                {
                    DialogResult result = MessageBox.Show("Tem a certeza que pretende eliminar este recurso?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes) // Se o usuário clicar em "Sim"
                    {
                            DerivedResources recurso = new DerivedResources(selectedID, "", 0, DateTime.Now, "", "", "", 0);
                            recurso.Delete();
                            MessageBox.Show("Recurso excluído com sucesso!");
                            Load_DataGridViewResource(dataGridView);
                      
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir o recurso: " + ex.Message);
                }
                break;

            case "TypeResourceSelected":
                try
                {
                    DialogResult result = MessageBox.Show("Tem a certeza que pretende eliminar este tipo de recurso?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes) // Se o usuário clicar em "Sim"
                    {
                           DerivedTypeResources tiporecurso = new DerivedTypeResources(selectedID, "", false);
                            tiporecurso.Delete();
                            MessageBox.Show("Recurso excluído com sucesso!");
                            Load_DataGridViewTypeResource(dataGridView);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir o recurso: " + ex.Message);
                }
                break;

            case "OccurrenceSelected":
                try
                {
                    DialogResult result = MessageBox.Show("Tem a certeza que pretende eliminar esta ocorrência?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes) // Se o usuário clicar em "Sim"
                    {
                      
                            Occurrence.DeleteOccurrence(selectedID); // Chama o método estático para excluir a ocorrência
                            MessageBox.Show("Ocorrência excluída com sucesso!");
                            Load_DataGridViewOccurrence(dataGridView); // Recarrega o DataGridView após a exclusão

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir a ocorrência: " + ex.Message);
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

    /// <summary>
    /// Método genérico que abre o formulário e executa uma ação se o resultado for DialogResult.OK.
    /// </summary>
    /// <param name="form">O formulário a ser exibido.</param>
    /// <param name="action">A ação a ser executada após o formulário ser confirmado.</param>
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

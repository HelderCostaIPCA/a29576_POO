﻿using POO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class CreatclickController
{
    /// <summary>
    /// Método genérico para abrir formulários e executar ações com base na seleção.
    /// </summary>
    /// <param name="selected">A string que determina qual formulário abrir.</param>
    public void HandleSelection(string selected, DataGridView dataGridView)
    {
        switch (selected)
        {
            case "ResourceSelected":
                OpenFormAndLoadData(new Form_EditResource(),() => Load_DataGridViewResource(dataGridView));
                break;

            case "TypeResourceSelected":
                OpenFormAndLoadData(new Form_EditTypeResource(),() => Load_DataGridViewTypeResource(dataGridView));
                break;

            case "OccurrenceSelected":
                OpenFormAndLoadData(new Form_EditOccurrence(),() => Load_DataGridViewResource(dataGridView));
                break;

            case "TypeOccurenceSelected":
                OpenFormAndLoadData(new Form_EditTypeOccurrence(),() => Load_DataGridViewTypeResource(dataGridView));
                break;
            case "EquipmentsSelected":
                OpenFormAndLoadData(new Form_EditEquipment(),() => Load_DataGridViewResource(dataGridView));
                break;

            case "TypeEquipmentSelected":
                OpenFormAndLoadData(new Form_EditTypeEquipment(),() => Load_DataGridViewTypeResource(dataGridView));
                break;

            case "UsersSelected":
                OpenFormAndLoadData(new Form_EditUser(), () => Load_DataGridViewUsers(dataGridView));
                break;

            default:
                MessageBox.Show("Seleção inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

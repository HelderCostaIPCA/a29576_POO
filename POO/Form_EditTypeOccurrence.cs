using POO.TypeOccurrences;
using POO.TypeResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POO
{
    public partial class Form_EditTypeOccurrence : Form
    {
        public int? OccurrenceTypeId { get; set; } // ID opcional para edição

        public Form_EditTypeOccurrence(int? occurrenceTypeId = null)
        {
            InitializeComponent();
            OccurrenceTypeId = occurrenceTypeId; // Define o ID se estiver editando
        }

        private void Form_EditTypeOccurrence_Load(object sender, EventArgs e)
        {
            LoadTypeResource();
            if (OccurrenceTypeId.HasValue)
            {
                LoadOccurrenceTypeData(OccurrenceTypeId.Value);
            }
        }

        // Método para carregar o combobox de tipos de recurso
        private void LoadTypeResource()
        {
            try
            {
                List<TypeResource> typeResources = TypeResource.ReadAll();
                cbx_typeresource.DataSource = typeResources;
                cbx_typeresource.DisplayMember = "Name";
                cbx_typeresource.ValueMember = "Id";

                if (cbx_typeresource.Items.Count > 0)
                    cbx_typeresource.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os tipos de recursos: " + ex.Message);
            }
        }

        // Método para carregar os dados do tipo de ocorrência no formulário para edição
        private void LoadOccurrenceTypeData(int id)
        {
            try
            {
                // Aqui estamos buscando o TypeOccurrence pelo seu ID
                TypeOccurrence occurrence = TypeOccurrence.ReadById(id);

                // Preencher os campos do formulário com os dados recuperados
                txt_id.Text = occurrence.Id.ToString();
                txt_description.Text = occurrence.Description;

                // Selecionar o item correspondente no ComboBox de Tipo de Recurso
                TypeResource selectedType = TypeResource.ReadAll().FirstOrDefault(t => t.Id == occurrence.IdResourceType);
                if (selectedType != null)
                {
                    cbx_typeresource.SelectedItem = selectedType;
                }
                else
                {
                    Console.WriteLine($"Tipo de Recurso não encontrado para o ID: {occurrence.IdResourceType}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados do tipo de ocorrência: " + ex.Message);
            }
        }

        // Botão OK para salvar ou atualizar o tipo de ocorrência
        private void btx_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (!OccurrenceTypeId.HasValue) // Criar novo tipo de ocorrência
                {
                    // Criar um novo TypeOccurrence
                    TypeOccurrence occurrence = new TypeOccurrence(
                        0,
                        txt_description.Text,
                        (int)cbx_typeresource.SelectedValue // Pega o ID do tipo de recurso selecionado
                    );

                    occurrence.Create();
                    MessageBox.Show("Tipo de Ocorrência adicionado com sucesso!");
                }
                else // Atualizar um tipo de ocorrência existente
                {
                    // Atualizar o TypeOccurrence existente
                    TypeOccurrence occurrence = new TypeOccurrence(
                        int.Parse(txt_id.Text),
                        txt_description.Text,
                        (int)cbx_typeresource.SelectedValue // Pega o ID do tipo de recurso selecionado
                    );

                    occurrence.Update();
                    MessageBox.Show("Tipo de Ocorrência atualizado com sucesso!");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o tipo de ocorrência: " + ex.Message);
            }
        }
    }
}

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
        public int? OccurrenceTypeId { get; set; }

        public Form_EditTypeOccurrence(int? occurrenceTypeId = null)
        {
            InitializeComponent();
            OccurrenceTypeId = occurrenceTypeId; 
        }

        private void Form_EditTypeOccurrence_Load(object sender, EventArgs e)
        {
            LoadTypeResource();
            if (OccurrenceTypeId.HasValue)
            {
                LoadOccurrenceTypeData(OccurrenceTypeId.Value);
            }
        }

      
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

     
        private void LoadOccurrenceTypeData(int id)
        {
            try
            {
                
                TypeOccurrence occurrence = TypeOccurrence.ReadById(id);

               
                txt_id.Text = occurrence.Id.ToString();
                txt_description.Text = occurrence.Description;

              
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

       
        private void btx_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (!OccurrenceTypeId.HasValue) 
                {
                  
                    TypeOccurrence occurrence = new TypeOccurrence(
                        0,
                        txt_description.Text,
                        (int)cbx_typeresource.SelectedValue
                    );

                    occurrence.Create();
                    MessageBox.Show("Tipo de Ocorrência adicionado com sucesso!");
                }
                else 
                {
                  
                    TypeOccurrence occurrence = new TypeOccurrence(
                        int.Parse(txt_id.Text),
                        txt_description.Text,
                        (int)cbx_typeresource.SelectedValue
                    );

                    occurrence.Update();
                    MessageBox.Show("Tipo de Ocorrência atualizado com sucesso!");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar o tipo de ocorrência: " + ex.Message);
            }
        }
    }
}

using POO.TypeEquipments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POO
{
    public partial class Form_EditTypeEquipment : Form
    {
        public int? EquipmentTypeId { get; set; } // ID opcional para edição

        public Form_EditTypeEquipment(int? equipmentTypeId = null)
        {
            InitializeComponent();
            EquipmentTypeId = equipmentTypeId; // Define o ID se estiver editando
        }

        private void Form_EditTypeEquipment_Load(object sender, EventArgs e)
        {
            if (EquipmentTypeId.HasValue)
            {
                LoadEquipmentTypeData(EquipmentTypeId.Value);
            }
        }

        // Método para carregar os dados do tipo de equipamento no formulário para edição
        private void LoadEquipmentTypeData(int id)
        {
            try
            {
                // Aqui estamos buscando o TypeEquipment pelo seu ID
                TypeEquipment equipmentType = TypeEquipment.ReadById(id);

                // Preencher os campos do formulário com os dados recuperados
                txt_id.Text = equipmentType.Id.ToString();
                txt_description.Text = equipmentType.Description;
                cbx_enable.Checked = equipmentType.Enable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados do tipo de equipamento: " + ex.Message);
            }
        }

        // Botão OK para salvar ou atualizar o tipo de equipamento
        private void btx_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EquipmentTypeId.HasValue) // Criar novo tipo de equipamento
                {
                    // Criar um novo TypeEquipment
                    TypeEquipment equipmentType = new TypeEquipment(
                        0,
                        txt_description.Text,
                        cbx_enable.Checked // Se o tipo de equipamento está habilitado ou não
                    );

                    equipmentType.Create();
                    MessageBox.Show("Tipo de Equipamento adicionado com sucesso!");
                }
                else // Atualizar um tipo de equipamento existente
                {
                    // Atualizar o TypeEquipment existente
                    TypeEquipment equipmentType = new TypeEquipment(
                        int.Parse(txt_id.Text),
                        txt_description.Text,
                        cbx_enable.Checked // Se o tipo de equipamento está habilitado ou não
                    );

                    equipmentType.Update();
                    MessageBox.Show("Tipo de Equipamento atualizado com sucesso!");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o tipo de equipamento: " + ex.Message);
            }
        }
    }
}

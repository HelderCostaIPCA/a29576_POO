using POO.Equipments;
using POO.TypeEquipments;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace POO
{
    public partial class Form_EditEquipment : Form
    {
        public int? EquipmentId { get; set; }

        public Form_EditEquipment(int? equipmentId = null)
        {
            InitializeComponent();
            EquipmentId = equipmentId;
        }

        private void Form_EditEquipment_Load(object sender, EventArgs e)
        {
            if (EquipmentId.HasValue)
            {
                LoadEquipmentData(EquipmentId.Value);
            }
            LoadEquipmentTypes();
        }

        private void LoadEquipmentData(int id)
        {
            try
            {
                Equipment equipment = Equipment.ReadById(id);
                if (equipment != null)
                {
                    txt_id.Text = equipment.Id.ToString();
                    txt_description.Text = equipment.Description;
                    txt_serialNumber.Text = equipment.SerialNumber;
                    cbx_Enable.Checked = equipment.Enable;
                    // Selecionar o tipo de equipamento na ComboBox usando o ID
                    cbx_equipmentType.SelectedItem = cbx_equipmentType.Items.Cast<TypeEquipment>()
                        .FirstOrDefault(type => type.Id == equipment.EquipmentTypeId);
                    cbx_available.Checked = equipment.Available;
                }
                else
                {
                    MessageBox.Show("Equipamento não encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados do equipamento: " + ex.Message);
            }
        }

        private void LoadEquipmentTypes()
        {
            try
            {
                // Chama o método ReadAll da classe TypeEquipment para pegar todos os tipos de equipamentos do banco
                List<TypeEquipment> equipmentTypes = TypeEquipment.ReadAll();

                // Adiciona os tipos de equipamentos na ComboBox
                foreach (var type in equipmentTypes)
                {
                    cbx_equipmentType.Items.Add(type);
                }

                // Opcional: Se a ComboBox estiver vazia, adiciona um item de seleção padrão
                if (cbx_equipmentType.Items.Count > 0)
                {
                    cbx_equipmentType.SelectedIndex = 0;  // Seleciona o primeiro item por padrão
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os tipos de equipamento: " + ex.Message);
            }
        }

        private void btx_ok_Click(object sender, EventArgs e)
        {
            try
            {
                TypeEquipment selectedType = (TypeEquipment)cbx_equipmentType.SelectedItem;  // Pega o tipo selecionado
                int selectedTypeId = selectedType?.Id ?? 0; // Caso o item selecionado seja nulo, define 0 como fallback

                if (!EquipmentId.HasValue) // Criar novo equipamento
                {
                    Equipment equipment = new Equipment(
                        0,
                        txt_description.Text,
                        txt_serialNumber.Text,
                        cbx_Enable.Checked,
                        selectedTypeId,  // Usando o ID do tipo de equipamento selecionado
                        cbx_available.Checked
                    );
                    equipment.Create();
                    MessageBox.Show("Equipamento adicionado com sucesso!");
                }
                else // Atualizar equipamento existente
                {
                    Equipment equipment = new Equipment(
                        int.Parse(txt_id.Text),
                        txt_description.Text,
                        txt_serialNumber.Text,
                        cbx_Enable.Checked,
                        selectedTypeId,  // Usando o ID do tipo de equipamento selecionado
                        cbx_available.Checked
                    );
                    equipment.Update();
                    MessageBox.Show("Equipamento atualizado com sucesso!");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o equipamento: " + ex.Message);
            }
        }
    }
}

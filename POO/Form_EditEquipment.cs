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
                List<TypeEquipment> equipmentTypes = TypeEquipment.ReadAll();

                foreach (var type in equipmentTypes)
                {
                    cbx_equipmentType.Items.Add(type);
                }

                if (cbx_equipmentType.Items.Count > 0)
                {
                    cbx_equipmentType.SelectedIndex = 0; 
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
                TypeEquipment selectedType = (TypeEquipment)cbx_equipmentType.SelectedItem; 
                int selectedTypeId = selectedType?.Id ?? 0; 

                if (!EquipmentId.HasValue)
                {
                    Equipment equipment = new Equipment(
                        0,
                        txt_description.Text,
                        txt_serialNumber.Text,
                        cbx_Enable.Checked,
                        selectedTypeId, 
                        cbx_available.Checked
                    );
                    equipment.Create();
                    MessageBox.Show("Equipamento adicionado com sucesso!");
                }
                else
                {
                    Equipment equipment = new Equipment(
                        int.Parse(txt_id.Text),
                        txt_description.Text,
                        txt_serialNumber.Text,
                        cbx_Enable.Checked,
                        selectedTypeId, 
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
                MessageBox.Show("Erro ao guardar o equipamento: " + ex.Message);
            }
        }
    }
}

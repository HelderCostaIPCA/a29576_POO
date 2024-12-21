using POO.TypeEquipments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POO
{
    public partial class Form_EditTypeEquipment : Form
    {
        public int? EquipmentTypeId { get; set; }

        public Form_EditTypeEquipment(int? equipmentTypeId = null)
        {
            InitializeComponent();
            EquipmentTypeId = equipmentTypeId; 
        }

        private void Form_EditTypeEquipment_Load(object sender, EventArgs e)
        {
            if (EquipmentTypeId.HasValue)
            {
                LoadEquipmentTypeData(EquipmentTypeId.Value);
            }
        }

        private void LoadEquipmentTypeData(int id)
        {
            try
            {
                TypeEquipment equipmentType = TypeEquipment.ReadById(id);

                txt_id.Text = equipmentType.Id.ToString();
                txt_description.Text = equipmentType.Description;
                cbx_enable.Checked = equipmentType.Enable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados do tipo de equipamento: " + ex.Message);
            }
        }

        private void btx_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EquipmentTypeId.HasValue)
                {
                 
                    TypeEquipment equipmentType = new TypeEquipment(
                        0,
                        txt_description.Text,
                        cbx_enable.Checked 
                    );

                    equipmentType.Create();
                    MessageBox.Show("Tipo de Equipamento adicionado com sucesso!");
                }
                else 
                {
                    TypeEquipment equipmentType = new TypeEquipment(
                        int.Parse(txt_id.Text),
                        txt_description.Text,
                        cbx_enable.Checked 
                    );

                    equipmentType.Update();
                    MessageBox.Show("Tipo de Equipamento atualizado com sucesso!");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar o tipo de equipamento: " + ex.Message);
            }
        }
    }
}

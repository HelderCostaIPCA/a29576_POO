using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace POO
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public string selected;
        private void Load_DataGridViewResource()
        {
            ResourcesController.LoadResources(dataGridView1);
        }
        private void Load_DataGridViewTypeResource()
        {
            TypeResourceController.LoadTypeResources(dataGridView1);
        }

        private void Load_DataGridViewOccurrence()
        {
            OccurrencesController.LoadOccurrences(dataGridView1);
        }

        private void Load_DataGridViewUsers()
        {
            UsersController.LoadUsers(dataGridView1);
        }

        private void Load_DataGridViewFiremen()
        {
            FiremenController.LoadFiremen(dataGridView1);
        }

        private void Load_DataGridViewCivilProtections()
        {
            CivilProtectionController.LoadCivilProtections(dataGridView1);
        }

        private void Load_DataGridViewEquipments()
        {
            EquipmentController.LoadEquipments(dataGridView1);
        }

        private void Load_DataGridViewTypeEquipment()
        {
            TypeEquipmentController.LoadTypeEquipments(dataGridView1);
        }

        private void Load_DataGridViewTypeOccurrence()
        {
            TypeOccurrenceController.LoadTypeOccurrences(dataGridView1);
        }


        private void bt_resources_click(object sender, EventArgs e)
        {
            Load_DataGridViewResource();
            btx_resources.BorderStyle = BorderStyle.Fixed3D;
            btx_resourcecontrol.BorderStyle = BorderStyle.Fixed3D;
            btx_users.BorderStyle = BorderStyle.None;
            btx_occurrences.BorderStyle = BorderStyle.None;
            btx_cvprotection.BorderStyle = BorderStyle.None;
            btx_fireman.BorderStyle = BorderStyle.None;
            btx_typeresource.Visible = true;
            btx_resourcecontrol.Visible = true;
            btx_resourcecontrol.Image = Image.FromFile("C:\\Users\\helder costa\\OneDrive - Instituto Politécnico do Cávado e do Ave\\IPCA\\Segundo Ano 24-25\\Primeiro Semestre\\Programação Orientada a Objetos\\TrabalhoFinal\\POO\\POO\\Img\\managementresource.png");
            btx_typeresource.Image = Image.FromFile("C:\\Users\\helder costa\\OneDrive - Instituto Politécnico do Cávado e do Ave\\IPCA\\Segundo Ano 24-25\\Primeiro Semestre\\Programação Orientada a Objetos\\TrabalhoFinal\\POO\\POO\\Img\\typeresource.png");
            selected = "ResourceSelected";
            gpx_resource.Text = "Gestão Recursos";
            gpx_resource.Visible = true;

        }
        private void btx_resourcecontrol_Click(object sender, EventArgs e)
        {

            if (selected == "TypeResourceSelected")
            {
                btx_resourcecontrol.BorderStyle = BorderStyle.Fixed3D;
                btx_typeresource.BorderStyle = BorderStyle.None;
                dataGridView1.DataSource = null;
                Load_DataGridViewResource();
                selected = "ResourceSelected";
            }
            if (selected == "TypeOccurenceSelected")
            {
                btx_resourcecontrol.BorderStyle = BorderStyle.Fixed3D;
                btx_typeresource.BorderStyle = BorderStyle.None;
                dataGridView1.DataSource = null;
                Load_DataGridViewOccurrence();
                selected = "OccurrenceSelected";
            }
            if (selected == "TypeEquipmentSelected")
            {
                btx_resourcecontrol.BorderStyle = BorderStyle.Fixed3D;
                btx_typeresource.BorderStyle = BorderStyle.None;
                dataGridView1.DataSource = null;
                Load_DataGridViewEquipments();
                selected = "EquipmentsSelected";
            }
        }

        private void btx_typeresource_Click(object sender, EventArgs e)
        {
            if (selected == "ResourceSelected")
            {
                btx_typeresource.BorderStyle = BorderStyle.Fixed3D;
                btx_resourcecontrol.BorderStyle = BorderStyle.None;
                dataGridView1.DataSource = null;
                Load_DataGridViewTypeResource();
                selected = "TypeResourceSelected";
            }
            if (selected == "OccurrenceSelected")
            {
                btx_typeresource.BorderStyle = BorderStyle.Fixed3D;
                btx_resourcecontrol.BorderStyle = BorderStyle.None;
                dataGridView1.DataSource = null;
                Load_DataGridViewTypeOccurrence();
                selected = "TypeOccurenceSelected";
            }
            if (selected == "EquipmentsSelected")
            {
                btx_typeresource.BorderStyle = BorderStyle.Fixed3D;
                btx_resourcecontrol.BorderStyle = BorderStyle.None;
                dataGridView1.DataSource = null;
                Load_DataGridViewTypeEquipment();
                selected = "TypeEquipmentSelected";
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            CreatclickController controller = new CreatclickController();
            controller.HandleSelection(selected, dataGridView1);
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value) > 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                UpdateClickController controller = new UpdateClickController();
                controller.HandleSelection(selected, selectedId, dataGridView1);
            }
            else
            {
                MessageBox.Show("Selecione o registo a editar!");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value) > 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                DeleteClickController controller = new DeleteClickController();
                controller.HandleSelection(selected, selectedId, dataGridView1);
            }
            else
            {
                MessageBox.Show("Selecione o registo a eliminar!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            btx_users.BorderStyle = BorderStyle.None;
            btx_occurrences.BorderStyle = BorderStyle.None;
            btx_resources.BorderStyle = BorderStyle.None;
            btx_equipment.BorderStyle = BorderStyle.None;
            btx_fireman.BorderStyle = BorderStyle.None;
            btx_cvprotection.BorderStyle = BorderStyle.None;
            dataGridView1.DataSource = null;
            selected = "";
            gpx_resource.Visible = false;

        }

        private void btx_occurrences_Click(object sender, EventArgs e)
        {
            Load_DataGridViewOccurrence();
            btx_resources.BorderStyle = BorderStyle.None;
            btx_occurrences.BorderStyle = BorderStyle.Fixed3D;
            btx_resourcecontrol.BorderStyle = BorderStyle.Fixed3D;
            btx_typeresource.BorderStyle = BorderStyle.None;
            btx_equipment.BorderStyle = BorderStyle.None;
            btx_cvprotection.BorderStyle = BorderStyle.None;
            btx_users.BorderStyle = BorderStyle.None;
            btx_fireman.BorderStyle = BorderStyle.None;
            btx_typeresource.Visible = true;
            btx_resourcecontrol.Visible = true;
            btx_resourcecontrol.Image = Image.FromFile("C:\\Users\\helder costa\\OneDrive - Instituto Politécnico do Cávado e do Ave\\IPCA\\Segundo Ano 24-25\\Primeiro Semestre\\Programação Orientada a Objetos\\TrabalhoFinal\\POO\\POO\\Img\\occurrence.png");
            btx_typeresource.Image = Image.FromFile("C:\\Users\\helder costa\\OneDrive - Instituto Politécnico do Cávado e do Ave\\IPCA\\Segundo Ano 24-25\\Primeiro Semestre\\Programação Orientada a Objetos\\TrabalhoFinal\\POO\\POO\\Img\\typeoccurrence.png");
            selected = "OccurrenceSelected";
            gpx_resource.Text = "Gestão Ocorrências";
            gpx_resource.Visible = true;
        }

        private void btx_exit_Click(object sender, EventArgs e)
        {
            this.Hide(); 

            Login loginForm = new Login();
            if (loginForm.ShowDialog() == DialogResult.OK) 
            {
                this.Show(); 
            }
            else
            {
                Application.Exit(); 
            }
        }

        private void btx_users_Click(object sender, EventArgs e)
        {
            Load_DataGridViewUsers();
            btx_users.BorderStyle = BorderStyle.Fixed3D;
            btx_occurrences.BorderStyle = BorderStyle.None;
            btx_resources.BorderStyle = BorderStyle.None;
            btx_equipment.BorderStyle = BorderStyle.None;
            btx_fireman.BorderStyle = BorderStyle.None;
            btx_cvprotection.BorderStyle = BorderStyle.None;
            btx_typeresource.Visible = false;
            btx_resourcecontrol.Visible = false;
            selected = "UsersSelected";
            gpx_resource.Text = "Utilizadores";
            gpx_resource.Visible = true;
        }

        private void btx_fireman_Click(object sender, EventArgs e)
        {
            Load_DataGridViewFiremen();
            btx_users.BorderStyle = BorderStyle.None;
            btx_occurrences.BorderStyle = BorderStyle.None;
            btx_resources.BorderStyle = BorderStyle.None;
            btx_fireman.BorderStyle = BorderStyle.Fixed3D;
            btx_equipment.BorderStyle = BorderStyle.None;
            btx_cvprotection.BorderStyle = BorderStyle.None;
            btx_typeresource.Visible = false;
            btx_resourcecontrol.Visible = false;
            gpx_resource.Text = "Bombeiros";
            gpx_resource.Visible = true;
        }

        private void btx_cvprotection_Click(object sender, EventArgs e)
        {
            Load_DataGridViewCivilProtections();
            btx_users.BorderStyle = BorderStyle.None;
            btx_occurrences.BorderStyle = BorderStyle.None;
            btx_resources.BorderStyle = BorderStyle.None;
            btx_fireman.BorderStyle = BorderStyle.None;
            btx_equipment.BorderStyle = BorderStyle.None;
            btx_cvprotection.BorderStyle = BorderStyle.Fixed3D;
            btx_typeresource.Visible = false;
            btx_resourcecontrol.Visible = false;
            gpx_resource.Text = "Proteção Cívil";
            gpx_resource.Visible = true;

        }

        private void btx_equipment_Click(object sender, EventArgs e)
        {
            Load_DataGridViewEquipments();
            btx_equipment.BorderStyle = BorderStyle.Fixed3D;
            btx_users.BorderStyle = BorderStyle.None;
            btx_resourcecontrol.BorderStyle = BorderStyle.Fixed3D;
            btx_typeresource.BorderStyle = BorderStyle.None;
            btx_occurrences.BorderStyle = BorderStyle.None;
            btx_resources.BorderStyle = BorderStyle.None;
            btx_fireman.BorderStyle = BorderStyle.None;
            btx_cvprotection.BorderStyle = BorderStyle.None;
            btx_typeresource.Visible = true;
            btx_resourcecontrol.Visible = true;
            btx_resourcecontrol.Image = Image.FromFile("C:\\Users\\helder costa\\OneDrive - Instituto Politécnico do Cávado e do Ave\\IPCA\\Segundo Ano 24-25\\Primeiro Semestre\\Programação Orientada a Objetos\\TrabalhoFinal\\POO\\POO\\Img\\equipmentsmanagement.png");
            btx_typeresource.Image = Image.FromFile("C:\\Users\\helder costa\\OneDrive - Instituto Politécnico do Cávado e do Ave\\IPCA\\Segundo Ano 24-25\\Primeiro Semestre\\Programação Orientada a Objetos\\TrabalhoFinal\\POO\\POO\\Img\\typeequipament.png");
            selected = "EquipmentsSelected";
            gpx_resource.Text = "Equipamentos";
            gpx_resource.Visible = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}

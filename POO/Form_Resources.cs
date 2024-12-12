using System;
using System.Collections.Generic;
using System.Windows.Forms;
using POO_Resources;
using POO_TypeResource;

namespace POO
{
    public partial class Form_Resources : Form
    {
        public Form_Resources()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form_Resources_Load);
        }
        private void Form_Resources_Load(object sender, EventArgs e)
        {
        }
        private void Load_DataGridViewResource()
        {
            try
            {
                List<Resources> lista = Resources.ReadAll();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;

                if (dataGridView1.Columns["DateOfBirth"] != null)
                {
                    dataGridView1.Columns["DateOfBirth"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }
        private void LoadDataGridViewTypeResource()
        {
            try
            {
                List<TypeResource> lista = TypeResource.ReadAll();

                var table = new System.Data.DataTable();
                table.Columns.Add("Id", typeof(int));
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Enable", typeof(bool));

                foreach (var item in lista)
                {
                    table.Rows.Add(item.Id, item.Name, item.Enable);
                }

                dtg_typeresource.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            Form_Edit_Resource formEdit = new Form_Edit_Resource();
            var result = formEdit.ShowDialog();
            if (result == DialogResult.OK)
            {
                Load_DataGridViewResource();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                Form_Edit_Resource formEdit = new Form_Edit_Resource(selectedId);
                var result = formEdit.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Load_DataGridViewResource();
                }
            }
            else
            {
                MessageBox.Show("Selecione um recurso para editar.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                    DerivedResources recurso = new DerivedResources(id, "", 0, DateTime.Now, "", "", "", 0);
                    recurso.Delete();
                    MessageBox.Show("Recurso excluído com sucesso!");
                    Load_DataGridViewResource();
                }
                else
                {
                    MessageBox.Show("Selecione um recurso para excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o recurso: " + ex.Message);
            }
        }

        private void btn_managementresource_Click(object sender, EventArgs e)
        {
            Load_DataGridViewResource();
            gpx_resource.Visible = true;
            gpx_typeresource.Visible = false;
        }

        private void btn_typeresource_Click(object sender, EventArgs e)
        {
            LoadDataGridViewTypeResource();
            gpx_resource.Visible = false;
            gpx_typeresource.Visible = true;
        }

        private void btx_CreateTypeResource_Click(object sender, EventArgs e)
        {
            Form_EditTypeResource formEditType = new Form_EditTypeResource();
            var result = formEditType.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadDataGridViewTypeResource();
            }
        }
    }
}

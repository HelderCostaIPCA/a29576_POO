using System;
using System.Collections.Generic;
using System.Windows.Forms;
using POO_Occurrence;
using POO_Resources;
using POO_TypeResource;
using POO_User;

namespace POO
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public bool ResourceSelected;
        public bool TypeResourceSelected;
        public bool OccurrenceSelected;
        public bool UsersSelected;
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

                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }

        private void Load_DataGridViewOccurrence()
        {
            try
            {
                List<Occurrence> occurrences = Occurrence.GetAllOccurrences();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = occurrences;

                // Formatando a coluna de data, se necessário
                if (dataGridView1.Columns["Date"] != null)
                {
                    dataGridView1.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as ocorrências: " + ex.Message);
            }
        }

        private void Load_DataGridViewUsers()
        {
            try
            {
                // Obtem todos os usuários usando o método GetAllUsers
                List<User> users = User.GetAllUsers();

                // Configura a fonte de dados do DataGridView
                dataGridView1.DataSource = null; // Limpa o DataGridView
                dataGridView1.DataSource = users; // Seta a lista de usuários no DataGridView

                // Ajusta as colunas do DataGridView para mostrar apenas as propriedades desejadas
                dataGridView1.Columns["Password"].Visible = false; // Oculta a coluna de senhas por segurança
                dataGridView1.Columns["Id"].HeaderText = "ID";
                dataGridView1.Columns["Username"].HeaderText = "Username";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os utilizadores: " + ex.Message);
            }
        }
        private void bt_resources_click(object sender, EventArgs e)
        {
            Load_DataGridViewResource();
            btx_resources.BorderStyle = BorderStyle.Fixed3D;
            btx_resourcecontrol.BorderStyle = BorderStyle.Fixed3D;
            btx_occurrences.BorderStyle = BorderStyle.None;
            btx_typeresource.Visible = true;
            btx_resourcecontrol.Visible = true;
            ResourceSelected = true;
            TypeResourceSelected = false;
            OccurrenceSelected = false;
            gpx_resource.Text = "Gestão Recursos";
            gpx_resource.Visible = true;

        }

        private void btx_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btx_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (ResourceSelected)
            {
                Form_Edit_Resource formEdit = new Form_Edit_Resource();
                var result = formEdit.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Load_DataGridViewResource();
                }
            }
            if (TypeResourceSelected)
            {
                Form_EditTypeResource formEditType = new Form_EditTypeResource();
                var result = formEditType.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadDataGridViewTypeResource();
                }
            }
            if (OccurrenceSelected)
            {
                Form_EditOccurrence formEditOccurrence = new Form_EditOccurrence();
                var result = formEditOccurrence.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Load_DataGridViewOccurrence();
                }
            }
        }

        private void btx_resourcecontrol_Click(object sender, EventArgs e)
        {
            if (!ResourceSelected)
            {
                btx_resourcecontrol.BorderStyle = BorderStyle.Fixed3D;
                btx_typeresource.BorderStyle = BorderStyle.None;
                dataGridView1.DataSource = null;
                Load_DataGridViewResource();
                ResourceSelected = true;
                TypeResourceSelected = false;
            }
        }

        private void btx_typeresource_Click(object sender, EventArgs e)
        {
            if (!TypeResourceSelected)
            {
                btx_typeresource.BorderStyle = BorderStyle.Fixed3D;
                btx_resourcecontrol.BorderStyle = BorderStyle.None;
                dataGridView1.DataSource = null;
                LoadDataGridViewTypeResource();
                ResourceSelected = false;
                TypeResourceSelected = true;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (ResourceSelected)
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
            if (TypeResourceSelected)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                    Form_EditTypeResource formEdit = new Form_EditTypeResource(selectedId);
                    var result = formEdit.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        LoadDataGridViewTypeResource();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um recurso para editar.");
                }
            }
            if (OccurrenceSelected)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                    Form_EditOccurrence formEditOccurrence = new Form_EditOccurrence(selectedId);
                    var result = formEditOccurrence.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Load_DataGridViewOccurrence();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um recurso para editar.");
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (ResourceSelected)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Tem a certeza que pretende eliminar este recurso?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes) // Se o usuário clicar em "Sim"
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir o recurso: " + ex.Message);
                }
            }
            if (TypeResourceSelected)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Tem a certeza que pretende eliminar este tipo de recurso?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes) // Se o usuário clicar em "Sim"
                    {
                        if (dataGridView1.SelectedRows.Count > 0)
                        {
                            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                            DerivedTypeResources tiporecurso = new DerivedTypeResources(id, "", false);
                            tiporecurso.Delete();
                            MessageBox.Show("Recurso excluído com sucesso!");
                            LoadDataGridViewTypeResource();
                        }
                        else
                        {
                            MessageBox.Show("Selecione um recurso para excluir.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir o recurso: " + ex.Message);
                }
            }
            if (OccurrenceSelected)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Tem a certeza que pretende eliminar esta ocorrência?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes) // Se o usuário clicar em "Sim"
                    {
                        if (dataGridView1.SelectedRows.Count > 0) // Verifica se há uma linha selecionada
                        {
                            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value); // Obtém o ID da ocorrência selecionada
                            Occurrence.DeleteOccurrence(id); // Chama o método estático para excluir a ocorrência
                            MessageBox.Show("Ocorrência excluída com sucesso!");
                            Load_DataGridViewOccurrence(); // Recarrega o DataGridView após a exclusão
                        }
                        else
                        {
                            MessageBox.Show("Selecione uma ocorrência para excluir.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir a ocorrência: " + ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            btx_typeresource.BorderStyle = BorderStyle.None;
            btx_resourcecontrol.BorderStyle = BorderStyle.None;
            btx_resources.BorderStyle = BorderStyle.None;
            btx_occurrences.BorderStyle = BorderStyle.None;
            dataGridView1.DataSource = null;
            ResourceSelected = false;
            TypeResourceSelected = true;
            gpx_resource.Visible = false;

        }

        private void btx_occurrences_Click(object sender, EventArgs e)
        {
            Load_DataGridViewOccurrence();
            btx_occurrences.BorderStyle = BorderStyle.Fixed3D;
            btx_resources.BorderStyle = BorderStyle.None;
            btx_typeresource.Visible = false;
            btx_resourcecontrol.Visible = false;
            ResourceSelected = false;
            TypeResourceSelected = false;
            OccurrenceSelected = true;
            gpx_resource.Text = "Gestão Ocorrências";
            gpx_resource.Visible = true;
        }

        private void btx_exit_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta o Form_Main temporariamente

            Login loginForm = new Login();
            if (loginForm.ShowDialog() == DialogResult.OK) // Se o login for bem-sucedido
            {
                this.Show(); // Reabre o Form_Main
            }
            else
            {
                Application.Exit(); // Se o login for cancelado, encerra a aplicação
            }
        }

        private void btx_users_Click(object sender, EventArgs e)
        {
            Load_DataGridViewUsers();
            btx_users.BorderStyle = BorderStyle.Fixed3D;
            btx_occurrences.BorderStyle = BorderStyle.None;
            btx_resources.BorderStyle = BorderStyle.None;
            btx_typeresource.Visible = false;
            btx_resourcecontrol.Visible = false;
            ResourceSelected = false;
            TypeResourceSelected = false;
            OccurrenceSelected = false;
            UsersSelected = true;
            gpx_resource.Text = "Utilizadores";
            gpx_resource.Visible = true;
        }
    }
}

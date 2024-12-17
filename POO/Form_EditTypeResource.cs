using POO_Resources;
using POO_TypeResource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class Form_EditTypeResource : Form
    {
        public int? TypeResourceId { get; set; }

        public Form_EditTypeResource(int? typeresourceId = null)
        {
            InitializeComponent();
            TypeResourceId = typeresourceId;
        }

        private void Form_EditTypeResource_Load(object sender, EventArgs e)
        {
            if (TypeResourceId.HasValue)
            {
                LoadTypeResourceData(TypeResourceId.Value);
            }
        }

        private void LoadTypeResourceData(int id)
        {
            try
            {
                TypeResource typeresource = TypeResource.ReadById(id);

                txt_id.Text = typeresource.Id.ToString();
                txt_name.Text = typeresource.Name;
                cbx_Enable.Checked = typeresource.Enable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados do recurso: " + ex.Message);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TypeResourceId.HasValue)
                {
                    DerivedTypeResources recurso = new DerivedTypeResources(
                    0,
                        txt_name.Text,
                        cbx_Enable.Checked
                    );

                    recurso.Create();
                    MessageBox.Show("Recurso adicionado com sucesso!");
                }
                else
                {
                    DerivedTypeResources recurso = new DerivedTypeResources(
                        int.Parse(txt_id.Text),
                        txt_name.Text,
                        cbx_Enable.Checked
                    );

                    recurso.Update();
                    MessageBox.Show("Recurso atualizado com sucesso!");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar o recurso: " + ex.Message);
            }
        }

        private void btx_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btx_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

using POO_Resources;
using POO_ZipCodes;
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
using System.Xml.Linq;

namespace POO
{
    public partial class Form_Edit_Resource : Form
    {
        public int? ResourceId { get; set; } 

        public Form_Edit_Resource(int? resourceId = null)
        {
            InitializeComponent();
            ResourceId = resourceId;
        }

        private void Form_Edit_Resource_Load(object sender, EventArgs e)
        {
            LoadZipCode();
            LoadTypeResource();
            if (ResourceId.HasValue)
            {
                LoadResourceData(ResourceId.Value);
            }
        }

        private void LoadResourceData(int id)
        {
            try
            {
                Resources recurso = Resources.ReadById(id);

                // Preenche os campos de texto com os dados existentes
                txt_id.Text = recurso.Id.ToString();
                txt_name.Text = recurso.Name;
                txt_nif.Text = recurso.NIF.ToString();
                dt_dateofbirth.Value = recurso.DateOfBirth;
                txt_household.Text = recurso.Household;
                cbx_zipcode.Text = recurso.ZipCode;
                txt_city.Text = recurso.City;
                cbx_typeresource.Text = recurso.Type.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados do recurso: " + ex.Message);
            }
        }

        private void LoadZipCode()
        {
            try
            {
                List<ZipCodes> zipCodes = ZipCodes.GetZipCodes();

                cbx_zipcode.Items.Clear();

                foreach (var zip in zipCodes)
                {
                    cbx_zipcode.Items.Add(zip);
                }

                if (cbx_zipcode.Items.Count > 0)
                    cbx_zipcode.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os códigos postais: " + ex.Message);
            }
        }
        private void LoadTypeResource()
        {
            try
            {
                List<TypeResource> TypeResources = TypeResource.ReadAll();

                cbx_typeresource.Items.Clear();

                foreach (var type in TypeResources)
                {
                    cbx_zipcode.Items.Add(type);
                }

                if (cbx_typeresource.Items.Count > 0)
                    cbx_typeresource.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os códigos postais: " + ex.Message);
            }
        }

        /// <summary>
        /// </summary>
        private void cbx_zipcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_zipcode.SelectedItem != null)
            {
                ZipCodes zipSelecionado = (ZipCodes)cbx_zipcode.SelectedItem;

                 txt_city.Text = zipSelecionado.Cidade;
            }
        }


        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ResourceId.HasValue)
                {
                    DerivedResources recurso = new DerivedResources(
                    0, 
                        txt_name.Text,
                        int.Parse(txt_nif.Text),
                        dt_dateofbirth.Value,
                        txt_household.Text,
                        cbx_zipcode.Text,
                        txt_city.Text,
                        int.Parse(cbx_typeresource.Text)
                    );

                    recurso.Create();
                    MessageBox.Show("Recurso adicionado com sucesso!");
                }
                else
                {
                    DerivedResources recurso = new DerivedResources(
                        int.Parse(txt_id.Text),
                        txt_name.Text,
                        int.Parse(txt_name.Text),
                        dt_dateofbirth.Value,
                        txt_household.Text,
                        cbx_zipcode.Text,
                        txt_city.Text,
                        int.Parse(cbx_typeresource.Text)
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
    }
}

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
        private void LoadZipCode()
        {
            try
            {
                List<ZipCodes> zipCodes = ZipCodes.GetZipCodes();
                cbx_zipcode.DataSource = zipCodes;
                cbx_zipcode.DisplayMember = "CodigoPostal";
                cbx_zipcode.ValueMember = "CodigoPostal";

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

        private void LoadResourceData(int id)
        {
            try
            {
                Resources recurso = Resources.ReadById(id);

                txt_id.Text = recurso.Id.ToString();
                txt_name.Text = recurso.Name;
                txt_nif.Text = recurso.NIF.ToString();

                // Garantir que a data é válida antes de atribuir
                if (recurso.DateOfBirth > DateTimePicker.MinimumDateTime)
                {
                    dt_dateofbirth.Value = recurso.DateOfBirth;
                    dt_dateofbirth.Checked = true; // Marca a data
                }
                else
                {
                    dt_dateofbirth.Checked = false; // Deixa a data "não definida"
                }

                txt_household.Text = recurso.Household;
                txt_city.Text = recurso.City;

                // Debug: Mostrando o valor do ZipCode
                Console.WriteLine($"ZipCode de recurso: '{recurso.ZipCode}'");

                // 1. Primeiro verificamos se o ZipCode é nulo ou vazio.
                if (!string.IsNullOrWhiteSpace(recurso.ZipCode))
                {
                    // 2. Comparação usando o método Trim() para remover espaços extras
                    var zipCode = ZipCodes.GetZipCodes()
                        .FirstOrDefault(z => z.CodigoPostal.Trim() == recurso.ZipCode.Trim());

                    if (zipCode != null)
                    {
                        Console.WriteLine($"Código Postal encontrado: {zipCode.CodigoPostal}");
                        cbx_zipcode.SelectedItem = zipCode;
                    }
                    else
                    {
                        Console.WriteLine($"Código Postal não encontrado: {recurso.ZipCode}");
                        MessageBox.Show($"Código Postal não encontrado: {recurso.ZipCode}");
                    }
                }
                else
                {
                    Console.WriteLine("Código Postal está vazio ou nulo.");
                }

                // Carregar o tipo de recurso
                TypeResource selectedType = TypeResource.ReadAll().FirstOrDefault(t => t.Id == recurso.Type);
                if (selectedType != null)
                {
                    Console.WriteLine($"Tipo de Recurso encontrado: {selectedType.Name}");
                    cbx_typeresource.SelectedItem = selectedType;
                }
                else
                {
                    Console.WriteLine($"Tipo de Recurso não encontrado para o ID: {recurso.Type}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados do recurso: " + ex.Message);
            }
        }



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
                if (!ResourceId.HasValue) // Criar novo recurso
                {
                    // Quando o ID do TypeResource é necessário, use SelectedValue
                    DerivedResources recurso = new DerivedResources(
                        0,
                        txt_name.Text,
                        int.Parse(txt_nif.Text),
                        dt_dateofbirth.Value,
                        txt_household.Text,
                        cbx_zipcode.Text, // Código postal
                        txt_city.Text,    // Cidade
                        (int)cbx_typeresource.SelectedValue // Aqui usamos SelectedValue para pegar o ID do tipo de recurso
                    );

                    recurso.Create();
                    MessageBox.Show("Recurso adicionado com sucesso!");
                }
                else // Atualizar recurso existente
                {
                    // Quando o ID do TypeResource é necessário, use SelectedValue
                    DerivedResources recurso = new DerivedResources(
                        int.Parse(txt_id.Text),
                        txt_name.Text,
                        int.Parse(txt_nif.Text),
                        dt_dateofbirth.Value,
                        txt_household.Text,
                        cbx_zipcode.Text, // Código postal
                        txt_city.Text,    // Cidade
                        (int)cbx_typeresource.SelectedValue // Aqui usamos SelectedValue para pegar o ID do tipo de recurso
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btx_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
        private void btx_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cbx_typeresource_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

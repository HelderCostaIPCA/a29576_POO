using POO.Resources;
using POO.ZipCodes;
using POO.TypeResources;
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
    public partial class Form_EditResource : Form
    {
        public int? ResourceId { get; set; }

        public Form_EditResource(int? resourceId = null)
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
                List<ZipCode> zipCodes = ZipCode.GetZipCodes();
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
                Resource recurso = Resource.ReadById(id);

                if (recurso == null)
                {
                    MessageBox.Show("Recurso não encontrado.");
                    return;
                }

                txt_id.Text = recurso.Id.ToString();
                txt_name.Text = recurso.Name;
                txt_nif.Text = recurso.NIF.ToString();
                txt_household.Text = recurso.Household;
                txt_city.Text = recurso.City;

                if (recurso.DateOfBirth > DateTimePicker.MinimumDateTime)
                {
                    dt_dateofbirth.Value = recurso.DateOfBirth;
                    dt_dateofbirth.Checked = true;
                }
                else
                {
                    dt_dateofbirth.Checked = false;
                }

                // Carregar os códigos postais e selecionar o correto
                List<ZipCode> zipCodesList = ZipCode.GetZipCodes();

                if (zipCodesList == null)
                {
                    MessageBox.Show("Erro: Lista de códigos postais está vazia ou não encontrada.");
                    return;
                }

                Console.WriteLine($"Total de códigos postais: {zipCodesList.Count}");

                if (!string.IsNullOrWhiteSpace(recurso.ZipCode))
                {
                    Console.WriteLine($"Código postal no recurso: {recurso.ZipCode}");

                    var zipCodeEncontrado = zipCodesList.FirstOrDefault(
                        z => z.CodigoPostal?.Trim() == recurso.ZipCode?.Trim()
                    );

                    if (zipCodeEncontrado != null)
                    {
                        cbx_zipcode.DataSource = zipCodesList;
                        cbx_zipcode.DisplayMember = "CodigoPostal";
                        cbx_zipcode.ValueMember = "CodigoPostal";
                        cbx_zipcode.SelectedItem = zipCodeEncontrado;

                        Console.WriteLine($"Código postal {zipCodeEncontrado.CodigoPostal} encontrado e selecionado.");
                    }
                    else
                    {
                        MessageBox.Show($"Código Postal não encontrado: {recurso.ZipCode}");
                    }
                }
                else
                {
                    MessageBox.Show("Recurso não possui um código postal válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os dados do recurso: {ex.Message}");
                Console.WriteLine($"Erro: {ex}");
            }
        }

        private void cbx_zipcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_zipcode.SelectedItem != null)
            {
                ZipCode zipSelecionado = (ZipCode)cbx_zipcode.SelectedItem;
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

        private void cbx_typeresource_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using POO_Occurrence;
using POO_ZipCodes;
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
    public partial class Form_EditOccurrence : Form
    {
        public int? OccurrenceId { get; set; }
        public Form_EditOccurrence(int? occurrenceId = null)
        {
            InitializeComponent();
            OccurrenceId = occurrenceId;
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

        private void btx_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (!OccurrenceId.HasValue) // Criar nova ocorrência
                {
                    // Criar uma nova ocorrência
                    Occurrence occurrence = new Occurrence(
                        0,
                        txt_description.Text,      // Descrição
                        txt_coordinates.Text,      // Coordenadas
                        txt_household.Text,        // Morada
                        cbx_zipcode.Text           // Código Postal
                    );

                    occurrence.Date = dt_date.Value; // Definindo a data da ocorrência

                    occurrence.CreateOccurrence(); // Chama o método CreateOccurrence para inserir no BD
                    MessageBox.Show("Ocorrência adicionada com sucesso!");
                }
                else // Atualizar ocorrência existente
                {
                    // Atualizar uma ocorrência existente
                    Occurrence occurrence = new Occurrence(
                        int.Parse(txt_id.Text),    // ID da Ocorrência (para o UPDATE)
                        txt_description.Text,      // Descrição
                        txt_coordinates.Text,      // Coordenadas
                        txt_household.Text,        // Morada
                        cbx_zipcode.Text           // Código Postal
                    );

                    occurrence.Date = dt_date.Value; // Atualiza a data da ocorrência

                    occurrence.UpdateOccurrence(); // Chama o método UpdateOccurrence para atualizar no BD
                    MessageBox.Show("Ocorrência atualizada com sucesso!");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar a ocorrência: " + ex.Message);
            }

        }
        private void LoadOcccurrenceData(int id)
        {
            try
            {
                // Obter a ocorrência pelo ID
                Occurrence occurrence = Occurrence.GetOccurrenceById(id);

                if (occurrence != null)
                {
                    // Preencher os campos do formulário com os dados da ocorrência
                    txt_id.Text = occurrence.Id.ToString(); // Preenche o ID
                    txt_description.Text = occurrence.Description; // Descrição
                    txt_coordinates.Text = occurrence.Coordinates; // Coordenadas
                    txt_household.Text = occurrence.Household; // Morada
                    cbx_zipcode.Text = occurrence.ZipCode; // Código postal
                    dt_date.Value = occurrence.Date; // Data da ocorrência
                }
                else
                {
                    MessageBox.Show("Ocorrência não encontrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados da ocorrência: " + ex.Message);
            }
        }

        private void Form_EditOccurrence_Load(object sender, EventArgs e)
        {
            LoadZipCode();
            //LoadTypeResource();
            if (OccurrenceId.HasValue)
            {
                LoadOcccurrenceData(OccurrenceId.Value);
            }
        }
    }
}

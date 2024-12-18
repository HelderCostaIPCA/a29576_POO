using POO.Occurrences;
using POO.ZipCodes;
using System;
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

        private void Form_EditOccurrence_Load(object sender, EventArgs e)
        {
            // Aqui pode-se carregar os dados necessários, por exemplo, para ZipCodes, se necessário.
            LoadZipCode();
            //if (OccurrenceId.HasValue)
            //{
            //    LoadOc(ResourceId.Value);
            //}
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
                    occurrence.CreateOccurrence();  // Chama o método CreateOccurrence para inserir no BD
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
                    occurrence.UpdateOccurrence();  // Chama o método UpdateOccurrence para atualizar no BD
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

        private void btx_gps_Click(object sender, EventArgs e)
        {
            try
            {
                var location = GetCoordinates();
                if (location != null)
                {
                    // Preenche o campo txt_coordinates com a latitude e longitude
                    txt_coordinates.Text = $"{location.Item1.ToString().Replace(",", ".")}, {location.Item2.ToString().Replace(",", ".")}";
                    MessageBox.Show("Coordenadas obtidas com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível obter as coordenadas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter as coordenadas: " + ex.Message);
            }
        }

        // Simulação de captura de coordenadas (poderia ser substituída por uma API de geolocalização)
        private Tuple<double, double> GetCoordinates()
        {
            // Gerando coordenadas aleatórias para simulação
            Random random = new Random();
            double latitude = random.NextDouble() * (90 - (-90)) + (-90); // Latitude entre -90 e 90
            double longitude = random.NextDouble() * (180 - (-180)) + (-180); // Longitude entre -180 e 180

            return new Tuple<double, double>(latitude, longitude);
        }
        private void cbx_zipcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_zipcode.SelectedItem != null)
            {
                ZipCode zipSelecionado = (ZipCode)cbx_zipcode.SelectedItem;
                txt_city.Text = zipSelecionado.Cidade;
            }
        }
    }
}

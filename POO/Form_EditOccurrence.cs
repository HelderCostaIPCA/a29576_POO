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
            LoadZipCode();
           
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
                if (!OccurrenceId.HasValue)
                {
                   
                    Occurrence occurrence = new Occurrence(
                        0,
                        txt_description.Text,     
                        txt_coordinates.Text,   
                        txt_household.Text,     
                        cbx_zipcode.Text        
                    );

                    occurrence.Date = dt_date.Value;
                    occurrence.CreateOccurrence();
                    MessageBox.Show("Ocorrência adicionada com sucesso!");
                }
                else
                {
                    
                    Occurrence occurrence = new Occurrence(
                        int.Parse(txt_id.Text),   
                        txt_description.Text,      
                        txt_coordinates.Text,      
                        txt_household.Text,        
                        cbx_zipcode.Text      
                    );

                    occurrence.Date = dt_date.Value;
                    occurrence.UpdateOccurrence();
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

        
        private Tuple<double, double> GetCoordinates()
        {
            
            Random random = new Random();
            double latitude = random.NextDouble() * (90 - (-90)) + (-90);
            double longitude = random.NextDouble() * (180 - (-180)) + (-180); 

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

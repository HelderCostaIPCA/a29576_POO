using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace POO_ZipCodes
{
    public class ZipCodes
    {
        public string CodigoPostal { get; set; }
        public string Cidade { get; set; }

        public static string connectionString = "Data Source=PT-DSI-HC1\\SQLEXPRESS;Initial Catalog=POO_CivilProtection;Integrated Security=True;Encrypt=False;";

        public override string ToString()
        {
            return CodigoPostal;
        }

        public static List<ZipCodes> GetZipCodes()
        {
            List<ZipCodes> zipCodes = new List<ZipCodes>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT [Zip Code], [City] FROM [Zip Code]";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            zipCodes.Add(new ZipCodes
                            {
                                CodigoPostal = reader["Zip Code"].ToString(),
                                Cidade = reader["City"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter os códigos postais: " + ex.Message);
            }

            // Depuração: Exibir o conteúdo carregado
            MessageBox.Show($"Códigos postais carregados: {zipCodes.Count}");

            return zipCodes;
        }

    }
}
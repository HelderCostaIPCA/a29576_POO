using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace POO.Resources
{
    public class CivilProtection : Resource
    {
        // Construtor da classe CivilProtection, fixando o tipo como 1 (Proteção Civil)
        public CivilProtection(int id, string name, int nif, DateTime dateOfBirth, string household, string zipCode, string city)
            : base(id, name, nif, dateOfBirth, household, zipCode, city, 1) // O tipo 1 corresponde à Proteção Civil
        { }

        // Método para criar um novo recurso de Proteção Civil
        public void CreateCivilProtection()
        {
            Create();  // Isso cria um novo recurso no banco de dados com o tipo 1 (Proteção Civil)
        }

        // Método para editar um recurso de Proteção Civil
        public void UpdateCivilProtection()
        {
            Update();  // Isso atualiza os dados no banco de dados para o recurso de Proteção Civil
        }

        // Método para ler um recurso de Proteção Civil por ID
        public static CivilProtection ReadCivilProtectionById(int id)
        {
            Resource recurso = Resource.ReadById(id);

            if (recurso != null && recurso.Type == 1)
            {
                return (CivilProtection)recurso;
            }

            return null;
        }

        // Método para ler todos os recursos de Proteção Civil
        public static List<CivilProtection> ReadAllCivilProtections()
        {
            List<CivilProtection> lista = new List<CivilProtection>();

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                // Query que busca todos os recursos, mas filtra pelo tipo 1 (Proteção Civil)
                string query = "SELECT Id, Name, NIF, [Date of Birth] AS DateOfBirth, Household, [Zip Code] AS ZipCode, City, [ID Resource Type] AS Type FROM Resources WHERE [ID Resource Type] = 1";

                SqlCommand comando = new SqlCommand(query, conexao);
                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    DateTime dateOfBirth = leitor["DateOfBirth"] != DBNull.Value
                        ? Convert.ToDateTime(leitor["DateOfBirth"])
                        : DateTime.MinValue;

                    // Cria um novo objeto CivilProtection com os dados retornados
                    CivilProtection recurso = new CivilProtection(
                        Convert.ToInt32(leitor["Id"]),
                        leitor["Name"].ToString(),
                        Convert.ToInt32(leitor["NIF"]),
                        dateOfBirth,
                        leitor["Household"].ToString(),
                        leitor["ZipCode"].ToString(),
                        leitor["City"].ToString()
                    );

                    // Adiciona o recurso à lista
                    lista.Add(recurso);
                }
            }

            return lista;
        }
    }
}

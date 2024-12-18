using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace POO.Resources
{
    public class Fireman : Resource
    {
        // Construtor da classe Fireman, fixando o tipo como 2 (Fireman)
        public Fireman(int id, string name, int nif, DateTime dateOfBirth, string household, string zipCode, string city)
            : base(id, name, nif, dateOfBirth, household, zipCode, city, 2) // O tipo 2 corresponde a Fireman
        { }

        // Método para criar um novo recurso de Fireman
        public void CreateFireman()
        {
            Create();  // Isso cria um novo recurso no banco de dados com o tipo 2 (Fireman)
        }

        // Método para editar um recurso de Fireman
        public void UpdateFireman()
        {
            Update();  // Isso atualiza os dados no banco de dados para o recurso de Fireman
        }

        // Método para ler um recurso de Fireman por ID
        public static Fireman ReadFiremanById(int id)
        {
            Resource recurso = Resource.ReadById(id);

            if (recurso != null && recurso.Type == 2)
            {
                return (Fireman)recurso;
            }

            return null;
        }

        // Método para ler todos os recursos de Fireman
        public static List<Fireman> ReadAllFiremen()
        {
            List<Fireman> lista = new List<Fireman>();

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                // Query que busca todos os recursos, mas filtra pelo tipo 2 (Fireman)
                string query = "SELECT Id, Name, NIF, [Date of Birth] AS DateOfBirth, Household, [Zip Code] AS ZipCode, City, [ID Resource Type] AS Type FROM Resources WHERE [ID Resource Type] = 2";

                SqlCommand comando = new SqlCommand(query, conexao);
                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    DateTime dateOfBirth = leitor["DateOfBirth"] != DBNull.Value
                        ? Convert.ToDateTime(leitor["DateOfBirth"])
                        : DateTime.MinValue;

                    // Cria um novo objeto Fireman com os dados retornados
                    Fireman recurso = new Fireman(
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

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace POO.Resources
{
    public class Fireman : Resource
    {
        public Fireman(int id, string name, int nif, DateTime dateOfBirth, string household, string zipCode, string city)
            : base(id, name, nif, dateOfBirth, household, zipCode, city, 2)
        { }

        public void CreateFireman()
        {
            Create();
        }

        public void UpdateFireman()
        {
            Update();
        }

        public static Fireman ReadFiremanById(int id)
        {
            Resource recurso = Resource.ReadById(id);

            if (recurso != null && recurso.Type == 2)
            {
                return (Fireman)recurso;
            }

            return null;
        }

        public static List<Fireman> ReadAllFiremen()
        {
            List<Fireman> lista = new List<Fireman>();

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {

                string query = "SELECT Id, Name, NIF, [Date of Birth] AS DateOfBirth, Household, [Zip Code] AS ZipCode, City, [ID Resource Type] AS Type FROM Resources WHERE [ID Resource Type] = 2";

                SqlCommand comando = new SqlCommand(query, conexao);
                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    DateTime dateOfBirth = leitor["DateOfBirth"] != DBNull.Value
                        ? Convert.ToDateTime(leitor["DateOfBirth"])
                        : DateTime.MinValue;


                    Fireman recurso = new Fireman(
                        Convert.ToInt32(leitor["Id"]),
                        leitor["Name"].ToString(),
                        Convert.ToInt32(leitor["NIF"]),
                        dateOfBirth,
                        leitor["Household"].ToString(),
                        leitor["ZipCode"].ToString(),
                        leitor["City"].ToString()
                    );


                    lista.Add(recurso);
                }
            }

            return lista;
        }
    }
}

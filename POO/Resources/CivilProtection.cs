using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace POO.Resources
{
    public class CivilProtection : Resource
    {
        public CivilProtection(int id, string name, int nif, DateTime dateOfBirth, string household, string zipCode, string city)
            : base(id, name, nif, dateOfBirth, household, zipCode, city, 1) // O tipo 1 corresponde à Proteção Civil
        { }

        public void CreateCivilProtection()
        {
            Create();
        }

        public void UpdateCivilProtection()
        {
            Update();
        }

        public static CivilProtection ReadCivilProtectionById(int id)
        {
            Resource recurso = Resource.ReadById(id);

            if (recurso != null && recurso.Type == 1)
            {
                return (CivilProtection)recurso;
            }

            return null;
        }

        public static List<CivilProtection> ReadAllCivilProtections()
        {
            List<CivilProtection> lista = new List<CivilProtection>();

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Name, NIF, [Date of Birth] AS DateOfBirth, Household, [Zip Code] AS ZipCode, City, [ID Resource Type] AS Type FROM Resources WHERE [ID Resource Type] = 1";

                SqlCommand comando = new SqlCommand(query, conexao);
                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    DateTime dateOfBirth = leitor["DateOfBirth"] != DBNull.Value
                        ? Convert.ToDateTime(leitor["DateOfBirth"])
                        : DateTime.MinValue;

                    CivilProtection recurso = new CivilProtection(
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

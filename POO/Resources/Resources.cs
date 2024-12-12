﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace POO_Resources
{
    public abstract class Resources
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NIF { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Household { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public int Type { get; set; }

        public static string connectionString = "Data Source=PT-DSI-HC1\\SQLEXPRESS;Initial Catalog=POO_CivilProtection;Integrated Security=True;Encrypt=False;";

        public Resources(int id, string name, int nif, DateTime dateOfBirth, string household, string zipCode, string city, int type)
        {
            Id = id;
            Name = name;
            NIF = nif;
            DateOfBirth = dateOfBirth;
            Household = household;
            ZipCode = zipCode;
            City = city;
            Type = type;
        }

        public void Create()
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Resources (Name, NIF, [Date of Birth], Household, [Zip Code], City, [ID Resource Type]) VALUES (@Name, @NIF, @DateOfBirth, @Household, @ZipCode, @City, @Type)";
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@Name", Name);
                comando.Parameters.AddWithValue("@NIF", NIF);
                comando.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                comando.Parameters.AddWithValue("@Household", Household);
                comando.Parameters.AddWithValue("@ZipCode", ZipCode);
                comando.Parameters.AddWithValue("@City", City);
                comando.Parameters.AddWithValue("@Type", Type);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public static List<Resources> ReadAll()
        {
            List<Resources> lista = new List<Resources>();
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Resources";
                SqlCommand comando = new SqlCommand(query, conexao);

                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    DateTime dateOfBirth = leitor["DateOfBirth"] != DBNull.Value
                        ? Convert.ToDateTime(leitor["DateOfBirth"])
                        : DateTime.MinValue;  // Ou outro valor padrão, se necessário

                    Resources recurso = new DerivedResources(
                        Convert.ToInt32(leitor["Id"]),
                        leitor["Name"].ToString(),
                        Convert.ToInt32(leitor["NIF"]),
                        dateOfBirth,  // Usando o valor verificado
                        leitor["Household"].ToString(),
                        leitor["ZipCode"].ToString(),
                        leitor["City"].ToString(),
                        Convert.ToInt32(leitor["Type"])
                    );
                    lista.Add(recurso);
                }
            }

            return lista;
        }
        public static Resources ReadById(int id)
        {
            Resources recurso = null;
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Resources WHERE Id = @Id";
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@Id", id);

                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();

                if (leitor.Read())
                {
                    recurso = new DerivedResources(
                        Convert.ToInt32(leitor["Id"]),
                        leitor["Name"].ToString(),
                        Convert.ToInt32(leitor["NIF"]),
                        Convert.ToDateTime(leitor["DateOfBirth"]),
                        leitor["Household"].ToString(),
                        leitor["ZipCode"].ToString(),
                        leitor["City"].ToString(),
                        Convert.ToInt32(leitor["Type"])
                    );
                }
            }

            return recurso;
        }

        public void Update()
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = "UPDATE Resources SET Name = @Name, NIF = @NIF, DateOfBirth = @DateOfBirth, Household = @Household, ZipCode = @ZipCode, City = @City, Type = @Type WHERE Id = @Id";
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@Id", Id);
                comando.Parameters.AddWithValue("@Name", Name);
                comando.Parameters.AddWithValue("@NIF", NIF);
                comando.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                comando.Parameters.AddWithValue("@Household", Household);
                comando.Parameters.AddWithValue("@ZipCode", ZipCode);
                comando.Parameters.AddWithValue("@City", City);
                comando.Parameters.AddWithValue("@Type", Type);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }
        public void Delete()
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Resources WHERE Id = @Id";
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@Id", Id);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }
    }

    public class DerivedResources : Resources
    {
        public DerivedResources(int id, string name, int nif, DateTime dateOfBirth, string household, string zipCode, string city, int type)
            : base(id, name, nif, dateOfBirth, household, zipCode, city, type) { }
    }
}

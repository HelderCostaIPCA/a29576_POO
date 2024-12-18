﻿using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace POO.TypeOccurrences
{
    public class TypeOccurrence
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int IdResourceType { get; set; } // Referência para o tipo de recurso

        public static string connectionString = "Data Source=PT-DSI-HC1\\SQLEXPRESS;Initial Catalog=POO_CivilProtection;Integrated Security=True;Encrypt=False;";

        // Construtor da classe
        public TypeOccurrence(int id, string description, int idResourceType)
        {
            Id = id;
            Description = description;
            IdResourceType = idResourceType;
        }

        // Método para buscar todas as ocorrências do banco de dados
        public static List<TypeOccurrence> ReadAll()
        {
            List<TypeOccurrence> occurrences = new List<TypeOccurrence>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM [Occurrences Types]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TypeOccurrence occurrence = new TypeOccurrence(
                                reader.GetInt32(reader.GetOrdinal("ID")),
                                reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetInt32(reader.GetOrdinal("ID Resource Type"))
                            );
                            occurrences.Add(occurrence);
                        }
                    }
                }
            }
            return occurrences;
        }

        // Método para criar uma nova ocorrência no banco de dados
        public void Create()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO [Occurrences Types] (Description, [ID Resource Type]) VALUES (@Description, @IdResourceType)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Description", Description);
                    command.Parameters.AddWithValue("@IdResourceType", IdResourceType);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para atualizar os dados de uma ocorrência no banco de dados
        public void Update()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE [Occurrences Types] SET Description = @Description, [ID Resource Type] = @IdResourceType WHERE ID = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@Description", Description);
                    command.Parameters.AddWithValue("@IdResourceType", IdResourceType);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para excluir uma ocorrência no banco de dados
        public void Delete()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM [Occurrences Types] WHERE ID = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para buscar uma única ocorrência pelo ID
        public static TypeOccurrence ReadById(int id)
        {
            TypeOccurrence occurrence = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM [Occurrences Types] WHERE ID = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            occurrence = new TypeOccurrence(
                                reader.GetInt32(reader.GetOrdinal("ID")),
                                reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetInt32(reader.GetOrdinal("ID Resource Type"))
                            );
                        }
                    }
                }
            }
            return occurrence;
        }
    }
}
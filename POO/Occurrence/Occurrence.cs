using POO_Equipment;
using POO_Resources;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace POO_Occurrence
{
    public class Occurrence
    {
        public int Id { get; set; }
        public string Household { get; set; }
        public string Description { get; set; }
        public string Coordinates { get; set; }
        public string ZipCode { get; set; }
        public DateTime Date { get; set; }
        public List<Resources> AllocatedResources { get; set; } = new List<Resources>();
        public List<Equipment> AllocatedEquipments { get; set; } = new List<Equipment>();

        public static string connectionString = "Data Source=PT-DSI-HC1\\SQLEXPRESS;Initial Catalog=POO_CivilProtection;Integrated Security=True;Encrypt=False;";

        public Occurrence(int id, string description, string coordinates, string household, string zipcode)
        {
            Id = id;
            Description = description;
            Coordinates = coordinates;
            Household = household;
            ZipCode = zipcode;
            Date = DateTime.Now;
        }

        public void AddResources(Resources resources)
        {
            AllocatedResources.Add(resources);
        }

        public void AddEquipment(Equipment equipment)
        {
            AllocatedEquipments.Add(equipment);
        }

        // Insere uma nova ocorrência no banco de dados
        public void CreateOccurrence()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Occurrences (Household, Description, Coordinates, [Zip Code], Date) " +
                               "VALUES (@Household, @Description, @Coordinates, @ZipCode, @Date)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Household", Household);
                    command.Parameters.AddWithValue("@Description", Description);
                    command.Parameters.AddWithValue("@Coordinates", Coordinates);
                    command.Parameters.AddWithValue("@ZipCode", ZipCode);
                    command.Parameters.AddWithValue("@Date", Date);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Obtém todas as ocorrências do banco de dados
        public static List<Occurrence> GetAllOccurrences()
        {
            List<Occurrence> occurrences = new List<Occurrence>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Occurrences";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Occurrence occurrence = new Occurrence(
                                reader.GetInt32(reader.GetOrdinal("Id")),
                                reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetString(reader.GetOrdinal("Coordinates")),
                                reader.GetString(reader.GetOrdinal("Household")),
                                reader.GetString(reader.GetOrdinal("Zip Code"))
                            );
                            occurrence.Date = reader.GetDateTime(reader.GetOrdinal("Date"));
                            occurrences.Add(occurrence);
                        }
                    }
                }
            }
            return occurrences;
        }

        // Atualiza uma ocorrência no banco de dados
        public void UpdateOccurrence()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Occurrences SET Household = @Household, Description = @Description, Coordinates = @Coordinates, [Zip Code] = @ZipCode, Date = @Date WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@Household", Household);
                    command.Parameters.AddWithValue("@Description", Description);
                    command.Parameters.AddWithValue("@Coordinates", Coordinates);
                    command.Parameters.AddWithValue("@ZipCode", ZipCode);
                    command.Parameters.AddWithValue("@Date", Date);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Exclui uma ocorrência do banco de dados
        public static void DeleteOccurrence(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Occurrences WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Obtém uma ocorrência específica pelo ID
        public static Occurrence GetOccurrenceById(int id)
        {
            Occurrence occurrence = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Occurrences WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            occurrence = new Occurrence(
                                reader.GetInt32(reader.GetOrdinal("Id")),
                                reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetString(reader.GetOrdinal("Coordinates")),
                                reader.GetString(reader.GetOrdinal("Household")),
                                reader.GetString(reader.GetOrdinal("Zip Code"))
                            );
                            occurrence.Date = reader.GetDateTime(reader.GetOrdinal("Date"));
                        }
                    }
                }
            }
            return occurrence;
        }
    }
}

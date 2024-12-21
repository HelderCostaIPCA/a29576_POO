using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace POO.TypeEquipments
{
    public class TypeEquipment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Enable { get; set; }

        public static string connectionString = "Data Source=PT-DSI-HC1\\SQLEXPRESS;Initial Catalog=POO_CivilProtection;Integrated Security=True;Encrypt=False;";

        public TypeEquipment(int id, string description, bool enable)
        {
            Id = id;
            Description = description;
            Enable = enable;
        }

        public void Create()
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO [Equipments Types] (Description, [Enable]) VALUES (@Description, @Enable)";
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@Description", Description);
                comando.Parameters.AddWithValue("@Enable", Enable);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Update()
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = "UPDATE [Equipments Types] SET Description = @Description, [Enable] = @Enable WHERE ID = @Id";
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@Id", Id);
                comando.Parameters.AddWithValue("@Description", Description);
                comando.Parameters.AddWithValue("@Enable", Enable);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Delete()
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM [Equipments Types] WHERE ID = @Id";
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@Id", Id);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public static List<TypeEquipment> ReadAll()
        {
            List<TypeEquipment> lista = new List<TypeEquipment>();

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, Description, [Enable] FROM [Equipments Types]";
                SqlCommand comando = new SqlCommand(query, conexao);
                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    TypeEquipment typeEquipment = new TypeEquipment(
                        Convert.ToInt32(leitor["ID"]),
                        leitor["Description"].ToString(),
                        Convert.ToBoolean(leitor["Enable"])
                    );
                    lista.Add(typeEquipment);
                }
            }

            return lista;
        }

        public static TypeEquipment ReadById(int id)
        {
            TypeEquipment typeEquipment = null;

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, Description, [Enable] FROM [Equipments Types] WHERE ID = @Id";
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@Id", id);

                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();

                if (leitor.Read())
                {
                    typeEquipment = new TypeEquipment(
                        Convert.ToInt32(leitor["ID"]),
                        leitor["Description"].ToString(),
                        Convert.ToBoolean(leitor["Enable"])
                    );
                }
            }

            return typeEquipment;
        }
    }
}

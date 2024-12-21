using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace POO.Equipments
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string SerialNumber { get; set; }
        public bool Enable { get; set; }
        public int EquipmentTypeId { get; set; }
        public bool Available { get; set; }

        public static string connectionString = "Data Source=PT-DSI-HC1\\SQLEXPRESS;Initial Catalog=POO_CivilProtection;Integrated Security=True;Encrypt=False;";

        public Equipment(int id, string description, string serialNumber, bool enable, int equipmentTypeId, bool available)
        {
            Id = id;
            Description = description;
            SerialNumber = serialNumber;
            Enable = enable;
            EquipmentTypeId = equipmentTypeId;
            Available = available;
        }
        public void Create()
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Equipments (Description, [Serial Number], [Enable], [ID Equipment Type], [Available]) VALUES (@Description, @SerialNumber, @Enable, @EquipmentTypeId, @Available)";
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@Description", Description);
                comando.Parameters.AddWithValue("@SerialNumber", SerialNumber);
                comando.Parameters.AddWithValue("@Enable", Enable);
                comando.Parameters.AddWithValue("@EquipmentTypeId", EquipmentTypeId);
                comando.Parameters.AddWithValue("@Available", Available);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Update()
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = "UPDATE Equipments SET Description = @Description, [Serial Number] = @SerialNumber, [Enable] = @Enable, [ID Equipment Type] = @EquipmentTypeId, [Available] = @Available WHERE ID = @Id";
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@Id", Id);
                comando.Parameters.AddWithValue("@Description", Description);
                comando.Parameters.AddWithValue("@SerialNumber", SerialNumber);
                comando.Parameters.AddWithValue("@Enable", Enable);
                comando.Parameters.AddWithValue("@EquipmentTypeId", EquipmentTypeId);
                comando.Parameters.AddWithValue("@Available", Available);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Delete()
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Equipments WHERE ID = @Id";
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@Id", Id);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public static List<Equipment> ReadAll()
        {
            List<Equipment> lista = new List<Equipment>();

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, Description, [Serial Number] AS SerialNumber, [Enable], [ID Equipment Type] AS EquipmentTypeId, [Available] FROM Equipments";

                SqlCommand comando = new SqlCommand(query, conexao);
                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    Equipment equipamento = new Equipment(
                        Convert.ToInt32(leitor["ID"]),
                        leitor["Description"].ToString(),
                        leitor["SerialNumber"].ToString(),
                        Convert.ToBoolean(leitor["Enable"]),
                        Convert.ToInt32(leitor["EquipmentTypeId"]),
                        Convert.ToBoolean(leitor["Available"])
                    );
                    lista.Add(equipamento);
                }
            }

            return lista;
        }

        public static Equipment ReadById(int id)
        {
            Equipment equipamento = null;

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, Description, [Serial Number] AS SerialNumber, [Enable], [ID Equipment Type] AS EquipmentTypeId, [Available] FROM Equipments WHERE ID = @Id";

                SqlCommand comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@Id", id);

                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();

                if (leitor.Read())
                {
                    equipamento = new Equipment(
                        Convert.ToInt32(leitor["ID"]),
                        leitor["Description"].ToString(),
                        leitor["SerialNumber"].ToString(),
                        Convert.ToBoolean(leitor["Enable"]),
                        Convert.ToInt32(leitor["EquipmentTypeId"]),
                        Convert.ToBoolean(leitor["Available"])
                    );
                }
            }

            return equipamento;
        }
    }
}

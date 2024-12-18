using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace POO.Equipments
{
    // A classe Vehicle herda de Equipment
    public class Vehicle : Equipment
    {
        // Construtor para inicializar o veículo com os parâmetros
        public Vehicle(int id, string description, string serialNumber, bool enable, int equipmentTypeId, bool available)
            : base(id, description, serialNumber, enable, equipmentTypeId, available)
        {
        }

        // Método para criar um novo veículo
        public void CreateVehicle()
        {
            this.Create(); // Chama o método Create da classe Equipment
        }

        // Método para atualizar um veículo
        public void UpdateVehicle()
        {
            this.Update(); // Chama o método Update da classe Equipment
        }

        // Método para ler um veículo pelo ID
        public static Vehicle ReadVehicleById(int id)
        {
            Equipment equipment = Equipment.ReadById(id); // Chama o método ReadById da classe Equipment

            if (equipment != null && equipment.EquipmentTypeId == 2) // Verifica se é um veículo (tipo 2)
            {
                return new Vehicle(
                    equipment.Id,
                    equipment.Description,
                    equipment.SerialNumber,
                    equipment.Enable,
                    equipment.EquipmentTypeId,
                    equipment.Available
                );
            }
            return null;
        }

        // Método para ler todos os veículos (filtrando por tipo 2)
        public static List<Vehicle> ReadAllVehicles()
        {
            List<Vehicle> vehicleList = new List<Vehicle>();

            using (SqlConnection connection = new SqlConnection())
            {
                // Query para obter apenas veículos (ID Equipment Type = 2)
                string query = "SELECT * FROM Equipment WHERE [ID Equipment Type] = 2";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Vehicle vehicle = new Vehicle(
                        reader.GetInt32(reader.GetOrdinal("ID")),
                        reader.GetString(reader.GetOrdinal("Description")),
                        reader.GetString(reader.GetOrdinal("Serial Number")),
                        reader.GetBoolean(reader.GetOrdinal("Enable")),
                        reader.GetInt32(reader.GetOrdinal("ID Equipment Type")),
                        reader.GetBoolean(reader.GetOrdinal("Available"))
                    );
                    vehicleList.Add(vehicle);
                }
            }
            return vehicleList;
        }

        // Método para carregar todos os veículos na DataGridView
        public static void Load_DataGridViewVehicles(DataGridView dataGridView)
        {
            try
            {
                // Chama o método ReadAllVehicles para obter todos os veículos
                List<Vehicle> vehicleList = Vehicle.ReadAllVehicles();

                // Limpa a DataGridView e define a nova lista de veículos
                dataGridView.DataSource = null;
                dataGridView.DataSource = vehicleList; // Exibe a lista de veículos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar veículos: " + ex.Message);
            }
        }
    }
}

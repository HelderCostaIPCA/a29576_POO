using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace POO.Equipments
{
    public class Vehicle : Equipment
    {
        public Vehicle(int id, string description, string serialNumber, bool enable, int equipmentTypeId, bool available)
             : base(id, description, serialNumber, enable, equipmentTypeId, available)
        {
        }

        public void CreateVehicle()
        {
            this.Create();
        }

        public void UpdateVehicle()
        {
            this.Update();
        }

        public static Vehicle ReadVehicleById(int id)
        {
            Equipment equipment = Equipment.ReadById(id);

            if (equipment != null && equipment.EquipmentTypeId == 2)
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

        public static List<Vehicle> ReadAllVehicles()
        {
            List<Vehicle> vehicleList = new List<Vehicle>();

            using (SqlConnection connection = new SqlConnection())
            {
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


        public static void Load_DataGridViewVehicles(DataGridView dataGridView)
        {
            try
            {
                List<Vehicle> vehicleList = Vehicle.ReadAllVehicles();


                dataGridView.DataSource = null;
                dataGridView.DataSource = vehicleList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar veículos: " + ex.Message);
            }
        }
    }
}

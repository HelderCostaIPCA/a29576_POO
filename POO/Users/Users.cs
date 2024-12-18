using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace POO.Users
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; } 
        public DateTime? LastLogin { get; set; } 
        public bool Enable { get; set; } // Novo campo Enable

        public static string connectionString = "Data Source=PT-DSI-HC1\\SQLEXPRESS;Initial Catalog=POO_CivilProtection;Integrated Security=True;Encrypt=False;";

        public User(int id, string username, string password, string mail = null, DateTime? lastLogin = null, bool enable = true)
        {
            Id = id;
            Username = username;
            Password = password;
            Mail = mail;
            LastLogin = lastLogin;
            Enable = enable; // Inicializando o campo Enable
        }

        // Método para buscar todos os usuários do banco de dados
        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users";  // Certifique-se de que o nome da tabela e coluna estão corretos

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Lê os dados, tratando a possibilidade de valores nulos para Last Acess
                            User user = new User(
                                reader.GetInt32(reader.GetOrdinal("ID")),
                                reader.GetString(reader.GetOrdinal("Username")),
                                reader.GetString(reader.GetOrdinal("Password")),
                                reader.IsDBNull(reader.GetOrdinal("Mail")) ? null : reader.GetString(reader.GetOrdinal("Mail")),
                                reader.IsDBNull(reader.GetOrdinal("Last Acess")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("Last Acess")),
                                reader.GetBoolean(reader.GetOrdinal("Enable"))  // Lê o campo Enable
                            );
                            users.Add(user);
                        }
                    }
                }
            }
            return users;
        }


        // Método para criar um novo usuário no banco de dados
        public void CreateUser()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (Username, Password, Mail, Enable) VALUES (@Username, @Password, @Mail, @Enable)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Mail", Mail);
                    command.Parameters.AddWithValue("@Enable", Enable); // Inclui o campo Enable

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para atualizar os dados do usuário no banco de dados
        public void UpdateUser()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET Username = @Username, Password = @Password, Mail = @Mail, Enable = @Enable WHERE ID = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Mail", Mail);
                    command.Parameters.AddWithValue("@Enable", Enable); // Atualizando também o campo Enable

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para buscar um usuário pelo ID no banco de dados
        public static User ReadById(int id)
        {
            User user = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users WHERE ID = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User(
                                reader.GetInt32(reader.GetOrdinal("ID")),
                                reader.GetString(reader.GetOrdinal("Username")),
                                reader.GetString(reader.GetOrdinal("Password")),
                                reader.IsDBNull(reader.GetOrdinal("Mail")) ? null : reader.GetString(reader.GetOrdinal("Mail")),
                                reader.IsDBNull(reader.GetOrdinal("Last Acess")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("Last Acess")),
                                reader.GetBoolean(reader.GetOrdinal("Enable")) // Lê o campo Enable
                            );
                        }
                    }
                }
            }
            return user;
        }

        // Método para atualizar a data do último login do usuário
        public void UpdateLastLogin()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET [Last Acess] = @LastLogin WHERE ID = @Id"; 

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@LastLogin", DateTime.Now);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para autenticar o usuário
        public static User AuthenticateUser(string username, string password)
        {
            User user = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password AND Enable = 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User(
                                reader.GetInt32(reader.GetOrdinal("ID")),
                                reader.GetString(reader.GetOrdinal("Username")),
                                reader.GetString(reader.GetOrdinal("Password")),
                                reader.IsDBNull(reader.GetOrdinal("Mail")) ? null : reader.GetString(reader.GetOrdinal("Mail")),
                                reader.IsDBNull(reader.GetOrdinal("Last Acess")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("Last Acess")),
                                reader.GetBoolean(reader.GetOrdinal("Enable")) // Lê o campo Enable
                            );
                        }
                    }
                }
            }
            return user;
        }
        public static User GetUserByUsername(string username)
        {
            User user = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User(
                                reader.GetInt32(reader.GetOrdinal("ID")),
                                reader.GetString(reader.GetOrdinal("Username")),
                                reader.GetString(reader.GetOrdinal("Password")),
                                reader.IsDBNull(reader.GetOrdinal("Mail")) ? null : reader.GetString(reader.GetOrdinal("Mail")),
                                reader.IsDBNull(reader.GetOrdinal("Last Acess")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("Last Acess")),
                                reader.GetBoolean(reader.GetOrdinal("Enable"))
                            );
                        }
                    }
                }
            }
            return user;
        }
    }
}

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace POO_TypeResource
{
    public abstract class TypeResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Enable { get; set; }

        public static string connectionString = "Data Source=PT-DSI-HC1\\SQLEXPRESS;Initial Catalog=POO_CivilProtection;Integrated Security=True;Encrypt=False;";

       public TypeResource(int id, string name, bool enable)
        {
            Id = id;
            Name = name;
            Enable = enable;
        }

       public void Create()
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand("INSERT INTO [Resources Types] (Name, Enable) VALUES (@Name, @Enable)", conexao))
            {
                comando.Parameters.AddWithValue("@Name", Name);
                comando.Parameters.AddWithValue("@Enable", Enable);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public static List<TypeResource> ReadAll()
        {
            List<TypeResource> lista = new List<TypeResource>();

            using (SqlConnection conexao = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand("SELECT * FROM [Resources Types]", conexao))
            {
                conexao.Open();
                using (SqlDataReader leitor = comando.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        TypeResource recurso = new DerivedTypeResources(
                            Convert.ToInt32(leitor["Id"]),
                            leitor["Name"].ToString(),
                            Convert.ToBoolean(leitor["Enable"])
                        );
                        lista.Add(recurso);
                    }
                }
            }

            return lista;
        }

        public static TypeResource ReadById(int id)
        {
            TypeResource recurso = null;

            using (SqlConnection conexao = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand("SELECT * FROM [Resources Types] WHERE Id = @Id", conexao))
            {
                comando.Parameters.AddWithValue("@Id", id);

                conexao.Open();
                using (SqlDataReader leitor = comando.ExecuteReader())
                {
                    if (leitor.Read())
                    {
                        recurso = new DerivedTypeResources(
                            Convert.ToInt32(leitor["Id"]),
                            leitor["Name"].ToString(),
                            Convert.ToBoolean(leitor["Enable"])
                        );
                    }
                }
            }

            return recurso;
        }

        public void Update()
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand("UPDATE [Resources Types] SET Name = @Name, Enable = @Enable WHERE Id = @Id", conexao))
            {
                comando.Parameters.AddWithValue("@Id", Id);
                comando.Parameters.AddWithValue("@Name", Name);
                comando.Parameters.AddWithValue("@Enable", Enable);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Delete()
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand("DELETE FROM [Resources Types] WHERE Id = @Id", conexao))
            {
                comando.Parameters.AddWithValue("@Id", Id);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }
    }

    public class DerivedTypeResources : TypeResource
    {
        public DerivedTypeResources(int id, string name, bool enable)
            : base(id, name, enable) { }
    }
}

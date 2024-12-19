using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PREP_ORDER
{
    internal class User
    {
        public static List<(int userID, string login, string role, string zone)> GetAllUsers()
        {
            var users = new List<(int userID, string login, string role, string zone)>();
            using (SqlConnection connection = new SqlConnection(Program.GetConnectionString()))
            {
                using (SqlCommand command = new SqlCommand("prc_get_all_users", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userID = Convert.ToInt32(reader["UserID"]);
                            string userLogin = reader["login"].ToString();
                            string role = reader["Role"].ToString();
                            string zone = reader["libelleZone"] != DBNull.Value ? reader["libelleZone"].ToString() : "Aucune";

                            users.Add((userID, userLogin, role, zone));
                        }
                    }
                }
            }
            return users;
        }

        public static void ModifUser(int id, string login, string role, string zone)
        {
            using (SqlConnection connection = new SqlConnection(Program.GetConnectionString()))
            {
                using (SqlCommand command = new SqlCommand("prc_update_user", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@role", role);
                    command.Parameters.AddWithValue("@zone", zone);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddUser(string login, string mdp, string role, string zone)
        {
            using (SqlConnection connection = new SqlConnection(Program.GetConnectionString()))
            {
                using (SqlCommand command = new SqlCommand("prc_add_user", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@mdp", mdp);
                    command.Parameters.AddWithValue("@role", role);
                    command.Parameters.AddWithValue("@zone", zone);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

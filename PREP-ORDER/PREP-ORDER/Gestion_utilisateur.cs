using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
using Microsoft.VisualBasic.ApplicationServices;

namespace PREP_ORDER
{
    public partial class Gestion_utilisateur : Form
    {
        public Gestion_utilisateur()
        {
            InitializeComponent();
        }

        public class User
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
                                string zone = reader["codeZone"] != DBNull.Value ? reader["codeZone"].ToString() : "Aucune";

                                users.Add((userID, userLogin, role, zone));
                            }
                        }
                    }
                }
                return users;
            }
        }

        private void Gestion_utilisateur_Load(object sender, EventArgs e)
        {
            // Vider la ListView
            lvUser.Items.Clear();

            // Récupérer les données
            var users = User.GetAllUsers();

            // Parcourir les résultats et ajouter chaque utilisateur
            foreach (var user in users)
            {
                ListViewItem item = new ListViewItem(user.userID.ToString()); // ID
                item.SubItems.Add(user.login);                               // Login
                item.SubItems.Add(user.role);                                // Role
                item.SubItems.Add(user.zone);                                // Zone

                lvUser.Items.Add(item); // Ajouter à la ListView
            }
        }
    }
}

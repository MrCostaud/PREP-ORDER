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


namespace PREP_ORDER
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        public class Authentification
        {
            public static (bool success, string role, int userID, string login) AuthentifierUtilisateur(string login, string mdp)
            {
                using (SqlConnection connection = new SqlConnection(Program.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand("prc_find_user", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Ajouter les paramètres
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@mdp", mdp);

                        connection.Open();

                        // Exécuter la procédure stockée
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) // Si des résultats sont renvoyés
                            {
                                while (reader.Read())
                                {
                                    string role = reader["Role"].ToString();
                                    int userID = Convert.ToInt32(reader["UserID"]);
                                    string userLogin = reader["login"].ToString();

                                    // Retourne les informations de l'utilisateur
                                    return (true, role, userID, userLogin);
                                }
                            }
                        }
                    }
                }

                // Aucun utilisateur trouvé
                return (false, null, 0, null);
            }
        }
        private void btnConnexion_Click(object sender, EventArgs e)
        {
           
        }
    }
}

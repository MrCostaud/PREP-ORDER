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
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@mdp", mdp);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string role = reader["Role"].ToString();
                                    int userID = Convert.ToInt32(reader["UserID"]);
                                    string userLogin = reader["login"].ToString();
                                    return (true, role, userID, userLogin);
                                }
                            }
                        }
                    }
                }
                return (false, null, 0, null);
            }
        }
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string mdp = tbMdp.Text; //à crypter

            var resultat = Authentification.AuthentifierUtilisateur(login, mdp);

            if (resultat.success)
            {
                string role = resultat.role;
                int userID = resultat.userID;

                switch (role)
                {
                    case "RESPONSABLE":
                        MessageBox.Show($"Bienvenue, Responsable {resultat.login} !");
                        Form Gestion_commandes = new Gestion_commandes();
                        Gestion_commandes.Show();
                        break;

                    case "PREPARATEUR":
                        MessageBox.Show($"Bienvenue, Préparateur {resultat.login} !");
                        break;

                    case "CARISTE":
                        MessageBox.Show($"Bienvenue, Cariste {resultat.login} !");
                        Form tableau_de_bord_rack = new tableau_de_bord_racks();
                        tableau_de_bord_rack.Show();
                        break;

                    default:
                        MessageBox.Show("Rôle inconnu, contactez l'administrateur.");
                        Form Form2 = new Form2();
                        Form2.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Échec de la connexion. Veuillez vérifier vos identifiants.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }
    }
}

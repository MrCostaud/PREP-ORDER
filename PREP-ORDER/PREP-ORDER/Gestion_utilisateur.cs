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
using static PREP_ORDER.Gestion_utilisateur;

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

            //ajouter les secteurs à la comboBox dédiée
            cbSecteur.Items.Add("Sec");
            cbSecteur.Items.Add("Liquide");
            cbSecteur.Items.Add("DPH");

            tbLogin.Enabled = false;
            cbSecteur.Enabled = false;
        }

        int id = 0;
        string login = "";
        string role = "";
        string secteur = "";

        private void lvUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUser.SelectedItems.Count > 0)
            {
                // Obtenir l'élément sélectionné
                ListViewItem selectedItem = lvUser.SelectedItems[0];

                id = int.Parse(selectedItem.SubItems[0].Text);

                login = selectedItem.SubItems[1].Text;

                role = selectedItem.SubItems[2].Text;

                secteur = selectedItem.SubItems[3].Text;

                cbSecteur.Text = secteur;
                tbLogin.Text = login;
                tbLogin.Enabled = true;

                if (secteur != "Aucune")
                {
                    cbSecteur.Enabled = true;
                }
            }
            else
            {
                tbLogin.Enabled = false;
                cbSecteur.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLogin.Text))
            {
                MessageBox.Show("Le champ Login ne peut pas être vide.");
                return;
            }

            if (role == "RESPONSABLE" && secteur != "Aucune")
            {
                MessageBox.Show("Un responsable ne peut pas avoir de secteur assigné.");
                return;
            }

            secteur = cbSecteur.Text; // Met à jour le secteur depuis la ComboBox

            try
            {
                // Mise à jour de l'utilisateur
                User.ModifUser(id, tbLogin.Text, role, secteur);
                MessageBox.Show("Utilisateur mis à jour avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la mise à jour : {ex.Message}");
            }

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

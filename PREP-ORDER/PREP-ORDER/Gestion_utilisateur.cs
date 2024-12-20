﻿using System;
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

            cbSecteurAdd.Items.Add("Sec");
            cbSecteurAdd.Items.Add("Liquide");
            cbSecteurAdd.Items.Add("DPH");

            cbRoleAdd.Items.Add("PREPARATEUR");
            cbRoleAdd.Items.Add("CARISTE");
            cbRoleAdd.Items.Add("RESPONSABLE");

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

            if (role == "RESPONSABLE" && secteur != "Aucun")
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

            // On rafraîchit la comboBox
            var users = User.GetAllUsers();

            
            foreach (var user in users)
            {
                ListViewItem item = new ListViewItem(user.userID.ToString()); 
                item.SubItems.Add(user.login);                               
                item.SubItems.Add(user.role);                                
                item.SubItems.Add(user.zone);                                

                lvUser.Items.Add(item); 
            }
        }

        private void cbRoleAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si le rôle est responsable : pas de secteur
            if (cbRoleAdd.Text == "RESPONSABLE")
            {
                cbSecteurAdd.Enabled = false;
                cbSecteurAdd.SelectedIndex = 0;
                cbSecteurAdd.Text = "Aucun";
            }
            else
            {
                cbSecteurAdd.Enabled = true;
                cbSecteurAdd.Text = "Sec";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //on vérifie la présence d'un identifiant
            if (string.IsNullOrWhiteSpace(tbLoginAdd.Text))
            {
                MessageBox.Show("Le champ 'identifiant' ne peut pas être vide.");
                return;
            }

            //et d'un mot de passe
            if (string.IsNullOrWhiteSpace(tbLoginAdd.Text))
            {
                MessageBox.Show("Le champ 'mot de passe' ne peut pas être vide.");
                return;
            }

            try
            {
                // Ajout de l'utilisateur en base de données
                User.AddUser(tbLoginAdd.Text, tbMdpAdd.Text, cbRoleAdd.Text, cbSecteurAdd.Text);
                MessageBox.Show("Utilisateur ajouté avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout : {ex.Message}");
            }

            lvUser.Items.Clear();

            // On rafraîchit la comboBox
            var users = User.GetAllUsers();


            foreach (var user in users)
            {
                ListViewItem item = new ListViewItem(user.userID.ToString()); 
                item.SubItems.Add(user.login);                               
                item.SubItems.Add(user.role);                                
                item.SubItems.Add(user.zone);                                

                lvUser.Items.Add(item); 
            }
        }
    }
}

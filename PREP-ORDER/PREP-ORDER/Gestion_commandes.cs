﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PREP_ORDER
{
    public partial class Gestion_commandes : Form
    {
        public Gestion_commandes()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Fichiers CSV (*.csv)|*.csv";
                openFileDialog.Title = "Sélectionner un fichier CSV";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        // Charger et afficher les données du CSV
                        LoadCSVIntoListView(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors du chargement du fichier : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadCSVIntoListView(string filePath)
        {
            // Efface les données actuelles de la ListView
            lvCommande.Items.Clear();

            // Lire toutes les lignes du fichier CSV
            string[] lines = File.ReadAllLines(filePath);

            // Parcourir chaque ligne, en ignorant la première ligne (entêtes)
            for (int i = 1; i < lines.Length; i++)
            {
                string[] columns = lines[i].Split(',');

                if (columns.Length == 4) // Vérifie que chaque ligne a 4 colonnes
                {
                    ListViewItem item = new ListViewItem(columns[0]); // Clé Produit
                    item.SubItems.Add(columns[1]); // Nom du Produit
                    item.SubItems.Add(columns[2]); // Quantité
                    item.SubItems.Add(columns[3]); // Zone
                    lvCommande.Items.Add(item);
                }
                else
                {
                    MessageBox.Show($"Ligne invalide dans le fichier CSV : {lines[i]}", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Gestion_commandes_Load(object sender, EventArgs e)
        {
            string zone = "";
            string login = "";
            string role = "";
            var users = User.GetAllUsers();
            foreach (var user in users)
            {
                zone = user.zone;
                login = user.login;
                role = user.role;
                if (role == "PREPARATEUR")
                {
                    if (zone == "Sec")
                    {
                        cbSec.Items.Add(user.login);
                    }
                    else if (zone == "Liquide")
                    {
                        cbLiquide.Items.Add(user.login);
                    }
                    else
                    {
                        cbDPH.Items.Add(user.login);
                    }
                }
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            lvSec.Items.Clear();
            lvLiquide.Items.Clear();
            lvDPH.Items.Clear();

            // Parcourir les éléments de la ListView
            foreach (ListViewItem item in lvCommande.Items)
            {
                // Vérifier la valeur de la dernière colonne (Zone)
                string sector = item.SubItems[3].Text.ToLower(); // La dernière colonne représente le secteur

                if(sector == "sec")
                {
                    lvSec.Items.Add((ListViewItem)item.Clone());
                }
                else if(sector == "liquide")
                {
                    lvLiquide.Items.Add((ListViewItem)item.Clone());
                }
                else if(sector == "dph")
                {
                    lvDPH.Items.Add((ListViewItem)item.Clone());
                }
                else
                {
                    MessageBox.Show($"Secteur inconnu détecté : {sector}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lvCommande.Items.Clear();
                    lvSec.Items.Clear();
                    lvLiquide.Items.Clear();
                    lvDPH.Items.Clear();
                }
            }
        }
    }
}

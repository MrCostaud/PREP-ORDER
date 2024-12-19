using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
                        btnDivide.Enabled = true;
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
            btnDivide.Enabled = false;
            btnAdd.Enabled = false;
            cbSec.Enabled = false;
            cbLiquide.Enabled = false;
            cbDPH.Enabled = false;

            var commandes = Commande.GetCommandes();
            foreach(var comm in commandes)
            {
                ListViewItem item = new ListViewItem(comm.idComm.ToString());
                item.SubItems.Add(comm.nomMagasin);
                if(comm.etat == false)
                {
                    item.SubItems.Add("En cours");
                }
                else
                {
                    item.SubItems.Add("Terminée");
                }
                lvListComm.Items.Add(item);
            }

            var magasins = Commande.GetMagasins();
            string nomMagasin = "";
            foreach (var mag in magasins)
            {
                nomMagasin = mag.nomMagasin;
                cbMag.Items.Add(nomMagasin);
            }

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

                if (sector == "sec")
                {
                    lvSec.Items.Add((ListViewItem)item.Clone());
                }
                else if (sector == "liquide")
                {
                    lvLiquide.Items.Add((ListViewItem)item.Clone());
                }
                else if (sector == "dph")
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

                if (lvSec.Items.Count > 0)
                {
                    cbSec.Enabled = true;
                }
                if (lvLiquide.Items.Count > 0)
                {
                    cbLiquide.Enabled = true;
                }
                if (lvDPH.Items.Count > 0)
                {
                    cbDPH.Enabled = true;
                }

                if (cbSec.Text != "" || cbLiquide.Text != "" || cbDPH.Text != "" && cbMag.Text != "")
                {
                    btnAdd.Enabled = true;
                }
                else
                {
                    btnAdd.Enabled = false;
                }
            }
        }

        private void cbMag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSec.Text != "" || cbLiquide.Text != "" || cbDPH.Text != "" && cbMag.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void cbSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSec.Text != "" || cbLiquide.Text != "" || cbDPH.Text != "" && cbMag.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void cbLiquide_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSec.Text != "" || cbLiquide.Text != "" || cbDPH.Text != "" && cbMag.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void cbDPH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSec.Text != "" || cbLiquide.Text != "" || cbDPH.Text != "" && cbMag.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        //me permet de charger une liste d'erreurs à afficher à la fin plutôt que de rencontrer plusieurs messages d'erreurs
        // en cas d'échec
        private void ExecuteWithErrorHandling(Action action, string errorMessage, List<string> errors)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                errors.Add($"{errorMessage} : {ex.Message}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var errors = new List<string>();

            string nomMag = cbMag.Text;
            int nbCommandes = Commande.GetNbCommandes() + 1;

            ExecuteWithErrorHandling(() => Commande.AddCommande(nbCommandes, nomMag, DateTime.Now),
                "Erreur lors de l'ajout de la commande", errors);

            // Sous-commande sec
            int nbSousCommandes = Commande.GetNbSousCommandes() + 1;
            ExecuteWithErrorHandling(() => Commande.AddSousCommande(nbSousCommandes, nbCommandes, nomMag, cbSec.Text),
                "Erreur lors de l'ajout de la sous-commande Sec", errors);
            if (lvSec.Items.Count > 0)
            {
                foreach (ListViewItem item in lvSec.Items)
                {
                    string nomProduit = item.SubItems[1].Text;
                    int qtLot = int.Parse(item.SubItems[2].Text);

                    ExecuteWithErrorHandling(() => Commande.AddComposer(nbSousCommandes, nomProduit, qtLot),
                        "Erreur lors de l'ajout d'un produit Sec", errors);
                }
            }



            // Sous-commande Liquide
            nbSousCommandes += 1;
            ExecuteWithErrorHandling(() => Commande.AddSousCommande(nbSousCommandes, nbCommandes, nomMag, cbLiquide.Text),
                "Erreur lors de l'ajout de la sous-commande Liquide", errors);

            if (lvLiquide.Items.Count > 0)
            {
                foreach (ListViewItem item in lvLiquide.Items)
                {
                    string nomProduit = item.SubItems[1].Text;
                    int qtLot = int.Parse(item.SubItems[2].Text);

                    ExecuteWithErrorHandling(() => Commande.AddComposer(nbSousCommandes, nomProduit, qtLot),
                        "Erreur lors de l'ajout d'un produit Liquide", errors);
                }
            }

            // Sous-commande DPH
            nbSousCommandes += 1;
            ExecuteWithErrorHandling(() => Commande.AddSousCommande(nbSousCommandes, nbCommandes, nomMag, cbDPH.Text),
                "Erreur lors de l'ajout de la sous-commande DPH", errors);

            if (lvDPH.Items.Count > 0)
            {
                foreach (ListViewItem item in lvDPH.Items)
                {
                    string nomProduit = item.SubItems[1].Text;
                    int qtLot = int.Parse(item.SubItems[2].Text);

                    ExecuteWithErrorHandling(() => Commande.AddComposer(nbSousCommandes, nomProduit, qtLot),
                        "Erreur lors de l'ajout d'un produit DPH", errors);
                }
            }

            // Afficher toutes les erreurs à la fin
            if (errors.Any())
            {
                MessageBox.Show(string.Join("\n", errors), "Erreurs rencontrées", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Commande ajoutée avec succès !", "Succès", MessageBoxButtons.OK);
            }
            lvCommande.Items.Clear();
            lvSec.Items.Clear();
            lvLiquide.Items.Clear();
            lvDPH.Items.Clear();
            cbMag.Text = "";
            cbDPH.Text = "";
            cbSec.Text = "";
            cbLiquide.Text = "";
            btnAdd.Enabled = false;
            btnDivide.Enabled = false;

            lvListComm.Items.Clear();
            var commandes = Commande.GetCommandes();
            foreach (var comm in commandes)
            {
                ListViewItem item = new ListViewItem(comm.idComm.ToString());
                item.SubItems.Add(comm.nomMagasin);
                if (comm.etat == false)
                {
                    item.SubItems.Add("En cours");
                }
                else
                {
                    item.SubItems.Add("Terminée");
                }
                lvListComm.Items.Add(item);
            }


        }

        private void lvSec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

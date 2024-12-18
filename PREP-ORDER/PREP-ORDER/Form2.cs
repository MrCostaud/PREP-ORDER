using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinFormsButton = System.Windows.Forms.Button;
namespace PREP_ORDER
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form2_Load);
        }

        private void ChargerDonneesZone()
        {
            string connectionString = "Server=SIO2023-23\\SQLEXPRESS;Database=preporder1;Trusted_Connection=True;";
            string query = " SELECT top 10 c.numCommande, c.dateCommande, m.numMagasin, m.nomMagasin, z.codeZone,  z.libelleZone, p.libelleProduit, qtLotProduit, c.statut, Probleme \r\nFROM  COMMANDE c \r\nINNER JOIN MAGASIN m ON c.numMagasin = m.numMagasin \r\nINNER JOIN ZONE z ON z.codeZone = m.codeZone \r\nINNER JOIN PRODUIT p ON z.codeZone = p.codeZone \r\ninner join PALETTE on p.numProduit = numPalette \r\nwhere statut = 'En cours';";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GérerAffichageBoutons();

        }

        private void GérerAffichageBoutons()
        {

            int rowCount = dataGridView1.Rows.Count;


            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;



            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;



            if (rowCount >= 1) button11.Visible = true;
            if (rowCount >= 2) button12.Visible = true;
            if (rowCount >= 3) button13.Visible = true;
            if (rowCount >= 4) button14.Visible = true;
            if (rowCount >= 5) button15.Visible = true;
            if (rowCount >= 6) button16.Visible = true;
            if (rowCount >= 7) button17.Visible = true;
            if (rowCount >= 8) button18.Visible = true;
            if (rowCount >= 9) button19.Visible = true;
            if (rowCount >= 10) button20.Visible = true;




            if (rowCount >= 1) button1.Visible = true;
            if (rowCount >= 2) button2.Visible = true;
            if (rowCount >= 3) button3.Visible = true;
            if (rowCount >= 4) button4.Visible = true;
            if (rowCount >= 5) button5.Visible = true;
            if (rowCount >= 6) button6.Visible = true;
            if (rowCount >= 7) button7.Visible = true;
            if (rowCount >= 8) button8.Visible = true;
            if (rowCount >= 9) button9.Visible = true;
            if (rowCount >= 10) button10.Visible = true;




        }


        private void Form2_Load(object sender, EventArgs e)
        {
            ChargerDonneesZone();


            button1.Click += Bouton_Click;
            button2.Click += Bouton_Click;
            button3.Click += Bouton_Click;
            button4.Click += Bouton_Click;
            button5.Click += Bouton_Click;
            button6.Click += Bouton_Click;
            button7.Click += Bouton_Click;
            button8.Click += Bouton_Click;
            button9.Click += Bouton_Click;
            button10.Click += Bouton_Click;
            button11.Click += Bouton_Click2;
            button12.Click += Bouton_Click2;
            button13.Click += Bouton_Click2;
            button14.Click += Bouton_Click2;
            button15.Click += Bouton_Click2;
            button16.Click += Bouton_Click2;
            button17.Click += Bouton_Click2;
            button18.Click += Bouton_Click2;
            button19.Click += Bouton_Click2;
            button20.Click += Bouton_Click2;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Server=SIO2023-23\\SQLEXPRESS;Database=preporder1;Trusted_Connection=True;";
            string query = $"SELECT top 10 c.numCommande, c.dateCommande, m.numMagasin, m.nomMagasin, z.codeZone,  z.libelleZone, p.libelleProduit, qtLotProduit, c.statut, Probleme \r\nFROM  COMMANDE c \r\nINNER JOIN MAGASIN m ON c.numMagasin = m.numMagasin \r\nINNER JOIN ZONE z ON z.codeZone = m.codeZone \r\nINNER JOIN PRODUIT p ON z.codeZone = p.codeZone \r\ninner join PALETTE on p.numProduit = numPalette WHERE libelleZone = '{comboBox1.Text}' and statut = 'En cours';";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GérerAffichageBoutons();
        }










        private void Bouton_Click(object sender, EventArgs e)
        {
            // Identifier le bouton cliqué
            System.Windows.Forms.Button boutonClique = sender as System.Windows.Forms.Button;

            // Trouver l'index de la ligne correspondante
            int rowIndex = int.Parse(boutonClique.Name.Replace("button", "")) - 1;

            // Vérifier si l'index est valide
            if (rowIndex < dataGridView1.Rows.Count)
            {
                // Récupérer le `numCommande` de la ligne correspondante
                int numCommande = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["numCommande"].Value);

                // Mettre à jour le statut dans la base de données
                MettreAJourStatut(numCommande, "Terminé");

                // Rafraîchir l'affichage
                ChargerDonneesZone();
            }

        }



        private void Bouton_Click2(object sender, EventArgs e)
        {
            // Identifier le bouton cliqué
            System.Windows.Forms.Button boutonClique1 = sender as System.Windows.Forms.Button;

            // Trouver l'index de la ligne correspondante (ajuster pour boutons après 10)
            int rowIndex = int.Parse(boutonClique1.Name.Replace("button", "")) - 11;

            // Vérifier si l'index est valide
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                // Récupérer le `numCommande` de la ligne correspondante
                int numCommande = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["numCommande"].Value);

                // Mettre à jour le statut ou le problème dans la base de données
                MettreAJourStatut1(numCommande, "Erreur");

                // Rafraîchir l'affichage
                ChargerDonneesZone();
            }
            else
            {
                MessageBox.Show("Le bouton n'est pas associé à une ligne valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }






        private void MettreAJourStatut(int numCommande, string nouveauStatut)
        {
            string connectionString = "Server=SIO2023-23\\SQLEXPRESS;Database=preporder1;Trusted_Connection=True;";
            string query = "UPDATE COMMANDE SET statut = @statut WHERE numCommande = @numCommande";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@statut", nouveauStatut);
                    command.Parameters.AddWithValue("@numCommande", numCommande);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show($"Le statut de la commande {numCommande} a été mis à jour à '{nouveauStatut}'.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }








        private void MettreAJourStatut1(int numCommande, string nouveauProbleme)
        {
            string connectionString = "Server=SIO2023-23\\SQLEXPRESS;Database=preporder1;Trusted_Connection=True;";
            string query = "UPDATE COMMANDE SET Probleme = @Probleme WHERE numCommande = @numCommande";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Probleme", nouveauProbleme);
                    command.Parameters.AddWithValue("@numCommande", numCommande);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show($"La notification Probléme de la commande {numCommande} a été mis à jour à '{nouveauProbleme}'.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }
    }
}

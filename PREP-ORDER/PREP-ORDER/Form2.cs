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
            string query = " SELECT top 10 c.numCommande, numSousComm, c.dateCommande, m.numMagasin, m.nomMagasin, z.codeZone,  z.libelleZone, p.libelleProduit, qtLotProduit, c.statut, Problem \r\nFROM  COMMANDE c \r\nINNER JOIN MAGASIN m ON c.numMagasin = m.numMagasin \r\nINNER JOIN ZONE z ON z.codeZone = m.codeZone \r\nINNER JOIN PRODUIT p ON z.codeZone = p.codeZone \r\ninner join PALETTE on p.numProduit = numPalette \r\ninner join COMPOSER CO on p.numProduit = CO.numProduit \r\nwhere statut = 'En cours';";

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
            string query = $"SELECT top 10 c.numCommande, numSousComm,p.numProduit, c.dateCommande, m.numMagasin, m.nomMagasin, z.codeZone,  z.libelleZone, p.libelleProduit, qtLotProduit, c.statut, Problem \r\nFROM  COMMANDE c \r\nINNER JOIN MAGASIN m ON c.numMagasin = m.numMagasin \r\nINNER JOIN ZONE z ON z.codeZone = m.codeZone \r\nINNER JOIN PRODUIT p ON z.codeZone = p.codeZone \r\ninner join PALETTE on p.numProduit = numPalette \r\ninner join COMPOSER CO on p.numProduit = CO.numProduit WHERE libelleZone = '{comboBox1.Text}' and statut = 'En cours';";

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
            System.Windows.Forms.Button boutonClique = sender as System.Windows.Forms.Button;

            int rowIndex = int.Parse(boutonClique.Name.Replace("button", "")) - 1;

            if (rowIndex < dataGridView1.Rows.Count)
            {
                int numCommande = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["numCommande"].Value);
               
                MettreAJourStatut(numCommande, "Validée");

                ChargerDonneesZone();
            }
            else
            {
                MessageBox.Show("Index de ligne non valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void Bouton_Click2(object sender, EventArgs e)
        {
            System.Windows.Forms.Button boutonClique1 = sender as System.Windows.Forms.Button;

            int rowIndex = int.Parse(boutonClique1.Name.Replace("button", "")) - 11;
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                int numCommande = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["numSousComm"].Value);

                MettreAJourStatut1(numCommande, "Erreur");

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
            string query = @"UPDATE COMMANDE SET statut = @statut WHERE numCommande = @numCommande ";

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

                MessageBox.Show($"Le statut de la commande {numCommande} a été mis à jour à '{nouveauStatut}'.",
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }









        private void MettreAJourStatut1(int numCommande, string nouveauProbleme)
        {
            string connectionString = "Server=SIO2023-23\\SQLEXPRESS;Database=preporder1;Trusted_Connection=True;";
            string query = "UPDATE COMPOSER SET Problem = @Problem WHERE numSousComm = @numSousComm";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Problem", nouveauProbleme);
                    command.Parameters.AddWithValue("@numSouSComm", numCommande);

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

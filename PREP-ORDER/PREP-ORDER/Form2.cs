using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PREP_ORDER
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form2_Load); // Associer l'événement Load
        }

        private void ChargerDonneesZone()
        {
            string connectionString = "Server=SIO2023-23\\SQLEXPRESS;Database=preporder;Trusted_Connection=True;";
            string query = "SELECT c.numCommande, c.dateCommande, m.numMagasin, m.nomMagasin, z.codeZone,  z.libelleZone, libelleProduit, qtLotProduit FROM  COMMANDE c INNER JOIN MAGASIN m ON c.numMagasin = m.numMagasin INNER JOIN SOUS_COMMANDE ON numSousComm = c.numCommande INNER JOIN PRODUIT p ON numProduit = numSousComm INNER JOIN ZONE z ON z.codeZone = p.codeZone inner join PALETTE on p.numProduit = numPalette;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable; // Vérifiez que le DataGridView s'appelle bien dataGridView1
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ChargerDonneesZone();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Server=SIO2023-23\\SQLEXPRESS;Database=preporder;Trusted_Connection=True;";
            string query = $"SELECT c.numCommande, c.dateCommande, m.numMagasin, m.nomMagasin, z.codeZone,  z.libelleZone, libelleProduit, qtLotProduit FROM  COMMANDE c INNER JOIN MAGASIN m ON c.numMagasin = m.numMagasin INNER JOIN SOUS_COMMANDE ON numSousComm = c.numCommande INNER JOIN PRODUIT p ON numProduit = numSousComm INNER JOIN ZONE z ON z.codeZone = p.codeZone inner join PALETTE on p.numProduit = numPalette WHERE libelleZone = '{comboBox1.Text}';";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable; // Vérifiez que le DataGridView s'appelle bien dataGridView1
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

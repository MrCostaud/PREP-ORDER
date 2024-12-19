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
    public partial class tableau_de_bord_racks : Form
    {
        public tableau_de_bord_racks()
        {
            InitializeComponent();
        }

        private SqlConnection db_connect = new SqlConnection("Server=SIO2023-29\\SQLEXPRESS;Database=preporder;Trusted_Connection=True;");

        private void tableau_de_bord_racks_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string query = "select libelleZone, emplacementPalette,libelleProduit, qtLotProduit from PRODUIT PR inner join PALETTE PA on PA.numProduit = PR.numProduit inner join ZONE Z on Z.codeZone = PR.codeZone where substring(emplacementPalette, 6,2) != '00' order by libelleZone, qtLotProduit";

            try
            {
                db_connect.Open();
                using (SqlCommand cmd = new SqlCommand(query, db_connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string[] row = new string[reader.FieldCount];
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[i] = reader[i].ToString();
                            }


                            ListViewItem listViewItem = new ListViewItem(row);
                            listView1.Items.Add(listViewItem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exécution de la requête : " + ex.Message);
            }
            finally
            {
                db_connect.Close();
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form listePalettes = new PREP_ORDER_liste_demandes_palettes();
            listePalettes.Show();
        }
    }
}

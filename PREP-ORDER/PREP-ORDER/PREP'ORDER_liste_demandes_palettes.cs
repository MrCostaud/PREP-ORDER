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
    public partial class PREP_ORDER_liste_demandes_palettes : Form
    {
        public PREP_ORDER_liste_demandes_palettes()
        {
            InitializeComponent();
        }

        private SqlConnection db_connect = new SqlConnection("Server=SIO2023-29\\SQLEXPRESS;Database=preporder;Trusted_Connection=True;");
        private void reloadLV()
        {
            lvPalettes.Items.Clear();
            string query = "select numPalette, libelleProduit, qtLotProduit, libelleZone from PRODUIT PR\r\ninner join PALETTE PA on PA.numProduit = PR.numProduit\r\ninner join ZONE Z on Z.codeZone = PR.codeZone\r\ninner join CARISTE C on C.codeZone = Z.codeZone\r\nwhere substring(emplacementPalette, 6,2) = '00'\r\nand estVide = 1\r\n";

            try
            {
                db_connect.Open();
                comboBox1.Items.Clear();
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
                                if(!comboBox1.Items.Contains(row[0]))
                                {
                                    comboBox1.Items.Add(row[0]);
                                }
                            }


                            ListViewItem listViewItem = new ListViewItem(row);
                            lvPalettes.Items.Add(listViewItem);
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
            lvPalettes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvPalettes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void PREP_ORDER_liste_demandes_palettes_Load(object sender, EventArgs e)
        {
            reloadLV();
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idPalette = comboBox1.Text;
            string qteProduit = numericUpDown1.Value.ToString();
            string query = "update PALETTE set estVide = 0, qtLotProduit = " + qteProduit + "where numPalette = " + idPalette;

            try
            {
                db_connect.Open();
                comboBox1.Items.Clear();
                using (SqlCommand cmd = new SqlCommand(query, db_connect))
                {
                    cmd.ExecuteReader();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exécution de la requête : " + ex.Message);
            }
            finally
            {
                db_connect.Close();
                reloadLV();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}

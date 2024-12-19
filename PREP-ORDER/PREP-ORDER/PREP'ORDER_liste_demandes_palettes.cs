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

        private void PREP_ORDER_liste_demandes_palettes_Load(object sender, EventArgs e)
        {
            lvPalettes.Items.Clear();
            string query = "select libelleProduit, qtLotProduit, libelleZone from PRODUIT PR\r\ninner join PALETTE PA on PA.numProduit = PR.numProduit\r\ninner join ZONE Z on Z.codeZone = PR.codeZone\r\ninner join CARISTE C on C.codeZone = Z.codeZone\r\nwhere substring(emplacementPalette, 6,2) = '00'\r\n";

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
    }
}

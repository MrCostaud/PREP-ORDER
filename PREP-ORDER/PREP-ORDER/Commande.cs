using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PREP_ORDER
{
    internal class Commande
    {
        public static List<(int idMagasin, string nomMagasin, int nombreCommandes)> GetMagasins()
        {
            var magasins = new List<(int idMagasin, string nomMagasin, int nombreCommandes)>();

            // Chaîne de connexion à votre base de données
            string connectionString = Program.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("prc_get_magasin", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idMagasin = Convert.ToInt32(reader["numMagasin"]);
                            string nomMagasin = reader["nomMagasin"].ToString();
                            int nombreCommandes = Convert.ToInt32(reader["nbCommandes"]);

                            magasins.Add((idMagasin, nomMagasin, nombreCommandes));
                        }
                    }
                }
            }

            return magasins;
        }


        public static void AddCommande(int numComm, string nomMag, DateTime dateComm)
        {
            using (SqlConnection connection = new SqlConnection(Program.GetConnectionString()))
            {
                using (SqlCommand command = new SqlCommand("prc_add_commande", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@numCommande", numComm);
                    command.Parameters.AddWithValue("@nomMag", nomMag);
                    command.Parameters.AddWithValue("@dateComm", dateComm);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddSousCommande(int numSousComm, int numComm, string nomMag, string nomPrep)
        {
            using (SqlConnection connection = new SqlConnection(Program.GetConnectionString()))
            {
                using (SqlCommand command = new SqlCommand("prc_add_sous_commande", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idSousComm", numSousComm);
                    command.Parameters.AddWithValue("@idComm", numComm);
                    command.Parameters.AddWithValue("@nomMag", nomMag);
                    command.Parameters.AddWithValue("@nomPrep", nomPrep);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }


        public static int GetNbSousCommandes()
        {
            int nbSousCommandes = 0;

            using (SqlConnection connection = new SqlConnection(Program.GetConnectionString()))
            {
                using (SqlCommand command = new SqlCommand("prc_get_nb_sous_commande", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           nbSousCommandes = Convert.ToInt32(reader["nbSousCommande"]);
                        }
                    }
                }
            }
            return nbSousCommandes;
        }

        public static int GetNbCommandes()
        {
            int nbCommandes = 0;

            using (SqlConnection connection = new SqlConnection(Program.GetConnectionString()))
            {
                using (SqlCommand command = new SqlCommand("prc_get_nb_commandes", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nbCommandes = Convert.ToInt32(reader["nbCommandes"]);
                        }
                    }
                }
            }
            return nbCommandes;
        }

        public static void AddComposer(int numSousComm, string nomProduit, int qtLot)
        {
            using (SqlConnection connection = new SqlConnection(Program.GetConnectionString()))
            {
                using (SqlCommand command = new SqlCommand("prc_add_composer", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@numSousComm", numSousComm);
                    command.Parameters.AddWithValue("@nomProduit", nomProduit);
                    command.Parameters.AddWithValue("@qtLot", qtLot);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

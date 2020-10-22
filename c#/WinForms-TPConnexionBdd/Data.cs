#region Directives using

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

#endregion

namespace WinForms_TPConnexionBdd
{
    public static class Data
    {
        #region Attributs sous forme de propriétés: syntaxe contractée

        public static string UneChaineConnexionBdd { get; set; }

        public static MySqlConnection UneConnexionMySQL { get; set; }

        public static string UneReqSql { get; set; }

        public static MySqlCommand UneCommandeMySql { get; set; }

        public static MySqlDataReader UnMySQLDataReader { get; set; }

        public static User UnUser { get; set; }

        public static List<User> LesUsers { get; set; }

        public static Produit UnProduit { get; set; }

        public static List<Produit> LesProduits { get; set; }

        public static Commande UneCommande { get; set; }

        public static List<Commande> LesCommandes { get; set; }

        public static Article UnArticle { get; set; }

        public static List<Article> LesArticles { get; set; }

        public static Livraison UneLivraison { get; set; }

        public static List<Livraison> LesLivraisons { get; set; }

        #endregion

        #region Méthodes

        /// <summary>
        /// Définit et ouvre la connexion à la base de données
        /// </summary>
        public static void ConnectMySQL()
        {
            // affecter la valeur à la chaine de connexion
            UneChaineConnexionBdd = "Server=127.0.0.1;Database=ppe3;Uid=root;Pwd=;";
            // instancier l'objet connexion
            UneConnexionMySQL = new MySqlConnection(UneChaineConnexionBdd);
            try
            {
                // essaie d'ouvrir la connexion
                UneConnexionMySQL.Open();
                // message de réussite
                MessageBox.Show("Youpi !", "Connexion Bdd MySQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException uneExceptionMySQL)
            {
                // message d'erreur
                MessageBox.Show("PAS Youpi = " + uneExceptionMySQL.Message, "Connexion Bdd MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Users
        /// </summary>


        /// <summary>
        /// Sélectionne tous les users de la base de données
        /// et les charge dans la collection LesUsers
        /// </summary>
        public static void SelectAllUser()
        {
            //
            LesUsers = new List<User>();

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnectMySQL();

            // prépare la requête SQL
            UneReqSql = "select id, username, email from fos_user";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            UnMySQLDataReader = UneCommandeMySql.ExecuteReader();
            if(UnMySQLDataReader.HasRows)
            {
                while(UnMySQLDataReader.Read())
                {
                    UnUser = new User();
                    UnUser.Id = UnMySQLDataReader.GetInt32(0);
                    UnUser.Username = UnMySQLDataReader.GetString(1);
                    UnUser.Email = UnMySQLDataReader.GetString(2);

                    LesUsers.Add(UnUser);
                }
            }
            UnMySQLDataReader.Close();
            UnMySQLDataReader.Dispose();
            
        }

        /// <summary>
        /// Modifie l'user passé en paramètre
        /// </summary>
        /// <param name="pUser"></param>
        /// <returns></returns>
        public static bool UpdateUser(User pUser)
        {
            bool resultSql = false;
            int resultReqSql = 0;

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnectMySQL();

            // prépare la requête SQL
            UneReqSql = "update fos_user set username='" + pUser.Username + "', email='" + pUser.Email + "' where id='" + pUser.Id.ToString() + "';";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            resultReqSql = UneCommandeMySql.ExecuteNonQuery();

            if (resultReqSql > 0)
            {
                resultSql = true;
            }
            else
            {
                resultSql = false;
            }

            return resultSql;
        }

        /// <summary>
        /// Produit
        /// </summary> 
        
        /// <summary>
        /// Insère un nouvel produit dans la base de données
        /// </summary>
        /// <param name="pProduit"></param>
        /// <returns></returns>
        public static bool CreateProduit(Produit pProduit)
        {
            bool resultSql = false;
            int resultReqSql = 0;

            // select id from produit order by id DESC limit 1

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnectMySQL();
            // recuperer le dernier id 

            // lui ajouter 1

            // prépare la requête SQL
            UneReqSql = "insert into produit (titre, description, prix, image, categorie_produit_id) values ("
                        + "'" + pProduit.Titre + "',"
                        + "'" + pProduit.Description + "',"
                        + "'" + pProduit.Prix + "',"
                        + "'" + pProduit.Image + "',"
                        + "'" + pProduit.Categorie + "')";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            resultReqSql = UneCommandeMySql.ExecuteNonQuery();

            if (resultReqSql > 0)
            {
                resultSql = true;
            }
            else
            {
                resultSql = false;
            }

            return resultSql;
        }


        /// <summary>
        /// Sélectionne tous les produits de la base de données
        /// et les charge dans la collection LesProduits
        /// </summary>
        public static void SelectAllProduit()
        {
            //
            LesProduits = new List<Produit>();

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnectMySQL();

            // prépare la requête SQL
            UneReqSql = "select id, titre, description, prix, image, categorie_produit_id from produit";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            UnMySQLDataReader = UneCommandeMySql.ExecuteReader();
            if (UnMySQLDataReader.HasRows)
            {
                while (UnMySQLDataReader.Read())
                {
                    UnProduit = new Produit();
                    UnProduit.Id = UnMySQLDataReader.GetInt32(0);
                    UnProduit.Titre = UnMySQLDataReader.GetString(1);
                    UnProduit.Description = UnMySQLDataReader.GetString(2);
                    UnProduit.Prix = UnMySQLDataReader.GetString(3);
                    UnProduit.Image = UnMySQLDataReader.GetString(4);
                    UnProduit.Categorie = UnMySQLDataReader.GetString(5);

                    LesProduits.Add(UnProduit);
                }
            }
            UnMySQLDataReader.Close();
            UnMySQLDataReader.Dispose();

        }

        internal static bool DeleteProduit(Produit unProduit)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modifie le produit passé en paramètre
        /// </summary>
        /// <param name="pProduit"></param>
        /// <returns></returns>
        public static bool UpdateProduit(Produit pProduit)
        {
            bool resultSql = false;
            int resultReqSql = 0;

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnectMySQL();

            // prépare la requête SQL
            UneReqSql = "update produit set titre='" + pProduit.Titre + "', description='" + pProduit.Description + "', prix='" + pProduit.Prix + "', image='" + pProduit.Image + "', categorie_produit_id='" + pProduit.Categorie + "' where id='" + pProduit.Id.ToString() + "';";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            resultReqSql = UneCommandeMySql.ExecuteNonQuery();

            if (resultReqSql > 0)
            {
                resultSql = true;
            }
            else
            {
                resultSql = false;
            }

            return resultSql;
        }

        /// <summary>
        /// Supprime un enregistrement produit
        /// </summary>
        /// <param name="pProduit"></param>
        public static bool DeleteProduit(User pProduit)
        {
            bool resultSql = false;
            int resultReqSql = 0;

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnectMySQL();

            // prépare la requête SQL
            UneReqSql = "delete from produit where id='" + pProduit.Id + "';";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            resultReqSql = UneCommandeMySql.ExecuteNonQuery();

            if (resultReqSql > 0)
            {
                resultSql = true;
            }
            else
            {
                resultSql = false;
            }

            return resultSql;
        }

        /// <summary>
        /// Commande
        /// </summary>

        /// <summary>
        /// Sélectionne tous les commandes de la base de données
        /// et les charge dans la collection LesCommandes
        /// </summary>
        public static void SelectAllCommande()
        {
            //
            LesCommandes = new List<Commande>();

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnectMySQL();

            // prépare la requête SQL
            UneReqSql = "select id, reference, status, date, livraison_id from commande_order";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            UnMySQLDataReader = UneCommandeMySql.ExecuteReader();
            if (UnMySQLDataReader.HasRows)
            {
                while (UnMySQLDataReader.Read())
                {
                    UneCommande = new Commande();
                    UneCommande.Id = UnMySQLDataReader.GetInt32(0);
                    UneCommande.Reference = UnMySQLDataReader.GetString(1);
                    UneCommande.Status = UnMySQLDataReader.GetString(2);
                    UneCommande.Date = UnMySQLDataReader.GetString(3);
                    UneCommande.Livraison = UnMySQLDataReader.GetString(4);

                    LesCommandes.Add(UneCommande);
                }
            }
            UnMySQLDataReader.Close();
            UnMySQLDataReader.Dispose();

        }

        /// <summary>
        /// Modifie l'user passé en paramètre
        /// </summary>
        /// <param name="pCommande"></param>
        /// <returns></returns>
        public static bool UpdateCommande(Commande pCommande)
        {
            bool resultSql = false;
            int resultReqSql = 0;

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnectMySQL();

            // prépare la requête SQL
            UneReqSql = "update commande_order set reference='" + pCommande.Reference + "', status='" + pCommande.Status + "' where id='" + pCommande.Id.ToString() + "';";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            resultReqSql = UneCommandeMySql.ExecuteNonQuery();

            if (resultReqSql > 0)
            {
                resultSql = true;
            }
            else
            {
                resultSql = false;
            }

            return resultSql;
        }
        /// <summary>
        /// Article
        /// </summary>

        /// <summary>
        /// Sélectionne tous les commandes de la base de données
        /// et les charge dans la collection LesCommandes
        /// </summary>
        public static void SelectAllArticle()
        {
            //
            LesArticles = new List<Article>();

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnectMySQL();

            // prépare la requête SQL
            UneReqSql = "select commande_order_id, produit_id from commande_order_produit";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            UnMySQLDataReader = UneCommandeMySql.ExecuteReader();
            if (UnMySQLDataReader.HasRows)
            {
                while (UnMySQLDataReader.Read())
                {
                    UnArticle = new Article();
                    UnArticle.CommandeOrder = UnMySQLDataReader.GetInt32(0);
                    UnArticle.Produit = UnMySQLDataReader.GetInt32(1);

                    LesArticles.Add(UnArticle);
                }
            }
            UnMySQLDataReader.Close();
            UnMySQLDataReader.Dispose();

        }
        /// <summary>
        /// Livraison
        /// </summary>

        /// <summary>
        /// Sélectionne tous les commandes de la base de données
        /// et les charge dans la collection LesCommandes
        /// </summary>
        public static void SelectAllLivraison()
        {
            //
            LesLivraisons = new List<Livraison>();

            // teste l'existence de l'objet UneConnexionMySQL
            if (UneConnexionMySQL == null)
                ConnectMySQL();

            // prépare la requête SQL
            UneReqSql = "select id, adresse, code_postal, ville, pays from livraison_order";

            UneCommandeMySql = new MySqlCommand(UneReqSql, UneConnexionMySQL);

            // exécute la requête SQL
            UnMySQLDataReader = UneCommandeMySql.ExecuteReader();
            if (UnMySQLDataReader.HasRows)
            {
                while (UnMySQLDataReader.Read())
                {
                    UneLivraison = new Livraison();
                    UneLivraison.Id = UnMySQLDataReader.GetInt32(0);
                    UneLivraison.Adresse = UnMySQLDataReader.GetString(1);
                    UneLivraison.CP = UnMySQLDataReader.GetString(2);
                    UneLivraison.Ville = UnMySQLDataReader.GetString(3);
                    UneLivraison.Pays = UnMySQLDataReader.GetString(4);

                    LesLivraisons.Add(UneLivraison);
                }
            }
            UnMySQLDataReader.Close();
            UnMySQLDataReader.Dispose();

        }

        #endregion

    }
}

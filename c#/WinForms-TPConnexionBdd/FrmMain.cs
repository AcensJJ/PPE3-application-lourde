using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinForms_TPConnexionBdd
{
    public partial class FrmMain : Form
    {
        private User unUser;
        private Produit unProduit;
        private Commande uneCommande;
        private Livraison uneLivraison;
        private Article unArticle;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnConnecterMySQL_Click(object sender, EventArgs e)
        {
            Data.ConnectMySQL();
        }

        private void btnAfficherDataGridView_Click(object sender, EventArgs e)
        {
            //
            string[] uneRow = new string[3];

            // efface le contenu du DataGridView
            dgvLesUsers.Rows.Clear();

            // select all dans la base de données
            Data.SelectAllUser();

            // parcours la collection
            foreach(User unUser in Data.LesUsers)
            {
                uneRow[0] = unUser.Id.ToString();
                uneRow[1] = unUser.Username;
                uneRow[2] = unUser.Email;
                dgvLesUsers.Rows.Add(uneRow);
            }
        }

        /// <summary>
        /// Sélection d'1 ligne par un simple clic pour supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvLesUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // récupère l'objet User sélectionné
            unUser = new User();
            unUser.Id = Convert.ToInt32(dgvLesUsers.CurrentRow.Cells[0].Value);
            unUser.Username = dgvLesUsers.CurrentRow.Cells[1].Value.ToString();
            unUser.Email = dgvLesUsers.CurrentRow.Cells[2].Value.ToString();
        }

        /// <summary>
        /// Sélection d'1 ligne par un double clic pour envoyer les données dans le formulaire de modification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvLesUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        /// <summary>
        /// Enregistre la modification d'un enregistrement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierUser_Click(object sender, EventArgs e)
        {
            // teste s'il y a une valeur d'Id
            if (!String.IsNullOrEmpty(txtModifierid.Text))
            {
                unUser = new User();
                unUser.Id = Convert.ToInt32(txtModifierid.Text);
                unUser.Username = txtModifierUsernameUser.Text;
                unUser.Email = txtModifierEmailUser.Text;

                bool resultUpdate = Data.UpdateUser(unUser);

                if (resultUpdate)
                {
                    MessageBox.Show("User modifié avec succès.", "Modifier user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Echec de modification de l'user.", "Modifier user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvLesUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // récupère l'objet User sélectionné
            unUser = new User();
            unUser.Id = Convert.ToInt32(dgvLesUsers.CurrentRow.Cells[0].Value);
            unUser.Username = dgvLesUsers.CurrentRow.Cells[1].Value.ToString();
            unUser.Email = dgvLesUsers.CurrentRow.Cells[2].Value.ToString();

            // affiche les valeurs dans les txtBox de modification
            txtModifierid.Text = unUser.Id.ToString();
            txtModifierUsernameUser.Text = unUser.Username;
            txtModifierEmailUser.Text = unUser.Email;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void tabProduit_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            unProduit = new Produit();
            unProduit.Titre = txtTitreProduit.Text;
            unProduit.Description = txtDescriptionProduit.Text;
            unProduit.Prix = txtPrixProduit.Text;
            unProduit.Image = txtImageProduit.Text;
            unProduit.Categorie = txtCategorieProduit.Text;

            bool resultCreate = Data.CreateProduit(unProduit);

            if (resultCreate)
            {
                MessageBox.Show("Nouveau produit ajouté avec succès.", "Ajout nouveau produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Echec de création du nouveau produit.", "Ajout nouveau produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreerNouveauProduit_Click(object sender, EventArgs e)
        {
            unProduit = new Produit();
            unProduit.Titre = txtTitreProduit.Text;
            unProduit.Description = txtDescriptionProduit.Text;
            unProduit.Prix = txtPrixProduit.Text;
            unProduit.Image = txtImageProduit.Text;
            unProduit.Categorie = txtCategorieProduit.Text;

            bool resultCreate = Data.CreateProduit(unProduit);

            if (resultCreate)
            {
                MessageBox.Show("Nouveau produit ajouté avec succès.", "Ajout nouveau produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Echec de création du nouveau produit.", "Ajout nouveau produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //
            string[] uneRow = new string[6];

            // efface le contenu du DataGridView
            dgvLesProduits.Rows.Clear();

            // select all dans la base de données
            Data.SelectAllProduit();

            // parcours la collection
            foreach (Produit unProduit in Data.LesProduits)
            {
                uneRow[0] = unProduit.Id.ToString();
                uneRow[1] = unProduit.Titre;
                uneRow[2] = unProduit.Description;
                uneRow[3] = unProduit.Prix;
                uneRow[4] = unProduit.Image;
                uneRow[5] = unProduit.Categorie;
                dgvLesProduits.Rows.Add(uneRow);
            }
        }

        private void btnAfficherDataGridViewProduit_Click(object sender, EventArgs e)
        {
            //
            string[] uneRow = new string[6];

            // efface le contenu du DataGridView
            dgvLesProduits.Rows.Clear();

            // select all dans la base de données
            Data.SelectAllProduit();

            // parcours la collection
            foreach (Produit unProduit in Data.LesProduits)
            {
                uneRow[0] = unProduit.Id.ToString();
                uneRow[1] = unProduit.Titre;
                uneRow[2] = unProduit.Description;
                uneRow[3] = unProduit.Prix;
                uneRow[4] = unProduit.Image;
                uneRow[5] = unProduit.Categorie;
                dgvLesProduits.Rows.Add(uneRow);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool resultDelete = Data.DeleteProduit(unProduit);

            if (resultDelete)
            {
                MessageBox.Show("Produit supprimé avec succès.", "Supprimer produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Echec de suppression du produit.", "Supprimer produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimerProduit_Click(object sender, EventArgs e)
        {
            bool resultDelete = Data.DeleteProduit(unProduit);

            if (resultDelete)
            {
                MessageBox.Show("Produit supprimé avec succès.", "Supprimer produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Echec de suppression du produit.", "Supprimer produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Enregistre la modification d'un enregistrement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // teste s'il y a une valeur d'Id
            if (!String.IsNullOrEmpty(txtModifierIdProduit.Text))
            {
                unProduit = new Produit();
                unProduit.Id = Convert.ToInt32(txtModifierIdProduit.Text);
                unProduit.Titre = txtModifierTitreProduit.Text;
                unProduit.Description = txtModifierDescriptionProduit.Text;
                unProduit.Prix = txtModifierPrixProduit.Text;
                unProduit.Image = txtModifierImageProduit.Text;
                unProduit.Categorie = txtModifierCategorieProduit.Text;

                bool resultUpdate = Data.UpdateProduit(unProduit);

                if (resultUpdate)
                {
                    MessageBox.Show("Produit modifié avec succès.", "Modifier produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Echec de modification du produit.", "Modifier produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Enregistre la modification d'un enregistrement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierProduit_Click(object sender, EventArgs e)
        {
            // teste s'il y a une valeur d'Id
            if (!String.IsNullOrEmpty(txtModifierIdProduit.Text))
            {
                unProduit = new Produit();
                unProduit.Id = Convert.ToInt32(txtModifierIdProduit.Text);
                unProduit.Titre = txtModifierTitreProduit.Text;
                unProduit.Description = txtModifierDescriptionProduit.Text;
                unProduit.Prix = txtModifierPrixProduit.Text;
                unProduit.Image = txtModifierImageProduit.Text;
                unProduit.Categorie = txtModifierCategorieProduit.Text;

                bool resultUpdate = Data.UpdateProduit(unProduit);

                if (resultUpdate)
                {
                    MessageBox.Show("Produit modifié avec succès.", "Modifier produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Echec de modification du produit.", "Modifier produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Sélection d'1 ligne par un simple clic pour supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvLesProduits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // récupère l'objet Etudiant sélectionné
            unProduit = new Produit();
            unProduit.Id = Convert.ToInt32(dgvLesProduits.CurrentRow.Cells[0].Value);
            unProduit.Titre = dgvLesProduits.CurrentRow.Cells[1].Value.ToString();
            unProduit.Description = dgvLesProduits.CurrentRow.Cells[2].Value.ToString();
            unProduit.Prix = dgvLesProduits.CurrentRow.Cells[3].Value.ToString();
            unProduit.Image = dgvLesProduits.CurrentRow.Cells[4].Value.ToString();
            unProduit.Categorie = dgvLesProduits.CurrentRow.Cells[5].Value.ToString();
        }

        /// <summary>
        /// Sélection d'1 ligne par un double clic pour envoyer les données dans le formulaire de modification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvLesProduits_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLesProduits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // récupère l'objet Produit sélectionné
            unProduit = new Produit();
            unProduit.Id = Convert.ToInt32(dgvLesProduits.CurrentRow.Cells[0].Value);
            unProduit.Titre = dgvLesProduits.CurrentRow.Cells[1].Value.ToString();
            unProduit.Description = dgvLesProduits.CurrentRow.Cells[2].Value.ToString();
            unProduit.Prix = dgvLesProduits.CurrentRow.Cells[3].Value.ToString();
            unProduit.Image = dgvLesProduits.CurrentRow.Cells[4].Value.ToString();
            unProduit.Categorie = dgvLesProduits.CurrentRow.Cells[5].Value.ToString();

            // affiche les valeurs dans les txtBox de modification
            txtModifierIdProduit.Text = unProduit.Id.ToString();
            txtModifierTitreProduit.Text = unProduit.Titre;
            txtModifierDescriptionProduit.Text = unProduit.Description;
            txtModifierPrixProduit.Text = unProduit.Prix;
            txtModifierImageProduit.Text = unProduit.Image;
            txtModifierCategorieProduit.Text = unProduit.Categorie;
        }

        private void btnAfficherDataGridViewCommande_Click(object sender, EventArgs e)
        {
            //
            string[] uneRow = new string[5];

            // efface le contenu du DataGridView
            dgvLesCommandes.Rows.Clear();

            // select all dans la base de données
            Data.SelectAllCommande();

            // parcours la collection
            foreach (Commande uneCommande in Data.LesCommandes)
            {
                uneRow[0] = uneCommande.Id.ToString();
                uneRow[1] = uneCommande.Reference;
                uneRow[2] = uneCommande.Status;
                uneRow[3] = uneCommande.Date;
                uneRow[4] = uneCommande.Livraison;
                dgvLesCommandes.Rows.Add(uneRow);
            }
        }

        /// <summary>
        /// Enregistre la modification d'un enregistrement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierCommande_Click(object sender, EventArgs e)
        {
            // teste s'il y a une valeur d'Id
            if (!String.IsNullOrEmpty(txtModifierIdCommande.Text))
            {
                uneCommande = new Commande();
                uneCommande.Id = Convert.ToInt32(txtModifierIdCommande.Text);
                uneCommande.Reference = txtModifierReferenceCommande.Text;
                uneCommande.Status = txtModifierStatusCommande.Text;
                uneCommande.Date = txtModifierDateCommande.Text;

                bool resultUpdate = Data.UpdateCommande(uneCommande);

                if (resultUpdate)
                {
                    MessageBox.Show("Commande modifié avec succès.", "Modifier commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Echec de modification de la commande.", "Modifier commande", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Sélection d'1 ligne par un simple clic pour supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvLesCommandes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // récupère l'objet Etudiant sélectionné
            uneCommande = new Commande();
            uneCommande.Id = Convert.ToInt32(dgvLesCommandes.CurrentRow.Cells[0].Value);
            uneCommande.Reference = dgvLesCommandes.CurrentRow.Cells[1].Value.ToString();
            uneCommande.Status = dgvLesCommandes.CurrentRow.Cells[2].Value.ToString();
            uneCommande.Date = dgvLesCommandes.CurrentRow.Cells[3].Value.ToString();
        }

        /// <summary>
        /// Sélection d'1 ligne par un double clic pour envoyer les données dans le formulaire de modification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvLesCommandes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLesCommandes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // récupère l'objet Commande sélectionné
            uneCommande = new Commande();
            uneCommande.Id = Convert.ToInt32(dgvLesCommandes.CurrentRow.Cells[0].Value);
            uneCommande.Reference = dgvLesCommandes.CurrentRow.Cells[1].Value.ToString();
            uneCommande.Status = dgvLesCommandes.CurrentRow.Cells[2].Value.ToString();
            uneCommande.Date = dgvLesCommandes.CurrentRow.Cells[3].Value.ToString();

            // affiche les valeurs dans les txtBox de modification
            txtModifierIdCommande.Text = uneCommande.Id.ToString();
            txtModifierReferenceCommande.Text = uneCommande.Reference;
            txtModifierStatusCommande.Text = uneCommande.Status;
            txtModifierDateCommande.Text = uneCommande.Date;
        }

        private void txtModifierDateCommande_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void tabUser_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //
            string[] uneRow = new string[2];

            // efface le contenu du DataGridView
            dgvLesArticles.Rows.Clear();

            // select all dans la base de données
            Data.SelectAllArticle();

            // parcours la collection
            foreach (Article unArticle in Data.LesArticles)
            {
                uneRow[0] = unArticle.CommandeOrder.ToString();
                uneRow[1] = unArticle.Produit.ToString();
                dgvLesArticles.Rows.Add(uneRow);
            }
        }

        private void dgvLesArticles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //
            string[] uneRow = new string[5];

            // efface le contenu du DataGridView
            dgvLesLivraisons.Rows.Clear();

            // select all dans la base de données
            Data.SelectAllLivraison();

            // parcours la collection
            foreach (Livraison uneLivraison in Data.LesLivraisons)
            {
                uneRow[0] = uneLivraison.Id.ToString();
                uneRow[1] = uneLivraison.Adresse;
                uneRow[2] = uneLivraison.CP;
                uneRow[3] = uneLivraison.Ville;
                uneRow[4] = uneLivraison.Pays;
                dgvLesLivraisons.Rows.Add(uneRow);
            }
        }
    }
}

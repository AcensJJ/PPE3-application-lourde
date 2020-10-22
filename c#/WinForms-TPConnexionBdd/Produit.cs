#region Directives using

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace WinForms_TPConnexionBdd
{
    public class Produit
    {
        #region Attributs

        private int id;
        private string titre;
        private string description;
        private string prix;
        private string image;
        private string categorie_produit_id;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Produit()
        { }

        #endregion

        #region Accesseurs sous forme de propriétés

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Titre
        {
            get { return this.titre; }
            set { this.titre = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public string Prix
        {
            get { return this.prix; }
            set { this.prix = value; }
        }

        public string Image
        {
            get { return this.image; }
            set { this.image = value; }
        }

        public string Categorie
        {
            get { return this.categorie_produit_id; }
            set { this.categorie_produit_id = value; }
        }

        #endregion
    }
}

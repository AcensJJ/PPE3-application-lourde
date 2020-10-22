using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_TPConnexionBdd
{
    public class Livraison
    {
        #region Attributs

        private int id;
        private string adresse;
        private string code_postal;
        private string ville;
        private string pays;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Livraison()
        { }

        #endregion

        #region Accesseurs sous forme de propriétés

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Adresse
        {
            get { return this.adresse; }
            set { this.adresse = value; }
        }

        public string CP
        {
            get { return this.code_postal; }
            set { this.code_postal = value; }
        }

        public string Ville
        {
            get { return this.ville; }
            set { this.ville = value; }
        }

        public string Pays
        {
            get { return this.pays; }
            set { this.pays = value; }
        }

        #endregion
    }
}

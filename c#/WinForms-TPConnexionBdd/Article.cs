using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_TPConnexionBdd
{
    public class Article
    {
        #region Attributs

        private int commande_order_id;
        private int produit_id;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Article()
        { }

        #endregion

        #region Accesseurs sous forme de propriétés

        public int CommandeOrder
        {
            get { return this.commande_order_id; }
            set { this.commande_order_id = value; }
        }

        public int Produit
        {
            get { return this.produit_id; }
            set { this.produit_id = value; }
        }

        #endregion
    }
}

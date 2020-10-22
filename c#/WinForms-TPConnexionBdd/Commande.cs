#region Directives using

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion


namespace WinForms_TPConnexionBdd
{
    public class Commande
    {
        #region Attributs

        private int id;
        private string reference;
        private string status;
        private string date;
        private string livraison_id;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Commande()
        { }

        #endregion

        #region Accesseurs sous forme de propriétés

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Reference
        {
            get { return this.reference; }
            set { this.reference = value; }
        }

        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public string Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string Livraison
        {
            get { return this.livraison_id; }
            set { this.livraison_id = value; }
        }

        #endregion
    }
}

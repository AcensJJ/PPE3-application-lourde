#region Directives using

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace WinForms_TPConnexionBdd
{
    public class User
    {
        #region Attributs

        private int id;
        private string username;
        private string email;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public User()
        { }

        #endregion

        #region Accesseurs sous forme de propriétés

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        #endregion
    }
}

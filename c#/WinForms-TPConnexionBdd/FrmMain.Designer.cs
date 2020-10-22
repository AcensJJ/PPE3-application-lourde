namespace WinForms_TPConnexionBdd
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnecterMySQL = new System.Windows.Forms.Button();
            this.dgvLesUsers = new System.Windows.Forms.DataGridView();
            this.idUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAfficherDataGridView = new System.Windows.Forms.Button();
            this.btnModifierUser = new System.Windows.Forms.Button();
            this.txtModifierEmailUser = new System.Windows.Forms.TextBox();
            this.txtModifierUsernameUser = new System.Windows.Forms.TextBox();
            this.lblModifierEmailUser = new System.Windows.Forms.Label();
            this.lblModifierUsernameUser = new System.Windows.Forms.Label();
            this.lblModifierid = new System.Windows.Forms.Label();
            this.txtModifierid = new System.Windows.Forms.TextBox();
            this.dgvLesAdresses = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.tabProduit = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtModifierPrixProduit = new System.Windows.Forms.TextBox();
            this.txtModifierCategorieProduit = new System.Windows.Forms.TextBox();
            this.txtModifierImageProduit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCategorieProduit = new System.Windows.Forms.TextBox();
            this.txtImageProduit = new System.Windows.Forms.TextBox();
            this.txtPrixProduit = new System.Windows.Forms.TextBox();
            this.dgvLesProduits = new System.Windows.Forms.DataGridView();
            this.idProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitreProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategorieProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModifierEtudiant = new System.Windows.Forms.Button();
            this.btnSupprimerEtudiant = new System.Windows.Forms.Button();
            this.txtModifierDescriptionProduit = new System.Windows.Forms.TextBox();
            this.txtModifierTitreProduit = new System.Windows.Forms.TextBox();
            this.btnAfficherDataGridViewProduit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdProduit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModifierIdProduit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreerNouveauProduit = new System.Windows.Forms.Button();
            this.txtTitreProduit = new System.Windows.Forms.TextBox();
            this.txtDescriptionProduit = new System.Windows.Forms.TextBox();
            this.tabCommande = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.txtModifierDateCommande = new System.Windows.Forms.TextBox();
            this.txtModifierStatusCommande = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dgvLesCommandes = new System.Windows.Forms.DataGridView();
            this.btnModifierCommande = new System.Windows.Forms.Button();
            this.txtModifierReferenceCommande = new System.Windows.Forms.TextBox();
            this.btnAfficherDataGridViewCommande = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtModifierIdCommande = new System.Windows.Forms.TextBox();
            this.tabArticleCommande = new System.Windows.Forms.TabPage();
            this.tabAdresseLivraison = new System.Windows.Forms.TabPage();
            this.dgvLesArticles = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvLesLivraisons = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefenreceCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresseLivraisonCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommandeArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProduitArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesUsers)).BeginInit();
            this.dgvLesAdresses.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.tabProduit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesProduits)).BeginInit();
            this.tabCommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesCommandes)).BeginInit();
            this.tabArticleCommande.SuspendLayout();
            this.tabAdresseLivraison.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesLivraisons)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnecterMySQL
            // 
            this.btnConnecterMySQL.Location = new System.Drawing.Point(711, 355);
            this.btnConnecterMySQL.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnecterMySQL.Name = "btnConnecterMySQL";
            this.btnConnecterMySQL.Size = new System.Drawing.Size(100, 47);
            this.btnConnecterMySQL.TabIndex = 0;
            this.btnConnecterMySQL.Text = "Connecter MySQL";
            this.btnConnecterMySQL.UseVisualStyleBackColor = true;
            this.btnConnecterMySQL.Click += new System.EventHandler(this.btnConnecterMySQL_Click);
            // 
            // dgvLesUsers
            // 
            this.dgvLesUsers.AllowUserToAddRows = false;
            this.dgvLesUsers.AllowUserToDeleteRows = false;
            this.dgvLesUsers.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvLesUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLesUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUser,
            this.UsernameUser,
            this.EmailUser});
            this.dgvLesUsers.Location = new System.Drawing.Point(314, 19);
            this.dgvLesUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLesUsers.Name = "dgvLesUsers";
            this.dgvLesUsers.ReadOnly = true;
            this.dgvLesUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLesUsers.Size = new System.Drawing.Size(497, 185);
            this.dgvLesUsers.TabIndex = 8;
            this.dgvLesUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLesUsers_CellContentClick);
            this.dgvLesUsers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLesUsers_CellContentDoubleClick);
            this.dgvLesUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLesUsers_CellDoubleClick);
            // 
            // idUser
            // 
            this.idUser.HeaderText = "id";
            this.idUser.Name = "idUser";
            this.idUser.ReadOnly = true;
            // 
            // UsernameUser
            // 
            this.UsernameUser.HeaderText = "Username";
            this.UsernameUser.Name = "UsernameUser";
            this.UsernameUser.ReadOnly = true;
            this.UsernameUser.Width = 179;
            // 
            // EmailUser
            // 
            this.EmailUser.HeaderText = "Email";
            this.EmailUser.Name = "EmailUser";
            this.EmailUser.ReadOnly = true;
            this.EmailUser.Width = 175;
            // 
            // btnAfficherDataGridView
            // 
            this.btnAfficherDataGridView.Location = new System.Drawing.Point(710, 224);
            this.btnAfficherDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfficherDataGridView.Name = "btnAfficherDataGridView";
            this.btnAfficherDataGridView.Size = new System.Drawing.Size(100, 46);
            this.btnAfficherDataGridView.TabIndex = 9;
            this.btnAfficherDataGridView.Text = "Rafraîchir";
            this.btnAfficherDataGridView.UseVisualStyleBackColor = true;
            this.btnAfficherDataGridView.Click += new System.EventHandler(this.btnAfficherDataGridView_Click);
            // 
            // btnModifierUser
            // 
            this.btnModifierUser.Location = new System.Drawing.Point(171, 133);
            this.btnModifierUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierUser.Name = "btnModifierUser";
            this.btnModifierUser.Size = new System.Drawing.Size(100, 42);
            this.btnModifierUser.TabIndex = 16;
            this.btnModifierUser.Text = "Modifier user";
            this.btnModifierUser.UseVisualStyleBackColor = true;
            this.btnModifierUser.Click += new System.EventHandler(this.btnModifierUser_Click);
            // 
            // txtModifierEmailUser
            // 
            this.txtModifierEmailUser.Location = new System.Drawing.Point(139, 100);
            this.txtModifierEmailUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifierEmailUser.Name = "txtModifierEmailUser";
            this.txtModifierEmailUser.Size = new System.Drawing.Size(132, 25);
            this.txtModifierEmailUser.TabIndex = 15;
            // 
            // txtModifierUsernameUser
            // 
            this.txtModifierUsernameUser.Location = new System.Drawing.Point(139, 68);
            this.txtModifierUsernameUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifierUsernameUser.Name = "txtModifierUsernameUser";
            this.txtModifierUsernameUser.Size = new System.Drawing.Size(132, 25);
            this.txtModifierUsernameUser.TabIndex = 14;
            // 
            // lblModifierEmailUser
            // 
            this.lblModifierEmailUser.AutoSize = true;
            this.lblModifierEmailUser.Location = new System.Drawing.Point(31, 104);
            this.lblModifierEmailUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModifierEmailUser.Name = "lblModifierEmailUser";
            this.lblModifierEmailUser.Size = new System.Drawing.Size(41, 19);
            this.lblModifierEmailUser.TabIndex = 13;
            this.lblModifierEmailUser.Text = "Email";
            // 
            // lblModifierUsernameUser
            // 
            this.lblModifierUsernameUser.AutoSize = true;
            this.lblModifierUsernameUser.Location = new System.Drawing.Point(31, 72);
            this.lblModifierUsernameUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModifierUsernameUser.Name = "lblModifierUsernameUser";
            this.lblModifierUsernameUser.Size = new System.Drawing.Size(71, 19);
            this.lblModifierUsernameUser.TabIndex = 12;
            this.lblModifierUsernameUser.Text = "Username";
            // 
            // lblModifierid
            // 
            this.lblModifierid.AutoSize = true;
            this.lblModifierid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblModifierid.Location = new System.Drawing.Point(31, 40);
            this.lblModifierid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModifierid.Name = "lblModifierid";
            this.lblModifierid.Size = new System.Drawing.Size(21, 19);
            this.lblModifierid.TabIndex = 11;
            this.lblModifierid.Text = "Id";
            // 
            // txtModifierid
            // 
            this.txtModifierid.Location = new System.Drawing.Point(139, 36);
            this.txtModifierid.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifierid.Name = "txtModifierid";
            this.txtModifierid.ReadOnly = true;
            this.txtModifierid.Size = new System.Drawing.Size(132, 25);
            this.txtModifierid.TabIndex = 10;
            // 
            // dgvLesAdresses
            // 
            this.dgvLesAdresses.Controls.Add(this.tabUser);
            this.dgvLesAdresses.Controls.Add(this.tabProduit);
            this.dgvLesAdresses.Controls.Add(this.tabCommande);
            this.dgvLesAdresses.Controls.Add(this.tabArticleCommande);
            this.dgvLesAdresses.Controls.Add(this.tabAdresseLivraison);
            this.dgvLesAdresses.Location = new System.Drawing.Point(12, 12);
            this.dgvLesAdresses.Name = "dgvLesAdresses";
            this.dgvLesAdresses.SelectedIndex = 0;
            this.dgvLesAdresses.Size = new System.Drawing.Size(851, 450);
            this.dgvLesAdresses.TabIndex = 18;
            // 
            // tabUser
            // 
            this.tabUser.BackColor = System.Drawing.Color.Linen;
            this.tabUser.Controls.Add(this.label18);
            this.tabUser.Controls.Add(this.dgvLesUsers);
            this.tabUser.Controls.Add(this.btnModifierUser);
            this.tabUser.Controls.Add(this.txtModifierEmailUser);
            this.tabUser.Controls.Add(this.btnConnecterMySQL);
            this.tabUser.Controls.Add(this.txtModifierUsernameUser);
            this.tabUser.Controls.Add(this.btnAfficherDataGridView);
            this.tabUser.Controls.Add(this.lblModifierEmailUser);
            this.tabUser.Controls.Add(this.lblModifierUsernameUser);
            this.tabUser.Controls.Add(this.lblModifierid);
            this.tabUser.Controls.Add(this.txtModifierid);
            this.tabUser.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabUser.Location = new System.Drawing.Point(4, 25);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(843, 421);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "User";
            this.tabUser.Click += new System.EventHandler(this.tabUser_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label18.Location = new System.Drawing.Point(31, 10);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(144, 19);
            this.label18.TabIndex = 49;
            this.label18.Text = "Modifier un utilisateur";
            // 
            // tabProduit
            // 
            this.tabProduit.BackColor = System.Drawing.Color.Linen;
            this.tabProduit.Controls.Add(this.label16);
            this.tabProduit.Controls.Add(this.label7);
            this.tabProduit.Controls.Add(this.label13);
            this.tabProduit.Controls.Add(this.label14);
            this.tabProduit.Controls.Add(this.label15);
            this.tabProduit.Controls.Add(this.txtModifierPrixProduit);
            this.tabProduit.Controls.Add(this.txtModifierCategorieProduit);
            this.tabProduit.Controls.Add(this.txtModifierImageProduit);
            this.tabProduit.Controls.Add(this.label12);
            this.tabProduit.Controls.Add(this.label11);
            this.tabProduit.Controls.Add(this.label8);
            this.tabProduit.Controls.Add(this.txtCategorieProduit);
            this.tabProduit.Controls.Add(this.txtImageProduit);
            this.tabProduit.Controls.Add(this.txtPrixProduit);
            this.tabProduit.Controls.Add(this.dgvLesProduits);
            this.tabProduit.Controls.Add(this.btnModifierEtudiant);
            this.tabProduit.Controls.Add(this.btnSupprimerEtudiant);
            this.tabProduit.Controls.Add(this.txtModifierDescriptionProduit);
            this.tabProduit.Controls.Add(this.txtModifierTitreProduit);
            this.tabProduit.Controls.Add(this.btnAfficherDataGridViewProduit);
            this.tabProduit.Controls.Add(this.label1);
            this.tabProduit.Controls.Add(this.label2);
            this.tabProduit.Controls.Add(this.label3);
            this.tabProduit.Controls.Add(this.txtIdProduit);
            this.tabProduit.Controls.Add(this.label4);
            this.tabProduit.Controls.Add(this.label5);
            this.tabProduit.Controls.Add(this.txtModifierIdProduit);
            this.tabProduit.Controls.Add(this.label6);
            this.tabProduit.Controls.Add(this.btnCreerNouveauProduit);
            this.tabProduit.Controls.Add(this.txtTitreProduit);
            this.tabProduit.Controls.Add(this.txtDescriptionProduit);
            this.tabProduit.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F);
            this.tabProduit.Location = new System.Drawing.Point(4, 25);
            this.tabProduit.Name = "tabProduit";
            this.tabProduit.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduit.Size = new System.Drawing.Size(843, 421);
            this.tabProduit.TabIndex = 1;
            this.tabProduit.Text = "Produit";
            this.tabProduit.Click += new System.EventHandler(this.tabProduit_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label16.Location = new System.Drawing.Point(31, 10);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 19);
            this.label16.TabIndex = 49;
            this.label16.Text = "Créer un produit";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(31, 287);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 19);
            this.label7.TabIndex = 48;
            this.label7.Text = "Modifier un produit";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(311, 387);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 19);
            this.label13.TabIndex = 47;
            this.label13.Text = "Categorie";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(311, 355);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 19);
            this.label14.TabIndex = 46;
            this.label14.Text = "Image";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(311, 323);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 19);
            this.label15.TabIndex = 45;
            this.label15.Text = "Prix";
            // 
            // txtModifierPrixProduit
            // 
            this.txtModifierPrixProduit.Location = new System.Drawing.Point(421, 323);
            this.txtModifierPrixProduit.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifierPrixProduit.Name = "txtModifierPrixProduit";
            this.txtModifierPrixProduit.Size = new System.Drawing.Size(132, 25);
            this.txtModifierPrixProduit.TabIndex = 44;
            // 
            // txtModifierCategorieProduit
            // 
            this.txtModifierCategorieProduit.Location = new System.Drawing.Point(421, 382);
            this.txtModifierCategorieProduit.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifierCategorieProduit.Name = "txtModifierCategorieProduit";
            this.txtModifierCategorieProduit.Size = new System.Drawing.Size(132, 25);
            this.txtModifierCategorieProduit.TabIndex = 43;
            // 
            // txtModifierImageProduit
            // 
            this.txtModifierImageProduit.Location = new System.Drawing.Point(421, 352);
            this.txtModifierImageProduit.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifierImageProduit.Name = "txtModifierImageProduit";
            this.txtModifierImageProduit.Size = new System.Drawing.Size(132, 25);
            this.txtModifierImageProduit.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 196);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 19);
            this.label12.TabIndex = 41;
            this.label12.Text = "Categorie";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 165);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 19);
            this.label11.TabIndex = 40;
            this.label11.Text = "Image";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 19);
            this.label8.TabIndex = 39;
            this.label8.Text = "Prix";
            // 
            // txtCategorieProduit
            // 
            this.txtCategorieProduit.Location = new System.Drawing.Point(139, 193);
            this.txtCategorieProduit.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategorieProduit.Name = "txtCategorieProduit";
            this.txtCategorieProduit.Size = new System.Drawing.Size(132, 25);
            this.txtCategorieProduit.TabIndex = 38;
            // 
            // txtImageProduit
            // 
            this.txtImageProduit.Location = new System.Drawing.Point(139, 162);
            this.txtImageProduit.Margin = new System.Windows.Forms.Padding(4);
            this.txtImageProduit.Name = "txtImageProduit";
            this.txtImageProduit.Size = new System.Drawing.Size(132, 25);
            this.txtImageProduit.TabIndex = 37;
            // 
            // txtPrixProduit
            // 
            this.txtPrixProduit.Location = new System.Drawing.Point(139, 131);
            this.txtPrixProduit.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrixProduit.Name = "txtPrixProduit";
            this.txtPrixProduit.Size = new System.Drawing.Size(132, 25);
            this.txtPrixProduit.TabIndex = 36;
            // 
            // dgvLesProduits
            // 
            this.dgvLesProduits.AllowUserToAddRows = false;
            this.dgvLesProduits.AllowUserToDeleteRows = false;
            this.dgvLesProduits.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvLesProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLesProduits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduit,
            this.TitreProduit,
            this.DescriptionProduit,
            this.PrixProduit,
            this.ImageProduit,
            this.CategorieProduit});
            this.dgvLesProduits.Location = new System.Drawing.Point(314, 19);
            this.dgvLesProduits.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLesProduits.Name = "dgvLesProduits";
            this.dgvLesProduits.ReadOnly = true;
            this.dgvLesProduits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLesProduits.Size = new System.Drawing.Size(497, 185);
            this.dgvLesProduits.TabIndex = 26;
            this.dgvLesProduits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLesProduits_CellContentClick);
            this.dgvLesProduits.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLesProduits_CellContentDoubleClick);
            this.dgvLesProduits.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLesProduits_CellDoubleClick);
            // 
            // idProduit
            // 
            this.idProduit.HeaderText = "id";
            this.idProduit.Name = "idProduit";
            this.idProduit.ReadOnly = true;
            this.idProduit.Width = 30;
            // 
            // TitreProduit
            // 
            this.TitreProduit.HeaderText = "Titre";
            this.TitreProduit.Name = "TitreProduit";
            this.TitreProduit.ReadOnly = true;
            this.TitreProduit.Width = 95;
            // 
            // DescriptionProduit
            // 
            this.DescriptionProduit.HeaderText = "Description";
            this.DescriptionProduit.Name = "DescriptionProduit";
            this.DescriptionProduit.ReadOnly = true;
            this.DescriptionProduit.Width = 110;
            // 
            // PrixProduit
            // 
            this.PrixProduit.HeaderText = "Prix";
            this.PrixProduit.Name = "PrixProduit";
            this.PrixProduit.ReadOnly = true;
            this.PrixProduit.Width = 50;
            // 
            // ImageProduit
            // 
            this.ImageProduit.HeaderText = "Image";
            this.ImageProduit.Name = "ImageProduit";
            this.ImageProduit.ReadOnly = true;
            // 
            // CategorieProduit
            // 
            this.CategorieProduit.HeaderText = "Categorie";
            this.CategorieProduit.Name = "CategorieProduit";
            this.CategorieProduit.ReadOnly = true;
            this.CategorieProduit.Width = 69;
            // 
            // btnModifierEtudiant
            // 
            this.btnModifierEtudiant.Location = new System.Drawing.Point(566, 352);
            this.btnModifierEtudiant.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierEtudiant.Name = "btnModifierEtudiant";
            this.btnModifierEtudiant.Size = new System.Drawing.Size(100, 51);
            this.btnModifierEtudiant.TabIndex = 34;
            this.btnModifierEtudiant.Text = "Modifier produit";
            this.btnModifierEtudiant.UseVisualStyleBackColor = true;
            this.btnModifierEtudiant.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSupprimerEtudiant
            // 
            this.btnSupprimerEtudiant.Location = new System.Drawing.Point(602, 223);
            this.btnSupprimerEtudiant.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimerEtudiant.Name = "btnSupprimerEtudiant";
            this.btnSupprimerEtudiant.Size = new System.Drawing.Size(100, 47);
            this.btnSupprimerEtudiant.TabIndex = 35;
            this.btnSupprimerEtudiant.Text = "Supprimer produit";
            this.btnSupprimerEtudiant.UseVisualStyleBackColor = true;
            this.btnSupprimerEtudiant.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtModifierDescriptionProduit
            // 
            this.txtModifierDescriptionProduit.Location = new System.Drawing.Point(139, 382);
            this.txtModifierDescriptionProduit.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifierDescriptionProduit.Name = "txtModifierDescriptionProduit";
            this.txtModifierDescriptionProduit.Size = new System.Drawing.Size(132, 25);
            this.txtModifierDescriptionProduit.TabIndex = 33;
            // 
            // txtModifierTitreProduit
            // 
            this.txtModifierTitreProduit.Location = new System.Drawing.Point(139, 352);
            this.txtModifierTitreProduit.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifierTitreProduit.Name = "txtModifierTitreProduit";
            this.txtModifierTitreProduit.Size = new System.Drawing.Size(132, 25);
            this.txtModifierTitreProduit.TabIndex = 32;
            // 
            // btnAfficherDataGridViewProduit
            // 
            this.btnAfficherDataGridViewProduit.Location = new System.Drawing.Point(710, 224);
            this.btnAfficherDataGridViewProduit.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfficherDataGridViewProduit.Name = "btnAfficherDataGridViewProduit";
            this.btnAfficherDataGridViewProduit.Size = new System.Drawing.Size(100, 46);
            this.btnAfficherDataGridViewProduit.TabIndex = 27;
            this.btnAfficherDataGridViewProduit.Text = "Rafraîchir";
            this.btnAfficherDataGridViewProduit.UseVisualStyleBackColor = true;
            this.btnAfficherDataGridViewProduit.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 382);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(31, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 350);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Titre";
            // 
            // txtIdProduit
            // 
            this.txtIdProduit.Location = new System.Drawing.Point(139, 36);
            this.txtIdProduit.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdProduit.Name = "txtIdProduit";
            this.txtIdProduit.ReadOnly = true;
            this.txtIdProduit.Size = new System.Drawing.Size(132, 25);
            this.txtIdProduit.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(31, 318);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Titre";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtModifierIdProduit
            // 
            this.txtModifierIdProduit.Location = new System.Drawing.Point(139, 323);
            this.txtModifierIdProduit.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifierIdProduit.Name = "txtModifierIdProduit";
            this.txtModifierIdProduit.ReadOnly = true;
            this.txtModifierIdProduit.Size = new System.Drawing.Size(132, 25);
            this.txtModifierIdProduit.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Description";
            // 
            // btnCreerNouveauProduit
            // 
            this.btnCreerNouveauProduit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCreerNouveauProduit.Location = new System.Drawing.Point(166, 226);
            this.btnCreerNouveauProduit.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreerNouveauProduit.Name = "btnCreerNouveauProduit";
            this.btnCreerNouveauProduit.Size = new System.Drawing.Size(105, 47);
            this.btnCreerNouveauProduit.TabIndex = 25;
            this.btnCreerNouveauProduit.Text = "Nouveau Produit";
            this.btnCreerNouveauProduit.UseVisualStyleBackColor = false;
            this.btnCreerNouveauProduit.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtTitreProduit
            // 
            this.txtTitreProduit.Location = new System.Drawing.Point(139, 68);
            this.txtTitreProduit.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitreProduit.Name = "txtTitreProduit";
            this.txtTitreProduit.Size = new System.Drawing.Size(132, 25);
            this.txtTitreProduit.TabIndex = 23;
            // 
            // txtDescriptionProduit
            // 
            this.txtDescriptionProduit.Location = new System.Drawing.Point(139, 100);
            this.txtDescriptionProduit.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescriptionProduit.Name = "txtDescriptionProduit";
            this.txtDescriptionProduit.Size = new System.Drawing.Size(132, 25);
            this.txtDescriptionProduit.TabIndex = 24;
            // 
            // tabCommande
            // 
            this.tabCommande.BackColor = System.Drawing.Color.Linen;
            this.tabCommande.Controls.Add(this.label17);
            this.tabCommande.Controls.Add(this.txtModifierDateCommande);
            this.tabCommande.Controls.Add(this.txtModifierStatusCommande);
            this.tabCommande.Controls.Add(this.lblDate);
            this.tabCommande.Controls.Add(this.lblStatus);
            this.tabCommande.Controls.Add(this.dgvLesCommandes);
            this.tabCommande.Controls.Add(this.btnModifierCommande);
            this.tabCommande.Controls.Add(this.txtModifierReferenceCommande);
            this.tabCommande.Controls.Add(this.btnAfficherDataGridViewCommande);
            this.tabCommande.Controls.Add(this.label9);
            this.tabCommande.Controls.Add(this.label10);
            this.tabCommande.Controls.Add(this.txtModifierIdCommande);
            this.tabCommande.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F);
            this.tabCommande.Location = new System.Drawing.Point(4, 25);
            this.tabCommande.Name = "tabCommande";
            this.tabCommande.Size = new System.Drawing.Size(843, 421);
            this.tabCommande.TabIndex = 2;
            this.tabCommande.Text = "Commande";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label17.Location = new System.Drawing.Point(31, 10);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(159, 19);
            this.label17.TabIndex = 58;
            this.label17.Text = "Modifier une commande";
            // 
            // txtModifierDateCommande
            // 
            this.txtModifierDateCommande.Location = new System.Drawing.Point(139, 135);
            this.txtModifierDateCommande.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifierDateCommande.Name = "txtModifierDateCommande";
            this.txtModifierDateCommande.ReadOnly = true;
            this.txtModifierDateCommande.Size = new System.Drawing.Size(132, 25);
            this.txtModifierDateCommande.TabIndex = 57;
            // 
            // txtModifierStatusCommande
            // 
            this.txtModifierStatusCommande.Location = new System.Drawing.Point(139, 101);
            this.txtModifierStatusCommande.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifierStatusCommande.Name = "txtModifierStatusCommande";
            this.txtModifierStatusCommande.Size = new System.Drawing.Size(132, 25);
            this.txtModifierStatusCommande.TabIndex = 55;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(31, 137);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 19);
            this.lblDate.TabIndex = 54;
            this.lblDate.Text = "Date";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(31, 105);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 19);
            this.lblStatus.TabIndex = 53;
            this.lblStatus.Text = "Status";
            // 
            // dgvLesCommandes
            // 
            this.dgvLesCommandes.AllowUserToAddRows = false;
            this.dgvLesCommandes.AllowUserToDeleteRows = false;
            this.dgvLesCommandes.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvLesCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLesCommandes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCommande,
            this.RefenreceCommande,
            this.StatusCommande,
            this.DateCommande,
            this.AdresseLivraisonCommande});
            this.dgvLesCommandes.Location = new System.Drawing.Point(314, 19);
            this.dgvLesCommandes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLesCommandes.Name = "dgvLesCommandes";
            this.dgvLesCommandes.ReadOnly = true;
            this.dgvLesCommandes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLesCommandes.Size = new System.Drawing.Size(497, 185);
            this.dgvLesCommandes.TabIndex = 44;
            this.dgvLesCommandes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLesCommandes_CellContentClick);
            this.dgvLesCommandes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLesCommandes_CellContentDoubleClick);
            this.dgvLesCommandes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLesCommandes_CellDoubleClick);
            // 
            // btnModifierCommande
            // 
            this.btnModifierCommande.Location = new System.Drawing.Point(171, 166);
            this.btnModifierCommande.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierCommande.Name = "btnModifierCommande";
            this.btnModifierCommande.Size = new System.Drawing.Size(100, 50);
            this.btnModifierCommande.TabIndex = 52;
            this.btnModifierCommande.Text = "Modifier commande";
            this.btnModifierCommande.UseVisualStyleBackColor = true;
            this.btnModifierCommande.Click += new System.EventHandler(this.btnModifierCommande_Click);
            // 
            // txtModifierReferenceCommande
            // 
            this.txtModifierReferenceCommande.Location = new System.Drawing.Point(139, 68);
            this.txtModifierReferenceCommande.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifierReferenceCommande.Name = "txtModifierReferenceCommande";
            this.txtModifierReferenceCommande.Size = new System.Drawing.Size(132, 25);
            this.txtModifierReferenceCommande.TabIndex = 50;
            // 
            // btnAfficherDataGridViewCommande
            // 
            this.btnAfficherDataGridViewCommande.Location = new System.Drawing.Point(710, 224);
            this.btnAfficherDataGridViewCommande.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfficherDataGridViewCommande.Name = "btnAfficherDataGridViewCommande";
            this.btnAfficherDataGridViewCommande.Size = new System.Drawing.Size(100, 46);
            this.btnAfficherDataGridViewCommande.TabIndex = 45;
            this.btnAfficherDataGridViewCommande.Text = "Rafraîchir";
            this.btnAfficherDataGridViewCommande.UseVisualStyleBackColor = true;
            this.btnAfficherDataGridViewCommande.Click += new System.EventHandler(this.btnAfficherDataGridViewCommande_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 72);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 19);
            this.label9.TabIndex = 48;
            this.label9.Text = "Reference";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(31, 40);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 19);
            this.label10.TabIndex = 47;
            this.label10.Text = "Id";
            // 
            // txtModifierIdCommande
            // 
            this.txtModifierIdCommande.Location = new System.Drawing.Point(139, 36);
            this.txtModifierIdCommande.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifierIdCommande.Name = "txtModifierIdCommande";
            this.txtModifierIdCommande.ReadOnly = true;
            this.txtModifierIdCommande.Size = new System.Drawing.Size(132, 25);
            this.txtModifierIdCommande.TabIndex = 46;
            // 
            // tabArticleCommande
            // 
            this.tabArticleCommande.BackColor = System.Drawing.Color.Linen;
            this.tabArticleCommande.Controls.Add(this.dgvLesArticles);
            this.tabArticleCommande.Controls.Add(this.button2);
            this.tabArticleCommande.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F);
            this.tabArticleCommande.Location = new System.Drawing.Point(4, 25);
            this.tabArticleCommande.Name = "tabArticleCommande";
            this.tabArticleCommande.Size = new System.Drawing.Size(843, 421);
            this.tabArticleCommande.TabIndex = 3;
            this.tabArticleCommande.Text = "ArticleCommande";
            // 
            // tabAdresseLivraison
            // 
            this.tabAdresseLivraison.BackColor = System.Drawing.Color.Linen;
            this.tabAdresseLivraison.Controls.Add(this.dgvLesLivraisons);
            this.tabAdresseLivraison.Controls.Add(this.button4);
            this.tabAdresseLivraison.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F);
            this.tabAdresseLivraison.Location = new System.Drawing.Point(4, 25);
            this.tabAdresseLivraison.Name = "tabAdresseLivraison";
            this.tabAdresseLivraison.Size = new System.Drawing.Size(843, 421);
            this.tabAdresseLivraison.TabIndex = 4;
            this.tabAdresseLivraison.Text = "AdresseLivraison";
            // 
            // dgvLesArticles
            // 
            this.dgvLesArticles.AllowUserToAddRows = false;
            this.dgvLesArticles.AllowUserToDeleteRows = false;
            this.dgvLesArticles.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvLesArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLesArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CommandeArticle,
            this.ProduitArticle});
            this.dgvLesArticles.Location = new System.Drawing.Point(26, 19);
            this.dgvLesArticles.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLesArticles.Name = "dgvLesArticles";
            this.dgvLesArticles.ReadOnly = true;
            this.dgvLesArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLesArticles.Size = new System.Drawing.Size(785, 185);
            this.dgvLesArticles.TabIndex = 59;
            this.dgvLesArticles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLesArticles_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(710, 224);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 46);
            this.button2.TabIndex = 60;
            this.button2.Text = "Rafraîchir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dgvLesLivraisons
            // 
            this.dgvLesLivraisons.AllowUserToAddRows = false;
            this.dgvLesLivraisons.AllowUserToDeleteRows = false;
            this.dgvLesLivraisons.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvLesLivraisons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLesLivraisons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Column1});
            this.dgvLesLivraisons.Location = new System.Drawing.Point(26, 19);
            this.dgvLesLivraisons.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLesLivraisons.Name = "dgvLesLivraisons";
            this.dgvLesLivraisons.ReadOnly = true;
            this.dgvLesLivraisons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLesLivraisons.Size = new System.Drawing.Size(785, 185);
            this.dgvLesLivraisons.TabIndex = 59;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(710, 224);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 46);
            this.button4.TabIndex = 60;
            this.button4.Text = "Rafraîchir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Adresse";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Code Postal";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 119;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Ville";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 115;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pays";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // idCommande
            // 
            this.idCommande.HeaderText = "id";
            this.idCommande.Name = "idCommande";
            this.idCommande.ReadOnly = true;
            // 
            // RefenreceCommande
            // 
            this.RefenreceCommande.HeaderText = "Reference";
            this.RefenreceCommande.Name = "RefenreceCommande";
            this.RefenreceCommande.ReadOnly = true;
            this.RefenreceCommande.Width = 120;
            // 
            // StatusCommande
            // 
            this.StatusCommande.HeaderText = "Status";
            this.StatusCommande.Name = "StatusCommande";
            this.StatusCommande.ReadOnly = true;
            this.StatusCommande.Width = 119;
            // 
            // DateCommande
            // 
            this.DateCommande.HeaderText = "Date";
            this.DateCommande.Name = "DateCommande";
            this.DateCommande.ReadOnly = true;
            this.DateCommande.Width = 115;
            // 
            // AdresseLivraisonCommande
            // 
            this.AdresseLivraisonCommande.HeaderText = "Adresse Livraison";
            this.AdresseLivraisonCommande.Name = "AdresseLivraisonCommande";
            this.AdresseLivraisonCommande.ReadOnly = true;
            // 
            // CommandeArticle
            // 
            this.CommandeArticle.HeaderText = "idCommande";
            this.CommandeArticle.Name = "CommandeArticle";
            this.CommandeArticle.ReadOnly = true;
            this.CommandeArticle.Width = 120;
            // 
            // ProduitArticle
            // 
            this.ProduitArticle.HeaderText = "idProduit";
            this.ProduitArticle.Name = "ProduitArticle";
            this.ProduitArticle.ReadOnly = true;
            this.ProduitArticle.Width = 115;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 474);
            this.Controls.Add(this.dgvLesAdresses);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "TP Connexion Bdd";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesUsers)).EndInit();
            this.dgvLesAdresses.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.tabProduit.ResumeLayout(false);
            this.tabProduit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesProduits)).EndInit();
            this.tabCommande.ResumeLayout(false);
            this.tabCommande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesCommandes)).EndInit();
            this.tabArticleCommande.ResumeLayout(false);
            this.tabAdresseLivraison.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesLivraisons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnecterMySQL;
        private System.Windows.Forms.DataGridView dgvLesUsers;
        private System.Windows.Forms.Button btnAfficherDataGridView;
        private System.Windows.Forms.Button btnModifierUser;
        private System.Windows.Forms.TextBox txtModifierEmailUser;
        private System.Windows.Forms.TextBox txtModifierUsernameUser;
        private System.Windows.Forms.Label lblModifierEmailUser;
        private System.Windows.Forms.Label lblModifierUsernameUser;
        private System.Windows.Forms.Label lblModifierid;
        private System.Windows.Forms.TextBox txtModifierid;
        private System.Windows.Forms.TabControl dgvLesAdresses;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabProduit;
        private System.Windows.Forms.DataGridView dgvLesProduits;
        private System.Windows.Forms.Button btnModifierEtudiant;
        private System.Windows.Forms.Button btnSupprimerEtudiant;
        private System.Windows.Forms.TextBox txtModifierDescriptionProduit;
        private System.Windows.Forms.TextBox txtModifierTitreProduit;
        private System.Windows.Forms.Button btnAfficherDataGridViewProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdProduit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModifierIdProduit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreerNouveauProduit;
        private System.Windows.Forms.TextBox txtTitreProduit;
        private System.Windows.Forms.TextBox txtDescriptionProduit;
        private System.Windows.Forms.TabPage tabCommande;
        private System.Windows.Forms.DataGridView dgvLesCommandes;
        private System.Windows.Forms.Button btnModifierCommande;
        private System.Windows.Forms.TextBox txtModifierReferenceCommande;
        private System.Windows.Forms.Button btnAfficherDataGridViewCommande;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtModifierIdCommande;
        private System.Windows.Forms.TextBox txtModifierPrixProduit;
        private System.Windows.Forms.TextBox txtModifierCategorieProduit;
        private System.Windows.Forms.TextBox txtModifierImageProduit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCategorieProduit;
        private System.Windows.Forms.TextBox txtImageProduit;
        private System.Windows.Forms.TextBox txtPrixProduit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtModifierStatusCommande;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtModifierDateCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitreProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategorieProduit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefenreceCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresseLivraisonCommande;
        private System.Windows.Forms.TabPage tabArticleCommande;
        private System.Windows.Forms.DataGridView dgvLesArticles;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabAdresseLivraison;
        private System.Windows.Forms.DataGridView dgvLesLivraisons;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommandeArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduitArticle;
    }
}


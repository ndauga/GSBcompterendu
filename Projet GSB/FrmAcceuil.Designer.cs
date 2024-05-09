namespace Projet_GSB
{
    partial class FrmAcceuil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcceuil));
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMedicament = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisiteur = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMedecin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRapport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierAcceuil = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMedicamentGerer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMedicamentListe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisiteurListe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisiteurGerer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMedecinGerer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMedecinDernierRapport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMedecinRechercher = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisiteurRechercher = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRapportAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRapportRechercher = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRapportListe = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuAide = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.mnuMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuMedicament,
            this.mnuVisiteur,
            this.mnuMedecin,
            this.mnuRapport,
            this.mnuAide});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(800, 24);
            this.mnuMenu.TabIndex = 0;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierAcceuil,
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "Fichier";
            // 
            // mnuMedicament
            // 
            this.mnuMedicament.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMedicamentGerer,
            this.mnuMedicamentListe});
            this.mnuMedicament.Name = "mnuMedicament";
            this.mnuMedicament.Size = new System.Drawing.Size(86, 20);
            this.mnuMedicament.Text = "Médicament";
            // 
            // mnuVisiteur
            // 
            this.mnuVisiteur.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVisiteurListe,
            this.mnuVisiteurGerer,
            this.mnuVisiteurRechercher});
            this.mnuVisiteur.Name = "mnuVisiteur";
            this.mnuVisiteur.Size = new System.Drawing.Size(58, 20);
            this.mnuVisiteur.Text = "Visiteur";
            // 
            // mnuMedecin
            // 
            this.mnuMedecin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMedecinGerer,
            this.mnuMedecinDernierRapport,
            this.mnuMedecinRechercher});
            this.mnuMedecin.Name = "mnuMedecin";
            this.mnuMedecin.Size = new System.Drawing.Size(65, 20);
            this.mnuMedecin.Text = "Médecin";
            // 
            // mnuRapport
            // 
            this.mnuRapport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRapportAjouter,
            this.mnuRapportRechercher,
            this.mnuRapportListe});
            this.mnuRapport.Name = "mnuRapport";
            this.mnuRapport.Size = new System.Drawing.Size(61, 20);
            this.mnuRapport.Text = "Rapport";
            // 
            // mnuFichierAcceuil
            // 
            this.mnuFichierAcceuil.Name = "mnuFichierAcceuil";
            this.mnuFichierAcceuil.Size = new System.Drawing.Size(180, 22);
            this.mnuFichierAcceuil.Text = "Acceuil";
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.Size = new System.Drawing.Size(180, 22);
            this.mnuFichierQuitter.Text = "Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // mnuMedicamentGerer
            // 
            this.mnuMedicamentGerer.Name = "mnuMedicamentGerer";
            this.mnuMedicamentGerer.Size = new System.Drawing.Size(180, 22);
            this.mnuMedicamentGerer.Text = "Gérer";
            // 
            // mnuMedicamentListe
            // 
            this.mnuMedicamentListe.Name = "mnuMedicamentListe";
            this.mnuMedicamentListe.Size = new System.Drawing.Size(180, 22);
            this.mnuMedicamentListe.Text = "Liste";
            this.mnuMedicamentListe.Click += new System.EventHandler(this.mnuMedicamentListe_Click);
            // 
            // mnuVisiteurListe
            // 
            this.mnuVisiteurListe.Name = "mnuVisiteurListe";
            this.mnuVisiteurListe.Size = new System.Drawing.Size(180, 22);
            this.mnuVisiteurListe.Text = "Liste";
            // 
            // mnuVisiteurGerer
            // 
            this.mnuVisiteurGerer.Name = "mnuVisiteurGerer";
            this.mnuVisiteurGerer.Size = new System.Drawing.Size(180, 22);
            this.mnuVisiteurGerer.Text = "Gérer";
            // 
            // mnuMedecinGerer
            // 
            this.mnuMedecinGerer.Name = "mnuMedecinGerer";
            this.mnuMedecinGerer.Size = new System.Drawing.Size(180, 22);
            this.mnuMedecinGerer.Text = "Gérer";
            // 
            // mnuMedecinDernierRapport
            // 
            this.mnuMedecinDernierRapport.Name = "mnuMedecinDernierRapport";
            this.mnuMedecinDernierRapport.Size = new System.Drawing.Size(180, 22);
            this.mnuMedecinDernierRapport.Text = "Dernier rapport";
            // 
            // mnuMedecinRechercher
            // 
            this.mnuMedecinRechercher.Name = "mnuMedecinRechercher";
            this.mnuMedecinRechercher.Size = new System.Drawing.Size(180, 22);
            this.mnuMedecinRechercher.Text = "Rechercher";
            // 
            // mnuVisiteurRechercher
            // 
            this.mnuVisiteurRechercher.Name = "mnuVisiteurRechercher";
            this.mnuVisiteurRechercher.Size = new System.Drawing.Size(180, 22);
            this.mnuVisiteurRechercher.Text = "Rechercher";
            // 
            // mnuRapportAjouter
            // 
            this.mnuRapportAjouter.Name = "mnuRapportAjouter";
            this.mnuRapportAjouter.Size = new System.Drawing.Size(180, 22);
            this.mnuRapportAjouter.Text = "Ajouter";
            // 
            // mnuRapportRechercher
            // 
            this.mnuRapportRechercher.Name = "mnuRapportRechercher";
            this.mnuRapportRechercher.Size = new System.Drawing.Size(180, 22);
            this.mnuRapportRechercher.Text = "Rechercher";
            // 
            // mnuRapportListe
            // 
            this.mnuRapportListe.Name = "mnuRapportListe";
            this.mnuRapportListe.Size = new System.Drawing.Size(180, 22);
            this.mnuRapportListe.Text = "Liste";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(490, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mnuAide
            // 
            this.mnuAide.Name = "mnuAide";
            this.mnuAide.Size = new System.Drawing.Size(24, 20);
            this.mnuAide.Text = "?";
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnQuitter.Location = new System.Drawing.Point(713, 415);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // FrmAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnuMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "FrmAcceuil";
            this.Text = "x";
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuMedicament;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierAcceuil;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.ToolStripMenuItem mnuMedicamentGerer;
        private System.Windows.Forms.ToolStripMenuItem mnuMedicamentListe;
        private System.Windows.Forms.ToolStripMenuItem mnuVisiteur;
        private System.Windows.Forms.ToolStripMenuItem mnuVisiteurListe;
        private System.Windows.Forms.ToolStripMenuItem mnuVisiteurGerer;
        private System.Windows.Forms.ToolStripMenuItem mnuVisiteurRechercher;
        private System.Windows.Forms.ToolStripMenuItem mnuMedecin;
        private System.Windows.Forms.ToolStripMenuItem mnuMedecinGerer;
        private System.Windows.Forms.ToolStripMenuItem mnuMedecinDernierRapport;
        private System.Windows.Forms.ToolStripMenuItem mnuMedecinRechercher;
        private System.Windows.Forms.ToolStripMenuItem mnuRapport;
        private System.Windows.Forms.ToolStripMenuItem mnuRapportAjouter;
        private System.Windows.Forms.ToolStripMenuItem mnuRapportRechercher;
        private System.Windows.Forms.ToolStripMenuItem mnuRapportListe;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuAide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQuitter;
    }
}


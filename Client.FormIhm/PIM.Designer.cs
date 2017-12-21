namespace Client.FormIhm
{
    partial class PIM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbRecherche = new System.Windows.Forms.GroupBox();
            this.tbCodeIata = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.codeIata = new System.Windows.Forms.Label();
            this.gbResultat = new System.Windows.Forms.GroupBox();
            this.bagage = new System.Windows.Forms.GroupBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.cbPrioritaire = new System.Windows.Forms.CheckBox();
            this.tbClasseBagage = new System.Windows.Forms.TextBox();
            this.tbItineraire = new System.Windows.Forms.TextBox();
            this.cbRush = new System.Windows.Forms.CheckBox();
            this.cbContinuation = new System.Windows.Forms.CheckBox();
            this.classeBagage = new System.Windows.Forms.Label();
            this.itineraire = new System.Windows.Forms.Label();
            this.vol = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbJourExploitation = new System.Windows.Forms.TextBox();
            this.tbLigne = new System.Windows.Forms.TextBox();
            this.tbCompagnie = new System.Windows.Forms.TextBox();
            this.jourExploitation = new System.Windows.Forms.Label();
            this.ligne = new System.Windows.Forms.Label();
            this.compagnie = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.commandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réinitialiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageBagageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attenteBagageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créationBagageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionBagageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.message = new System.Windows.Forms.ToolStripStatusLabel();
            this.etat = new System.Windows.Forms.ToolStripStatusLabel();
            this.listBoxLogs = new System.Windows.Forms.ListBox();
            this.gbRecherche.SuspendLayout();
            this.gbResultat.SuspendLayout();
            this.bagage.SuspendLayout();
            this.vol.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRecherche
            // 
            this.gbRecherche.Controls.Add(this.tbCodeIata);
            this.gbRecherche.Controls.Add(this.btnRechercher);
            this.gbRecherche.Controls.Add(this.codeIata);
            this.gbRecherche.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbRecherche.Location = new System.Drawing.Point(0, 28);
            this.gbRecherche.Name = "gbRecherche";
            this.gbRecherche.Size = new System.Drawing.Size(915, 70);
            this.gbRecherche.TabIndex = 0;
            this.gbRecherche.TabStop = false;
            this.gbRecherche.Text = "Recherche";
            // 
            // tbCodeIata
            // 
            this.tbCodeIata.Location = new System.Drawing.Point(143, 21);
            this.tbCodeIata.Margin = new System.Windows.Forms.Padding(5);
            this.tbCodeIata.Name = "tbCodeIata";
            this.tbCodeIata.Size = new System.Drawing.Size(600, 30);
            this.tbCodeIata.TabIndex = 1;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRechercher.Location = new System.Drawing.Point(755, 18);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(5);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(139, 41);
            this.btnRechercher.TabIndex = 2;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.search_Click);
            // 
            // codeIata
            // 
            this.codeIata.AutoSize = true;
            this.codeIata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.codeIata.Location = new System.Drawing.Point(30, 26);
            this.codeIata.Margin = new System.Windows.Forms.Padding(5);
            this.codeIata.Name = "codeIata";
            this.codeIata.Size = new System.Drawing.Size(103, 25);
            this.codeIata.TabIndex = 0;
            this.codeIata.Text = "CodeIata: ";
            // 
            // gbResultat
            // 
            this.gbResultat.Controls.Add(this.bagage);
            this.gbResultat.Controls.Add(this.vol);
            this.gbResultat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbResultat.Location = new System.Drawing.Point(0, 98);
            this.gbResultat.Name = "gbResultat";
            this.gbResultat.Size = new System.Drawing.Size(915, 377);
            this.gbResultat.TabIndex = 1;
            this.gbResultat.TabStop = false;
            this.gbResultat.Text = "Resultat";
            // 
            // bagage
            // 
            this.bagage.AutoSize = true;
            this.bagage.Controls.Add(this.btnCreer);
            this.bagage.Controls.Add(this.cbPrioritaire);
            this.bagage.Controls.Add(this.tbClasseBagage);
            this.bagage.Controls.Add(this.tbItineraire);
            this.bagage.Controls.Add(this.cbRush);
            this.bagage.Controls.Add(this.cbContinuation);
            this.bagage.Controls.Add(this.classeBagage);
            this.bagage.Controls.Add(this.itineraire);
            this.bagage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bagage.Location = new System.Drawing.Point(526, 26);
            this.bagage.Name = "bagage";
            this.bagage.Size = new System.Drawing.Size(386, 348);
            this.bagage.TabIndex = 1;
            this.bagage.TabStop = false;
            this.bagage.Text = "Bagage";
            // 
            // btnCreer
            // 
            this.btnCreer.Enabled = false;
            this.btnCreer.Location = new System.Drawing.Point(229, 224);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(148, 38);
            this.btnCreer.TabIndex = 7;
            this.btnCreer.Text = "Créer Bagage";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // cbPrioritaire
            // 
            this.cbPrioritaire.AutoSize = true;
            this.cbPrioritaire.Enabled = false;
            this.cbPrioritaire.Location = new System.Drawing.Point(43, 234);
            this.cbPrioritaire.Name = "cbPrioritaire";
            this.cbPrioritaire.Size = new System.Drawing.Size(115, 29);
            this.cbPrioritaire.TabIndex = 6;
            this.cbPrioritaire.Text = "Prioritaire";
            this.cbPrioritaire.UseVisualStyleBackColor = true;
            // 
            // tbClasseBagage
            // 
            this.tbClasseBagage.Enabled = false;
            this.tbClasseBagage.Location = new System.Drawing.Point(268, 110);
            this.tbClasseBagage.Name = "tbClasseBagage";
            this.tbClasseBagage.Size = new System.Drawing.Size(100, 30);
            this.tbClasseBagage.TabIndex = 5;
            this.tbClasseBagage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbItineraire
            // 
            this.tbItineraire.Enabled = false;
            this.tbItineraire.Location = new System.Drawing.Point(268, 48);
            this.tbItineraire.Name = "tbItineraire";
            this.tbItineraire.Size = new System.Drawing.Size(100, 30);
            this.tbItineraire.TabIndex = 4;
            this.tbItineraire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbRush
            // 
            this.cbRush.AutoSize = true;
            this.cbRush.Enabled = false;
            this.cbRush.Location = new System.Drawing.Point(43, 199);
            this.cbRush.Name = "cbRush";
            this.cbRush.Size = new System.Drawing.Size(79, 29);
            this.cbRush.TabIndex = 3;
            this.cbRush.Text = "Rush";
            this.cbRush.UseVisualStyleBackColor = true;
            // 
            // cbContinuation
            // 
            this.cbContinuation.AutoSize = true;
            this.cbContinuation.Enabled = false;
            this.cbContinuation.Location = new System.Drawing.Point(43, 164);
            this.cbContinuation.Name = "cbContinuation";
            this.cbContinuation.Size = new System.Drawing.Size(173, 29);
            this.cbContinuation.TabIndex = 2;
            this.cbContinuation.Text = "En Continuation";
            this.cbContinuation.UseVisualStyleBackColor = true;
            // 
            // classeBagage
            // 
            this.classeBagage.AutoSize = true;
            this.classeBagage.Location = new System.Drawing.Point(38, 113);
            this.classeBagage.Name = "classeBagage";
            this.classeBagage.Size = new System.Drawing.Size(157, 25);
            this.classeBagage.TabIndex = 1;
            this.classeBagage.Text = "Classe Bagage: ";
            // 
            // itineraire
            // 
            this.itineraire.AutoSize = true;
            this.itineraire.Location = new System.Drawing.Point(38, 53);
            this.itineraire.Name = "itineraire";
            this.itineraire.Size = new System.Drawing.Size(97, 25);
            this.itineraire.TabIndex = 0;
            this.itineraire.Text = "Itinéraire: ";
            // 
            // vol
            // 
            this.vol.AutoSize = true;
            this.vol.Controls.Add(this.listBoxLogs);
            this.vol.Controls.Add(this.label1);
            this.vol.Controls.Add(this.tbJourExploitation);
            this.vol.Controls.Add(this.tbLigne);
            this.vol.Controls.Add(this.tbCompagnie);
            this.vol.Controls.Add(this.jourExploitation);
            this.vol.Controls.Add(this.ligne);
            this.vol.Controls.Add(this.compagnie);
            this.vol.Dock = System.Windows.Forms.DockStyle.Left;
            this.vol.Location = new System.Drawing.Point(3, 26);
            this.vol.Name = "vol";
            this.vol.Size = new System.Drawing.Size(523, 348);
            this.vol.TabIndex = 0;
            this.vol.TabStop = false;
            this.vol.Text = "Vol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(32, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "(dd/MM/yyyy HH:mm:ss)";
            // 
            // tbJourExploitation
            // 
            this.tbJourExploitation.Enabled = false;
            this.tbJourExploitation.Location = new System.Drawing.Point(217, 161);
            this.tbJourExploitation.Name = "tbJourExploitation";
            this.tbJourExploitation.Size = new System.Drawing.Size(300, 30);
            this.tbJourExploitation.TabIndex = 6;
            this.tbJourExploitation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLigne
            // 
            this.tbLigne.Enabled = false;
            this.tbLigne.Location = new System.Drawing.Point(217, 110);
            this.tbLigne.Name = "tbLigne";
            this.tbLigne.Size = new System.Drawing.Size(300, 30);
            this.tbLigne.TabIndex = 4;
            this.tbLigne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCompagnie
            // 
            this.tbCompagnie.Enabled = false;
            this.tbCompagnie.Location = new System.Drawing.Point(217, 48);
            this.tbCompagnie.Name = "tbCompagnie";
            this.tbCompagnie.Size = new System.Drawing.Size(300, 30);
            this.tbCompagnie.TabIndex = 3;
            this.tbCompagnie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // jourExploitation
            // 
            this.jourExploitation.AutoSize = true;
            this.jourExploitation.Location = new System.Drawing.Point(27, 164);
            this.jourExploitation.Name = "jourExploitation";
            this.jourExploitation.Size = new System.Drawing.Size(180, 25);
            this.jourExploitation.TabIndex = 2;
            this.jourExploitation.Text = "Jour d\'exploitation: ";
            // 
            // ligne
            // 
            this.ligne.AutoSize = true;
            this.ligne.Location = new System.Drawing.Point(27, 113);
            this.ligne.Name = "ligne";
            this.ligne.Size = new System.Drawing.Size(71, 25);
            this.ligne.TabIndex = 1;
            this.ligne.Text = "Ligne: ";
            // 
            // compagnie
            // 
            this.compagnie.AutoSize = true;
            this.compagnie.Location = new System.Drawing.Point(27, 53);
            this.compagnie.Name = "compagnie";
            this.compagnie.Size = new System.Drawing.Size(124, 25);
            this.compagnie.TabIndex = 0;
            this.compagnie.Text = "Compagnie: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandesToolStripMenuItem,
            this.etatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // commandesToolStripMenuItem
            // 
            this.commandesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réinitialiserToolStripMenuItem});
            this.commandesToolStripMenuItem.Name = "commandesToolStripMenuItem";
            this.commandesToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.commandesToolStripMenuItem.Text = "Commandes";
            // 
            // réinitialiserToolStripMenuItem
            // 
            this.réinitialiserToolStripMenuItem.Name = "réinitialiserToolStripMenuItem";
            this.réinitialiserToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.réinitialiserToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.réinitialiserToolStripMenuItem.Text = "Réinitialiser";
            this.réinitialiserToolStripMenuItem.Click += new System.EventHandler(this.réinitialiserToolStripMenuItem_Click);
            // 
            // etatToolStripMenuItem
            // 
            this.etatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affichageBagageToolStripMenuItem,
            this.attenteBagageToolStripMenuItem,
            this.créationBagageToolStripMenuItem,
            this.selectionBagageToolStripMenuItem,
            this.deconnecterToolStripMenuItem});
            this.etatToolStripMenuItem.Name = "etatToolStripMenuItem";
            this.etatToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.etatToolStripMenuItem.Text = "Etat";
            // 
            // affichageBagageToolStripMenuItem
            // 
            this.affichageBagageToolStripMenuItem.Name = "affichageBagageToolStripMenuItem";
            this.affichageBagageToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.affichageBagageToolStripMenuItem.Text = "Affichage Bagage";
            this.affichageBagageToolStripMenuItem.Click += new System.EventHandler(this.affichageBagageToolStripMenuItem_Click);
            // 
            // attenteBagageToolStripMenuItem
            // 
            this.attenteBagageToolStripMenuItem.Name = "attenteBagageToolStripMenuItem";
            this.attenteBagageToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.attenteBagageToolStripMenuItem.Text = "Attente Bagage";
            this.attenteBagageToolStripMenuItem.Click += new System.EventHandler(this.attenteBagageToolStripMenuItem_Click);
            // 
            // créationBagageToolStripMenuItem
            // 
            this.créationBagageToolStripMenuItem.Name = "créationBagageToolStripMenuItem";
            this.créationBagageToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.créationBagageToolStripMenuItem.Text = "Création Bagage";
            this.créationBagageToolStripMenuItem.Click += new System.EventHandler(this.créationBagageToolStripMenuItem_Click);
            // 
            // selectionBagageToolStripMenuItem
            // 
            this.selectionBagageToolStripMenuItem.Name = "selectionBagageToolStripMenuItem";
            this.selectionBagageToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.selectionBagageToolStripMenuItem.Text = "Selection Bagage";
            this.selectionBagageToolStripMenuItem.Click += new System.EventHandler(this.selectionBagageToolStripMenuItem_Click);
            // 
            // deconnecterToolStripMenuItem
            // 
            this.deconnecterToolStripMenuItem.Name = "deconnecterToolStripMenuItem";
            this.deconnecterToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.deconnecterToolStripMenuItem.Text = "Deconnecter";
            this.deconnecterToolStripMenuItem.Click += new System.EventHandler(this.deconnecterToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.message,
            this.etat});
            this.statusStrip1.Location = new System.Drawing.Point(0, 450);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(915, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // message
            // 
            this.message.AutoSize = false;
            this.message.Margin = new System.Windows.Forms.Padding(0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(300, 25);
            this.message.Text = "Message";
            // 
            // etat
            // 
            this.etat.AutoSize = false;
            this.etat.Margin = new System.Windows.Forms.Padding(0);
            this.etat.Name = "etat";
            this.etat.Size = new System.Drawing.Size(150, 25);
            this.etat.Text = "Affichage Bagage";
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.ItemHeight = 25;
            this.listBoxLogs.Location = new System.Drawing.Point(10, 234);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.Size = new System.Drawing.Size(507, 79);
            this.listBoxLogs.TabIndex = 8;
            // 
            // PIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 475);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbResultat);
            this.Controls.Add(this.gbRecherche);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(933, 600);
            this.MinimumSize = new System.Drawing.Size(933, 470);
            this.Name = "PIM";
            this.Text = "PIM";
            this.gbRecherche.ResumeLayout(false);
            this.gbRecherche.PerformLayout();
            this.gbResultat.ResumeLayout(false);
            this.gbResultat.PerformLayout();
            this.bagage.ResumeLayout(false);
            this.bagage.PerformLayout();
            this.vol.ResumeLayout(false);
            this.vol.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRecherche;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox tbCodeIata;
        private System.Windows.Forms.Label codeIata;
        private System.Windows.Forms.GroupBox gbResultat;
        private System.Windows.Forms.GroupBox bagage;
        private System.Windows.Forms.CheckBox cbPrioritaire;
        private System.Windows.Forms.TextBox tbClasseBagage;
        private System.Windows.Forms.TextBox tbItineraire;
        private System.Windows.Forms.CheckBox cbRush;
        private System.Windows.Forms.CheckBox cbContinuation;
        private System.Windows.Forms.Label classeBagage;
        private System.Windows.Forms.Label itineraire;
        private System.Windows.Forms.GroupBox vol;
        private System.Windows.Forms.TextBox tbJourExploitation;
        private System.Windows.Forms.TextBox tbLigne;
        private System.Windows.Forms.TextBox tbCompagnie;
        private System.Windows.Forms.Label jourExploitation;
        private System.Windows.Forms.Label ligne;
        private System.Windows.Forms.Label compagnie;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem commandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageBagageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attenteBagageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créationBagageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionBagageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réinitialiserToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel message;
        private System.Windows.Forms.ToolStripStatusLabel etat;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxLogs;
    }
}
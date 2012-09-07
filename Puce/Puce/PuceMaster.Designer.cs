namespace Puce
{
    partial class PuceMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuceMaster));
            this.menuPuce = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFileNewArtist = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInventoryArtist = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInventoryAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInventoryGenre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAboutCredit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusPuce = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tssbNew = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiNewArtist = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbListe = new System.Windows.Forms.ToolStripButton();
            this.tsbArtistList = new System.Windows.Forms.ToolStripButton();
            this.menuPuce.SuspendLayout();
            this.statusPuce.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPuce
            // 
            this.menuPuce.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmInventory,
            this.tsmAbout});
            this.menuPuce.Location = new System.Drawing.Point(0, 0);
            this.menuPuce.Name = "menuPuce";
            this.menuPuce.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuPuce.Size = new System.Drawing.Size(941, 24);
            this.menuPuce.TabIndex = 1;
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFileNew,
            this.tsmFileNewArtist,
            this.tsmFileQuit});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(54, 20);
            this.tsmFile.Text = "Fichier";
            // 
            // tsmFileNew
            // 
            this.tsmFileNew.Image = global::Puce.Properties.Resources.cd_new;
            this.tsmFileNew.Name = "tsmFileNew";
            this.tsmFileNew.Size = new System.Drawing.Size(158, 22);
            this.tsmFileNew.Text = "Nouvelle album";
            this.tsmFileNew.Click += new System.EventHandler(this.tsmFileNew_Click);
            // 
            // tsmFileNewArtist
            // 
            this.tsmFileNewArtist.Image = global::Puce.Properties.Resources.window_new;
            this.tsmFileNewArtist.Name = "tsmFileNewArtist";
            this.tsmFileNewArtist.Size = new System.Drawing.Size(158, 22);
            this.tsmFileNewArtist.Text = "Nouvelle artiste";
            this.tsmFileNewArtist.Click += new System.EventHandler(this.tsmFileNewArtist_Click);
            // 
            // tsmFileQuit
            // 
            this.tsmFileQuit.Name = "tsmFileQuit";
            this.tsmFileQuit.Size = new System.Drawing.Size(158, 22);
            this.tsmFileQuit.Text = "Quitter";
            this.tsmFileQuit.Click += new System.EventHandler(this.tsmFileQuit_Click);
            // 
            // tsmInventory
            // 
            this.tsmInventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmInventoryArtist,
            this.tsmInventoryAlbum,
            this.tsmInventoryGenre});
            this.tsmInventory.Name = "tsmInventory";
            this.tsmInventory.Size = new System.Drawing.Size(71, 20);
            this.tsmInventory.Text = "Inventaire";
            // 
            // tsmInventoryArtist
            // 
            this.tsmInventoryArtist.Name = "tsmInventoryArtist";
            this.tsmInventoryArtist.Size = new System.Drawing.Size(152, 22);
            this.tsmInventoryArtist.Text = "Par artist...";
            // 
            // tsmInventoryAlbum
            // 
            this.tsmInventoryAlbum.Name = "tsmInventoryAlbum";
            this.tsmInventoryAlbum.Size = new System.Drawing.Size(152, 22);
            this.tsmInventoryAlbum.Text = "Par album...";
            // 
            // tsmInventoryGenre
            // 
            this.tsmInventoryGenre.Name = "tsmInventoryGenre";
            this.tsmInventoryGenre.Size = new System.Drawing.Size(152, 22);
            this.tsmInventoryGenre.Text = "Par genre...";
            // 
            // tsmAbout
            // 
            this.tsmAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAboutCredit});
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(67, 20);
            this.tsmAbout.Text = "À Propos";
            // 
            // tsmAboutCredit
            // 
            this.tsmAboutCredit.Name = "tsmAboutCredit";
            this.tsmAboutCredit.Size = new System.Drawing.Size(152, 22);
            this.tsmAboutCredit.Text = "Crédits";
            // 
            // statusPuce
            // 
            this.statusPuce.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.statusPuce.Location = new System.Drawing.Point(0, 400);
            this.statusPuce.Name = "statusPuce";
            this.statusPuce.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusPuce.Size = new System.Drawing.Size(941, 22);
            this.statusPuce.TabIndex = 2;
            this.statusPuce.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssbNew,
            this.toolStripSeparator1,
            this.tsbListe,
            this.tsbArtistList});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(941, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "tsPuce";
            // 
            // tssbNew
            // 
            this.tssbNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewArtist,
            this.tsmiNewAlbum});
            this.tssbNew.Image = global::Puce.Properties.Resources.window_new;
            this.tssbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbNew.Name = "tssbNew";
            this.tssbNew.Size = new System.Drawing.Size(86, 22);
            this.tssbNew.Text = "Nouvel...";
            // 
            // tsmiNewArtist
            // 
            this.tsmiNewArtist.Image = global::Puce.Properties.Resources.window_new;
            this.tsmiNewArtist.Name = "tsmiNewArtist";
            this.tsmiNewArtist.Size = new System.Drawing.Size(152, 22);
            this.tsmiNewArtist.Text = "Artiste";
            this.tsmiNewArtist.Click += new System.EventHandler(this.tsmFileNewArtist_Click);
            // 
            // tsmiNewAlbum
            // 
            this.tsmiNewAlbum.Image = global::Puce.Properties.Resources.cd_new;
            this.tsmiNewAlbum.Name = "tsmiNewAlbum";
            this.tsmiNewAlbum.Size = new System.Drawing.Size(152, 22);
            this.tsmiNewAlbum.Text = "Album";
            this.tsmiNewAlbum.Click += new System.EventHandler(this.tsmFileNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbListe
            // 
            this.tsbListe.Image = global::Puce.Properties.Resources.notebook;
            this.tsbListe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbListe.Name = "tsbListe";
            this.tsbListe.Size = new System.Drawing.Size(103, 22);
            this.tsbListe.Text = "Liste d\'albums";
            this.tsbListe.Click += new System.EventHandler(this.tsbListe_Click);
            // 
            // tsbArtistList
            // 
            this.tsbArtistList.Image = global::Puce.Properties.Resources.notebook;
            this.tsbArtistList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbArtistList.Name = "tsbArtistList";
            this.tsbArtistList.Size = new System.Drawing.Size(101, 22);
            this.tsbArtistList.Text = "Liste d\'artistes";
            this.tsbArtistList.Click += new System.EventHandler(this.tsbArtistList_Click);
            // 
            // PuceMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 422);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusPuce);
            this.Controls.Add(this.menuPuce);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPuce;
            this.Name = "PuceMaster";
            this.Text = "Puce Rock";
            this.menuPuce.ResumeLayout(false);
            this.menuPuce.PerformLayout();
            this.statusPuce.ResumeLayout(false);
            this.statusPuce.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPuce;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmFileNew;
        private System.Windows.Forms.ToolStripMenuItem tsmFileQuit;
        private System.Windows.Forms.ToolStripMenuItem tsmInventory;
        private System.Windows.Forms.ToolStripMenuItem tsmInventoryArtist;
        private System.Windows.Forms.ToolStripMenuItem tsmInventoryAlbum;
        private System.Windows.Forms.ToolStripMenuItem tsmInventoryGenre;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmAboutCredit;
        private System.Windows.Forms.StatusStrip statusPuce;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmFileNewArtist;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton tssbNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewArtist;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewAlbum;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbListe;
        private System.Windows.Forms.ToolStripButton tsbArtistList;
    }
}


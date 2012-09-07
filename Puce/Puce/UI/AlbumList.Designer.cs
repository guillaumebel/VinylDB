namespace Puce
{
    partial class AlbumList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumList));
            this.ssAlbum = new System.Windows.Forms.StatusStrip();
            this.tsAlbum = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.grdAlbums = new System.Windows.Forms.DataGridView();
            this.tsAlbum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlbums)).BeginInit();
            this.SuspendLayout();
            // 
            // ssAlbum
            // 
            this.ssAlbum.Location = new System.Drawing.Point(0, 269);
            this.ssAlbum.Name = "ssAlbum";
            this.ssAlbum.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ssAlbum.Size = new System.Drawing.Size(806, 22);
            this.ssAlbum.TabIndex = 0;
            this.ssAlbum.Text = "statusStrip1";
            // 
            // tsAlbum
            // 
            this.tsAlbum.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsAlbum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.toolStripButton1,
            this.tsbDelete});
            this.tsAlbum.Location = new System.Drawing.Point(0, 0);
            this.tsAlbum.Name = "tsAlbum";
            this.tsAlbum.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsAlbum.Size = new System.Drawing.Size(806, 25);
            this.tsAlbum.TabIndex = 1;
            this.tsAlbum.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = global::Puce.Properties.Resources.add2;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Text = "Ajouter";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Puce.Properties.Resources.edit;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Editer";
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::Puce.Properties.Resources.delete2;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "Supprimer";
            // 
            // grdAlbums
            // 
            this.grdAlbums.AllowUserToAddRows = false;
            this.grdAlbums.AllowUserToDeleteRows = false;
            this.grdAlbums.AllowUserToOrderColumns = true;
            this.grdAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAlbums.Location = new System.Drawing.Point(0, 25);
            this.grdAlbums.Name = "grdAlbums";
            this.grdAlbums.ReadOnly = true;
            this.grdAlbums.Size = new System.Drawing.Size(806, 244);
            this.grdAlbums.TabIndex = 2;
            // 
            // AlbumList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 291);
            this.Controls.Add(this.grdAlbums);
            this.Controls.Add(this.tsAlbum);
            this.Controls.Add(this.ssAlbum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlbumList";
            this.Text = "Liste d\'albums";
            this.Load += new System.EventHandler(this.AlbumList_Load);
            this.tsAlbum.ResumeLayout(false);
            this.tsAlbum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlbums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssAlbum;
        private System.Windows.Forms.ToolStrip tsAlbum;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.DataGridView grdAlbums;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
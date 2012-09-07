namespace Puce
{
    partial class AlbumEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumEdit));
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblAlbumName = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtUPCCode = new System.Windows.Forms.TextBox();
            this.lblUPCCode = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMSRP = new System.Windows.Forms.TextBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblMSRP = new System.Windows.Forms.Label();
            this.ddlArtist = new System.Windows.Forms.ComboBox();
            this.tsAlbum = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.tsAlbum.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(12, 35);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(33, 13);
            this.lblArtist.TabIndex = 1;
            this.lblArtist.Text = "Artist:";
            // 
            // lblAlbumName
            // 
            this.lblAlbumName.AutoSize = true;
            this.lblAlbumName.Location = new System.Drawing.Point(12, 61);
            this.lblAlbumName.Name = "lblAlbumName";
            this.lblAlbumName.Size = new System.Drawing.Size(70, 13);
            this.lblAlbumName.TabIndex = 2;
            this.lblAlbumName.Text = "Album Name:";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Location = new System.Drawing.Point(12, 90);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(75, 13);
            this.lblReleaseDate.TabIndex = 4;
            this.lblReleaseDate.Text = "Release Date:";
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(103, 58);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(247, 20);
            this.txtAlbumName.TabIndex = 5;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Location = new System.Drawing.Point(103, 84);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(200, 20);
            this.dtpReleaseDate.TabIndex = 6;
            // 
            // txtUPCCode
            // 
            this.txtUPCCode.Location = new System.Drawing.Point(103, 110);
            this.txtUPCCode.Name = "txtUPCCode";
            this.txtUPCCode.Size = new System.Drawing.Size(146, 20);
            this.txtUPCCode.TabIndex = 9;
            // 
            // lblUPCCode
            // 
            this.lblUPCCode.AutoSize = true;
            this.lblUPCCode.Location = new System.Drawing.Point(12, 113);
            this.lblUPCCode.Name = "lblUPCCode";
            this.lblUPCCode.Size = new System.Drawing.Size(60, 13);
            this.lblUPCCode.TabIndex = 10;
            this.lblUPCCode.Text = "UPC Code:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(103, 137);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(62, 20);
            this.nudQuantity.TabIndex = 11;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 139);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(50, 13);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantité:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(103, 163);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 13;
            // 
            // txtMSRP
            // 
            this.txtMSRP.Location = new System.Drawing.Point(103, 189);
            this.txtMSRP.Name = "txtMSRP";
            this.txtMSRP.Size = new System.Drawing.Size(100, 20);
            this.txtMSRP.TabIndex = 14;
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(12, 166);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(27, 13);
            this.lblPrix.TabIndex = 15;
            this.lblPrix.Text = "Prix:";
            // 
            // lblMSRP
            // 
            this.lblMSRP.AutoSize = true;
            this.lblMSRP.Location = new System.Drawing.Point(12, 192);
            this.lblMSRP.Name = "lblMSRP";
            this.lblMSRP.Size = new System.Drawing.Size(41, 13);
            this.lblMSRP.TabIndex = 16;
            this.lblMSRP.Text = "MSRP:";
            // 
            // ddlArtist
            // 
            this.ddlArtist.FormattingEnabled = true;
            this.ddlArtist.Location = new System.Drawing.Point(103, 35);
            this.ddlArtist.Name = "ddlArtist";
            this.ddlArtist.Size = new System.Drawing.Size(200, 21);
            this.ddlArtist.TabIndex = 17;
            // 
            // tsAlbum
            // 
            this.tsAlbum.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsAlbum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbDelete});
            this.tsAlbum.Location = new System.Drawing.Point(0, 0);
            this.tsAlbum.Name = "tsAlbum";
            this.tsAlbum.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsAlbum.Size = new System.Drawing.Size(358, 25);
            this.tsAlbum.TabIndex = 18;
            this.tsAlbum.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::Puce.Properties.Resources.save2;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "toolStripButton1";
            this.tsbSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::Puce.Properties.Resources.delete2;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "toolStripButton2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 236);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(358, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // AlbumEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 258);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tsAlbum);
            this.Controls.Add(this.ddlArtist);
            this.Controls.Add(this.lblMSRP);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.txtMSRP);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblUPCCode);
            this.Controls.Add(this.txtUPCCode);
            this.Controls.Add(this.dtpReleaseDate);
            this.Controls.Add(this.txtAlbumName);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.lblAlbumName);
            this.Controls.Add(this.lblArtist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlbumEdit";
            this.Text = "Album";
            this.Load += new System.EventHandler(this.AlbumEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.tsAlbum.ResumeLayout(false);
            this.tsAlbum.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblAlbumName;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.TextBox txtAlbumName;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.TextBox txtUPCCode;
        private System.Windows.Forms.Label lblUPCCode;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMSRP;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblMSRP;
        private System.Windows.Forms.ComboBox ddlArtist;
        private System.Windows.Forms.ToolStrip tsAlbum;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
    }
}
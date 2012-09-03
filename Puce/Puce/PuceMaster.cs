using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Puce
{
    /// <summary>
    /// Master MDI Container form
    /// </summary>
    public partial class PuceMaster : Form
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public PuceMaster()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Quit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmFileQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Show the new album form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmFileNew_Click(object sender, EventArgs e)
        {
            AlbumEdit oAlbumEdit = new AlbumEdit();
            oAlbumEdit.MdiParent = this;
            oAlbumEdit.Show();
        }

        /// <summary>
        /// Show the new artist form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmFileNewArtist_Click(object sender, EventArgs e)
        {
            ArtistEdit oArtistEdit = new ArtistEdit();
            oArtistEdit.MdiParent = this;
            oArtistEdit.Show();
        }

        private void tsbListe_Click(object sender, EventArgs e)
        {
            AlbumList oAlbumList = new AlbumList();
            oAlbumList.MdiParent = this;
            oAlbumList.Show();
        }
    }
}

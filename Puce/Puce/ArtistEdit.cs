using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Puce.BO;

namespace Puce
{
    /// <summary>
    /// Artist form
    /// </summary>
    public partial class ArtistEdit : Form
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ArtistEdit()
        {
            InitializeComponent();
        }

        #region "Event"

        /// <summary>
        /// Close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Save the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            Artist oArtist = new Artist();
            oArtist.ArtistName = txtArtist.Text;
            oArtist.ArtistBio = txtBioInfo.Text;
            oArtist.ArtistGenre = txtGenre.Text;

            using (PuceContext db = new PuceContext()) 
            {
                db.Artists.Add(oArtist);
                db.SaveChanges();
            }

            this.Close();
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Puce.Models;

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

        public ArtistEdit(Artist p_oArtist)
        {
            SetupData(p_oArtist);
        }

        #region "Data"
    
        public void SetupData (Artist p_oArtist)
        {
            txtArtist.Text = p_oArtist.ArtistName;
            txtBioInfo.Text = p_oArtist.Description;
            txtGenre.Text = p_oArtist.Genre;

            grdAlbums.DataSource = p_oArtist.Albums;
        }

        public void SaveData()
        {
            Artist oArtist = new Artist();
            oArtist.ArtistName = txtArtist.Text;
            oArtist.Description = txtBioInfo.Text;
            oArtist.Genre = txtGenre.Text;
            oArtist.LastUpdate = DateTime.Now;

            using (VinylDBContext db = new VinylDBContext())
            {
                db.Artists.Add(oArtist);
                db.SaveChanges();
            }
        }

        #endregion

        #region "Event"

        /// <summary>
        /// Close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Save the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {

            SaveData();

            Close();
        }

        #endregion

    }
}

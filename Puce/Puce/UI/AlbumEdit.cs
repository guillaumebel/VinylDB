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
    /// Show album edit
    /// </summary>
    public partial class AlbumEdit : Form
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public AlbumEdit()
        {
            InitializeComponent();
        }

        public AlbumEdit(Album p_oAlbum)
        {
            SetupData(p_oAlbum);
        }

        #region "Data"
        
        public void SetupData(Album p_oAlbum)
        {
            txtAlbumName.Text = p_oAlbum.Name;
            dtpReleaseDate.Value = p_oAlbum.ReleaseDate.Value;
            ddlArtist.SelectedValue = p_oAlbum.Artist;

        }

        public void SaveData()
        {
            Album oAlbum = new Album();
            oAlbum.Name = txtAlbumName.Text;
            oAlbum.ArtistID = (ddlArtist.SelectedValue as ArtistDropDownDisplay).ArtistId;
            oAlbum.LastUpdate = DateTime.Now;
            oAlbum.Quantity = 1;
            oAlbum.ReleaseDate = dtpReleaseDate.Value;

            using (VinylDBContext db = new VinylDBContext())
            {
                db.Albums.Add(oAlbum);
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
            this.Close();
        }

        /// <summary>
        /// Save the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            this.Close();
        }

        private void AlbumEdit_Load(object sender, EventArgs e)
        {
            using (var db = new Puce.Models.VinylDBContext())
            {
                ddlArtist.DataSource = (from u in db.Artists
                                        orderby u.ArtistName
                                        select
                                        new ArtistDropDownDisplay
                                        {
                                            ArtistName = u.ArtistName,
                                            ArtistId = u.ArtistID
                                        }).ToList();
            }
        }
#endregion

       
       
    }

    public class ArtistDropDownDisplay
    {
        public string ArtistName { get; set; }
        public int ArtistId { get; set; }

        public override string ToString()
        {
            return ArtistName;
        }
    }
}

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
    public partial class ArtistList : Form
    {
        public ArtistList()
        {
            InitializeComponent();
        }

        private void AlbumList_Load(object sender, EventArgs e)
        {
            using (VinylDBContext db = new VinylDBContext())
            {
                grdArtist.DataSource = (from a in db.Artists
                                        orderby a.ArtistName
                                        select new ArtistListDisplay
                                        {
                                            ArtistID = a.ArtistID,
                                            ArtistName = a.ArtistName,
                                            Description = a.Description,
                                            Genre = a.Genre,
                                            LastUpdate = a.LastUpdate
                                        }).ToList();
            }
            
        }
    }

    public class ArtistListDisplay
    {
        public int ArtistID { get; set; }
        public string ArtistName { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public DateTime LastUpdate { get; set; }

        public override string ToString()
        {
            return ArtistName;
        }
    }
}

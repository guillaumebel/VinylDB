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
    public partial class AlbumList : Form
    {
        public AlbumList()
        {
            InitializeComponent();
        }

        private void AlbumList_Load(object sender, EventArgs e)
        {
            using (var db = new VinylDBContext())
            {
                grdAlbums.DataSource = (from a in db.Albums
                                       orderby a.Name
                                       select a).ToList();
            }
            
        }
    }
}

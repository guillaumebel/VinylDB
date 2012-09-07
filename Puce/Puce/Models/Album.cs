using System;
using System.Collections.Generic;

namespace Puce.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public int ArtistID { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> ReleaseDate { get; set; }
        public int Quantity { get; set; }
        public System.DateTime LastUpdate { get; set; }
        public virtual Artist Artist { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

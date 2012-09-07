using System;
using System.Collections.Generic;

namespace Puce.Models
{
    public class Artist
    {
        public Artist()
        {
            this.Albums = new List<Album>();
        }

        public int ArtistID { get; set; }
        public string ArtistName { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public System.DateTime LastUpdate { get; set; }
        public virtual ICollection<Album> Albums { get; set; }

        public override string ToString()
        {
            return ArtistName;
        }
    }
}

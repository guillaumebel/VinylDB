using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Puce.BO
{
    class Artist
    {
        public int ArtistId { get; set; }
        public string ArtistName {get; set;}
        public string ArtistBio {get; set;}
        public string ArtistGenre { get; set; }
        public virtual List<Album> ArtistAlbums { get; set; }

    }
}

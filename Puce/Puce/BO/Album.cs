using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Puce.BO
{
    class Album
    {
        public int AlbumId { get; set; }
        public virtual Artist AlbumArtist { get; set; }
        public string AlbumName { get; set; }
        public DateTime AlbumReleaseDate { get; set; }
        public string AlbumRunningTime { get; set; }

        public string AlbumUPCCode { get; set; }
        public int AlbumQuantity { get; set; }
        public decimal AlbumRetailPrice { get; set; }
        public decimal AlbumMSRPPrice { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Puce.BO
{
    class Track
    {
        public int TrackId { get; set; }
        public virtual Album TrackAlbum { get; set; }
        public string TrackName { get; set; }
        public string TrackDuration { get; set; }
    }
}

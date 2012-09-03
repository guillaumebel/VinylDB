using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using  System.Data.Entity;

using Puce.BO;

namespace Puce
{
    class PuceContext : DbContext
    {
        public DbSet<Artist> Artists {get; set;}
        public DbSet<Album> Albums {get; set;}
        public DbSet<Track> Tracks {get; set;}
    }
}

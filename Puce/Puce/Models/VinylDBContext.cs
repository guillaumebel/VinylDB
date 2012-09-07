using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Puce.Models.Mapping;

namespace Puce.Models
{
    public class VinylDBContext : DbContext
    {
        static VinylDBContext()
        {
            Database.SetInitializer<VinylDBContext>(null);
        }

		public VinylDBContext()
			: base("Name=VinylDBContext")
		{
		}

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlbumMap());
            modelBuilder.Configurations.Add(new ArtistMap());
        }
    }
}

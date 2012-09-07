using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Puce.Models.Mapping
{
    public class AlbumMap : EntityTypeConfiguration<Album>
    {
        public AlbumMap()
        {
            // Primary Key
            this.HasKey(t => t.AlbumID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Album");
            this.Property(t => t.AlbumID).HasColumnName("AlbumID");
            this.Property(t => t.ArtistID).HasColumnName("ArtistID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ReleaseDate).HasColumnName("ReleaseDate");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.LastUpdate).HasColumnName("LastUpdate");

            // Relationships
            this.HasRequired(t => t.Artist)
                .WithMany(t => t.Albums)
                .HasForeignKey(d => d.ArtistID);

        }
    }
}

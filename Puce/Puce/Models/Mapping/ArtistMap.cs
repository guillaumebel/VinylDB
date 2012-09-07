using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Puce.Models.Mapping
{
    public class ArtistMap : EntityTypeConfiguration<Artist>
    {
        public ArtistMap()
        {
            // Primary Key
            this.HasKey(t => t.ArtistID);

            // Properties
            this.Property(t => t.ArtistName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(1000);

            this.Property(t => t.Genre)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Artist");
            this.Property(t => t.ArtistID).HasColumnName("ArtistID");
            this.Property(t => t.ArtistName).HasColumnName("ArtistName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Genre).HasColumnName("Genre");
            this.Property(t => t.LastUpdate).HasColumnName("LastUpdate");
        }
    }
}

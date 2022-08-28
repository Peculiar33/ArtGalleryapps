using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Galleryapps.Models.DB_Modles
{
    public partial class ADetailsModel : DbContext
    {
        public ADetailsModel()
            : base("name=ADetailsModel")
        {
        }

        public virtual DbSet<ArtistDetail> ArtistDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArtistDetail>()
                .Property(e => e.Fristname)
                .IsUnicode(false);

            modelBuilder.Entity<ArtistDetail>()
                .Property(e => e.Middlename)
                .IsUnicode(false);

            modelBuilder.Entity<ArtistDetail>()
                .Property(e => e.Lastname)
                .IsUnicode(false);

            modelBuilder.Entity<ArtistDetail>()
                .Property(e => e.Address)
                .IsUnicode(false);
        }
    }
}

namespace NyilvLib.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelNyilv : DbContext
    {
        public ModelNyilv()
            : base("name=ModelNyilv")
        {
        }

        public virtual DbSet<alapadatok> alapadatok { get; set; }
        public virtual DbSet<cegadatok> cegadatok { get; set; }
        public virtual DbSet<dokumentumok> dokumentumok { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<alapadatok>()
                .Property(e => e.Szamlazas)
                .IsUnicode(false);

            modelBuilder.Entity<alapadatok>()
                .Property(e => e.Felelos)
                .IsUnicode(false);

            modelBuilder.Entity<alapadatok>()
                .Property(e => e.Cegnev)
                .IsUnicode(false);

            modelBuilder.Entity<alapadatok>()
                .Property(e => e.Ceg_forma)
                .IsUnicode(false);

            modelBuilder.Entity<alapadatok>()
                .Property(e => e.Hivatkozas)
                .IsUnicode(false);

            modelBuilder.Entity<cegadatok>()
                .Property(e => e.Ceg_teljes_nev)
                .IsUnicode(false);

            modelBuilder.Entity<cegadatok>()
                .Property(e => e.Telephely)
                .IsUnicode(false);

            modelBuilder.Entity<cegadatok>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<cegadatok>()
                .Property(e => e.Telefon)
                .IsUnicode(false);

            modelBuilder.Entity<dokumentumok>()
                .Property(e => e.Dokumentum_tipus)
                .IsUnicode(false);

            modelBuilder.Entity<dokumentumok>()
                .Property(e => e.Megjegyzes)
                .IsUnicode(false);
        }
    }
}

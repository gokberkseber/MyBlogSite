namespace MyBlogSite.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BlogContext : DbContext
    {
        public BlogContext()
            : base("name=BlogContext")
        {
        }

        public virtual DbSet<Etiket> Etiket { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<KullaniciRol> KullaniciRol { get; set; }
        public virtual DbSet<Makale> Makale { get; set; }
        public virtual DbSet<Resim> Resim { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Etiket>()
                .HasMany(e => e.Makale)
                .WithMany(e => e.Etiket)
                .Map(m => m.ToTable("MakaleEtiket").MapLeftKey("EtiketID").MapRightKey("MakaleID"));

            modelBuilder.Entity<Kategori>()
                .HasMany(e => e.Makale)
                .WithRequired(e => e.Kategori)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.KullaniciRol)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.Makale)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.KullaniciRol)
                .WithRequired(e => e.Rol)
                .WillCascadeOnDelete(false);
        }
    }
}

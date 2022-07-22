using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MiniWebShop.Models
{
    public partial class WebShopModel : DbContext
    {
        public WebShopModel()
            : base("name=WebShopEntityModel")
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Nacin_placanja> Nacin_placanja { get; set; }
        public virtual DbSet<Narudzba> Narudzbas { get; set; }
        public virtual DbSet<Narudzba_proizvodi> Narudzba_proizvodi { get; set; }
        public virtual DbSet<Popust_kodovi> Popust_kodovi { get; set; }
        public virtual DbSet<Proizvod> Proizvods { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .Property(e => e.Naziv)
                .IsFixedLength();

            modelBuilder.Entity<Brand>()
                .HasMany(e => e.Proizvods)
                .WithRequired(e => e.Brand)
                .HasForeignKey(e => e.Brand_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nacin_placanja>()
                .Property(e => e.Naziv)
                .IsFixedLength();

            modelBuilder.Entity<Nacin_placanja>()
                .HasMany(e => e.Narudzbas)
                .WithRequired(e => e.Nacin_placanja)
                .HasForeignKey(e => e.Nacin_placanja_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Narudzba>()
                .Property(e => e.Ukupna_cijena_bez_p)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Narudzba>()
                .Property(e => e.Ukupna_cijena_s_p)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Narudzba>()
                .Property(e => e.Broj_kartice)
                .IsFixedLength();

            modelBuilder.Entity<Narudzba>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Narudzba>()
                .Property(e => e.Adresa_dostave)
                .IsFixedLength();

            modelBuilder.Entity<Narudzba>()
                .Property(e => e.Napomena)
                .IsFixedLength();

            modelBuilder.Entity<Narudzba>()
                .HasOptional(e => e.Narudzba_proizvodi)
                .WithRequired(e => e.Narudzba);

            modelBuilder.Entity<Popust_kodovi>()
                .Property(e => e.Kod)
                .IsFixedLength();

            modelBuilder.Entity<Popust_kodovi>()
                .Property(e => e.Popust)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Popust_kodovi>()
                .HasMany(e => e.Narudzbas)
                .WithRequired(e => e.Popust_kodovi)
                .HasForeignKey(e => e.Kod_za_popust_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proizvod>()
                .Property(e => e.Naziv)
                .IsFixedLength();

            modelBuilder.Entity<Proizvod>()
                .Property(e => e.Opis)
                .IsFixedLength();

            modelBuilder.Entity<Proizvod>()
                .Property(e => e.Cijena)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Proizvod>()
                .HasOptional(e => e.Narudzba_proizvodi)
                .WithRequired(e => e.Proizvod);
        }
    }
}

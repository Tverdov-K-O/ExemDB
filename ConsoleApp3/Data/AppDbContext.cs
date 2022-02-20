using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;

namespace ConsoleApp3.Data.Entities
{
    public partial class AppDbContext : DbContext
    {
        
        public AppDbContext()
            : base("name=AppDbContext")
        {
        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Poduct> Poducts { get; set; }
        public virtual DbSet<Quality> Qualities { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<Vender> Venders { get; set; }
        public virtual DbSet<Pivot> Pivots { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Poducts)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Color>()
                .HasMany(e => e.Pivots)
                .WithRequired(e => e.Color)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gender>()
                .HasMany(e => e.Pivots)
                .WithRequired(e => e.Gender)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Poduct>()
                .HasMany(e => e.Pivots)
                .WithRequired(e => e.Poduct)
                .HasForeignKey(e => e.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Quality>()
                .HasMany(e => e.Poducts)
                .WithRequired(e => e.Quality)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Size>()
                .HasMany(e => e.Pivots)
                .WithRequired(e => e.Size)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vender>()
                .HasMany(e => e.Poducts)
                .WithRequired(e => e.Vender)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pivot>()
                .Property(e => e.Prise)
                .HasPrecision(19, 4);
        }
    }
}

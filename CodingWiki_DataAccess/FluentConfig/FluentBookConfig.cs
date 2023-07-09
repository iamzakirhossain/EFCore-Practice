using CodingWiki_Models.Models.FluentModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_DataAccess.FluentConfig
{
    public class FluentBookConfig : IEntityTypeConfiguration<Fluent_Book>
    {
        public void Configure(EntityTypeBuilder<Fluent_Book> modelBuilder)
        {
            //modelBuilder.Entity<Fluent_Book>().HasKey(u => u.Book_Id);
            //modelBuilder.Entity<Fluent_Book>().Property(u => u.ISBN).HasMaxLength(20);
            //modelBuilder.Entity<Fluent_Book>().Property(u => u.ISBN).IsRequired();
            //modelBuilder.Entity<Fluent_Book>().Ignore(u => u.PriceRange);

            ////One to Many Start
            //modelBuilder.Entity<Fluent_Book>()
            //    .HasOne(p => p.Publisher)
            //    .WithMany(b => b.Books)
            //    .HasForeignKey(u => u.Publisher_Id);
            ////One to Many End
            ///

            modelBuilder.HasKey(u => u.Book_Id);
            modelBuilder.Property(u => u.ISBN).HasMaxLength(20);
            modelBuilder.Property(u => u.ISBN).IsRequired();
            modelBuilder.Ignore(u => u.PriceRange);

            //One to Many Start
            modelBuilder.HasOne(p => p.Publisher)
                .WithMany(b => b.Books)
                .HasForeignKey(u => u.Publisher_Id);
            //One to Many End

        }
    }
}

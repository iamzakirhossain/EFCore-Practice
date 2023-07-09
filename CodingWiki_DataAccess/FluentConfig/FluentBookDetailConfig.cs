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
    public class FluentBookDetailConfig : IEntityTypeConfiguration<Fluent_BookDetail>
    {
        public void Configure(EntityTypeBuilder<Fluent_BookDetail> modelBuilder)
        {
            ////Change Table Name
            //modelBuilder.Entity<Fluent_BookDetail>().ToTable("Fluent_BookDetails");
            ////Change Column Name
            //modelBuilder.Entity<Fluent_BookDetail>()
            //    .Property(u => u.NumberOfChapters)
            //    .HasColumnName("NoOfChapters");
            //modelBuilder.Entity<Fluent_BookDetail>()
            //    .Property(u => u.NumberOfChapters)
            //    .IsRequired();
            //modelBuilder.Entity<Fluent_BookDetail>().HasKey(u => u.BookDetail_Id);

            ////One to One Start
            //modelBuilder.Entity<Fluent_BookDetail>()
            //    .HasOne(b => b.Book)
            //    .WithOne(bd => bd.BookDetail)
            //    .HasForeignKey<Fluent_BookDetail>(u => u.Book_Id);

            ////One to One End
            ///

            //Change Table Name
            modelBuilder.ToTable("Fluent_BookDetails");
            //Change Column Name
            modelBuilder.Property(u => u.NumberOfChapters)
                .HasColumnName("NoOfChapters");
            modelBuilder.Property(u => u.NumberOfChapters)
                .IsRequired();
            modelBuilder.HasKey(u => u.BookDetail_Id);

            //One to One Start
            modelBuilder.HasOne(b => b.Book)
                .WithOne(bd => bd.BookDetail)
                .HasForeignKey<Fluent_BookDetail>(u => u.Book_Id);

            //One to One End
        }
    }
}

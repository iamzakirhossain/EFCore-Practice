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
    public class FluentAuthorBookConfig : IEntityTypeConfiguration<Fluent_AuthorBook>
    {
        public void Configure(EntityTypeBuilder<Fluent_AuthorBook> modelBuilder)
        {
            ////Many to Many Start
            //modelBuilder.Entity<Fluent_AuthorBook>()
            //    .HasKey(u => new { u.Book_Id, u.Author_Id });

            //modelBuilder.Entity<Fluent_AuthorBook>()
            //    .HasOne(b => b.Book)
            //    .WithMany(ba => ba.AuthorBooks)
            //    .HasForeignKey(u => u.Book_Id);

            //modelBuilder.Entity<Fluent_AuthorBook>()
            //    .HasOne(a => a.Author)
            //    .WithMany(ba => ba.AuthorBooks)
            //    .HasForeignKey(u => u.Author_Id);
            ////Many to Many End
            ///

            //Many to Many Start
            modelBuilder.HasKey(u => new { u.Book_Id, u.Author_Id });

            modelBuilder.HasOne(b => b.Book)
                .WithMany(ba => ba.AuthorBooks)
                .HasForeignKey(u => u.Book_Id);

            modelBuilder.HasOne(a => a.Author)
                .WithMany(ba => ba.AuthorBooks)
                .HasForeignKey(u => u.Author_Id);
            //Many to Many End
        }
    }
}

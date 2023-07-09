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
    public class FluentAuthorConfig: IEntityTypeConfiguration<Fluent_Author>
    {
       public void Configure(EntityTypeBuilder<Fluent_Author> modelBuilder)
       {
            //modelBuilder.Entity<Fluent_Author>().HasKey(u => u.Author_Id);
            //modelBuilder.Entity<Fluent_Author>().Property(u => u.FirstName).IsRequired();
            //modelBuilder.Entity<Fluent_Author>().Property(u => u.FirstName).HasMaxLength(50);
            //modelBuilder.Entity<Fluent_Author>().Property(u => u.LastName).IsRequired();
            //modelBuilder.Entity<Fluent_Author>().Ignore(u => u.FullName);

            modelBuilder.HasKey(u => u.Author_Id);
            modelBuilder.Property(u => u.FirstName).IsRequired();
            modelBuilder.Property(u => u.FirstName).HasMaxLength(50);
            modelBuilder.Property(u => u.LastName).IsRequired();
            modelBuilder.Ignore(u => u.FullName);
        }
    }
}

using CodingWiki_DataAccess.FluentConfig;
using CodingWiki_Models.Models;
using CodingWiki_Models.Models.FluentModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
                
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<AuthorBook> AuthorBooks { get; set; }

        //Fluent Start
        //Rename to Fluent_BookDetails
        public DbSet<Fluent_BookDetail> BookDetail_Fluents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
           // options.UseSqlServer("Server=localhost\\SQLEXPRESS; Database=CodingWikiDB; Trusted_Connection=True; TrustServerCertificate=True; MultipleActiveResultSets=True;")
              //  .LogTo(Console.WriteLine, new[] {DbLoggerCategory.Database.Command.Name}, LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent Start
            modelBuilder.ApplyConfiguration(new FluentAuthorBookConfig());
            modelBuilder.ApplyConfiguration(new FluentAuthorConfig());
            modelBuilder.ApplyConfiguration(new FluentBookConfig());
            modelBuilder.ApplyConfiguration(new FluentBookDetailConfig());
            modelBuilder.ApplyConfiguration(new FluentPublisherConfig());

            //Fluent End



            modelBuilder.Entity<Book>().Property(u => u.Price).HasPrecision(10, 5);
            modelBuilder.Entity<AuthorBook>().HasKey(u => new { u.BookId, u.AuthorId });



            //Seed Data
            modelBuilder.Entity<Book>().HasData(
               new Book { BookId=1, Title="Chemistry", ISBN ="CCCC", Price=10.99M, PublisherId = 1 }, 
               new Book { BookId=2, Title="Physics", ISBN ="PPPP", Price=11.99M, PublisherId = 2 } 
            );

            //Seed Data (Another way)
            var bookList = new Book[]
            {
               new Book { BookId=3, Title="Math", ISBN ="MMMM", Price=12.99M, PublisherId=2},
               new Book { BookId=4, Title="Biology", ISBN ="BBBB", Price=13.99M, PublisherId=3}
            };

            modelBuilder.Entity<Book>().HasData(bookList);

            var publisherList = new Publisher[]
            {
                new Publisher{PublisherId=1, Name="Sheba", Location="New Market"},
                new Publisher{PublisherId=2, Name="Ononno", Location="Mirpur"},
                new Publisher{PublisherId=3, Name="Onnorokom", Location="Gulshan"},
                
            };

            modelBuilder.Entity<Publisher>().HasData(publisherList);

            var categoryList = new Category[]
            {
                new Category{CategoryId=1, CategoryName = "Cat 1"},
                new Category{CategoryId=2, CategoryName = "Cat 2"},
                new Category{CategoryId=3, CategoryName = "Cat 3"}
            };

            modelBuilder.Entity<Category>().HasData(categoryList);
        }
    }
}

// See https://aka.ms/new-console-template for more information
using CodingWiki_DataAccess.Data;
using CodingWiki_DataAccess.Migrations;
using CodingWiki_Models.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

//using(ApplicationDbContext context= new())
//{
//    context.Database.EnsureCreated();

//    if(context.Database.GetPendingMigrations().Count() > 0)
//    {
//        context.Database.Migrate();
//    }
//}

//AddBook();
//GetAllBooks();
//GetBook();
//Sorting();
//Pagination();
//UpdateBook();
//DeleteBook();

//void DeleteBook()
//{
//    using var context = new ApplicationDbContext();
//    var book = context.Books.Find(1);
//    context.Books.Remove(book);
//    context.SaveChanges();
//}

//void UpdateBook()
//{
//    using var context = new ApplicationDbContext();
//    var book = context.Books.Find(1);
//    book.ISBN = "FFFFFFFF";
//    context.SaveChanges();
//}

//void Pagination()
//{
//    using var context = new ApplicationDbContext();
//    var books = context.Books.Skip(0).Take(2);
//    foreach (var item in books)
//    {
//        Console.WriteLine(item.Title + " - " + item.ISBN);
//    }

//    var books2 = context.Books.Skip(3).Take(1);
//    foreach (var item in books2)
//    {
//        Console.WriteLine(item.Title + " - " + item.ISBN);
//    }
//}

//void Sorting()
//{
//    using var context = new ApplicationDbContext();
//    //var books = context.Books.OrderBy(u=> u.Title).OrderByDescending(u=>u.ISBN);
//    var books = context.Books.OrderBy(u=> u.Title).ThenByDescending(u=>u.ISBN);
//    foreach (var item in books)
//    {
//        Console.WriteLine(item.Title + " - " + item.ISBN);
//    }

//}

//void GetBook()
//{
//    using var context = new ApplicationDbContext();
//    //var book = context.Books.Where(u=> u.PublisherId==3 && u.Price>10).FirstOrDefault();
//    //var book = context.Books.FirstOrDefault(u => u.PublisherId == 3 && u.Price > 10);
//    //var book = context.Books.Find(2);
//    //var book = context.Books.SingleOrDefault(u => u.PublisherId == 3 && u.Price > 10);
//    //var books = context.Books.Where(u => u.Title.Contains("try"));
//    //var books = context.Books.Where(u => EF.Functions.Like(u.Title, "%try%"));
//    var book = context.Books.Where(u => EF.Functions.Like(u.Title, "%try%")).Max(u => u.Price); //It will find the price

//    //foreach (var item in books)
//    //{
//    //    Console.WriteLine(item.Title + " - " + item.ISBN);
//    //}

//    Console.WriteLine(book);
//}

//void GetAllBooks()
//{
//    using var context = new ApplicationDbContext();
//    var books = context.Books.ToList();

//    foreach (var item in books)
//    {
//        Console.WriteLine(item.Title + " - " + item.ISBN);
//    }
//}

//void AddBook()
//{
//    var book = new Book() { Title = "CSE", ISBN = "EEEE", Price = 13.99M, PublisherId = 1 };
//    using var context = new ApplicationDbContext();
//    context.Books.Add(book);
//    context.SaveChanges();
//}
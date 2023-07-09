﻿// <auto-generated />
using System;
using CodingWiki_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230709042242_SeedCategory")]
    partial class SeedCategory
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CodingWiki_Models.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.AuthorBook", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("AuthorBooks");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 5)
                        .HasColumnType("decimal(10,5)");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            ISBN = "CCCC",
                            Price = 10.99m,
                            PublisherId = 1,
                            Title = "Chemistry"
                        },
                        new
                        {
                            BookId = 2,
                            ISBN = "PPPP",
                            Price = 11.99m,
                            PublisherId = 2,
                            Title = "Physics"
                        },
                        new
                        {
                            BookId = 3,
                            ISBN = "MMMM",
                            Price = 12.99m,
                            PublisherId = 2,
                            Title = "Math"
                        },
                        new
                        {
                            BookId = 4,
                            ISBN = "BBBB",
                            Price = 13.99m,
                            PublisherId = 3,
                            Title = "Biology"
                        });
                });

            modelBuilder.Entity("CodingWiki_Models.Models.BookDetail", b =>
                {
                    b.Property<int>("BookDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookDetailId"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfChapters")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("BookDetailId");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.ToTable("BookDetails");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Cat 1"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Cat 2"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Cat 3"
                        });
                });

            modelBuilder.Entity("CodingWiki_Models.Models.FluentModels.Fluent_Author", b =>
                {
                    b.Property<int>("Author_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Author_Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Author_Id");

                    b.ToTable("Fluent_Author");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.FluentModels.Fluent_AuthorBook", b =>
                {
                    b.Property<int>("Book_Id")
                        .HasColumnType("int");

                    b.Property<int>("Author_Id")
                        .HasColumnType("int");

                    b.HasKey("Book_Id", "Author_Id");

                    b.HasIndex("Author_Id");

                    b.ToTable("Fluent_AuthorBook");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.FluentModels.Fluent_Book", b =>
                {
                    b.Property<int>("Book_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Book_Id"));

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Publisher_Id")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Book_Id");

                    b.HasIndex("Publisher_Id");

                    b.ToTable("Fluent_Book");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.FluentModels.Fluent_BookDetail", b =>
                {
                    b.Property<int>("BookDetail_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookDetail_Id"));

                    b.Property<int>("Book_Id")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfChapters")
                        .HasColumnType("int")
                        .HasColumnName("NoOfChapters");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("BookDetail_Id");

                    b.HasIndex("Book_Id")
                        .IsUnique();

                    b.ToTable("Fluent_BookDetails", (string)null);
                });

            modelBuilder.Entity("CodingWiki_Models.Models.FluentModels.Fluent_Publisher", b =>
                {
                    b.Property<int>("Publisher_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Publisher_Id"));

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Publisher_Id");

                    b.ToTable("Fluent_Publisher");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.Publisher", b =>
                {
                    b.Property<int>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PublisherId"));

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PublisherId");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            PublisherId = 1,
                            Location = "New Market",
                            Name = "Sheba"
                        },
                        new
                        {
                            PublisherId = 2,
                            Location = "Mirpur",
                            Name = "Ononno"
                        },
                        new
                        {
                            PublisherId = 3,
                            Location = "Gulshan",
                            Name = "Onnorokom"
                        });
                });

            modelBuilder.Entity("CodingWiki_Models.Models.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubCategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SubCategoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.AuthorBook", b =>
                {
                    b.HasOne("CodingWiki_Models.Models.Author", "Author")
                        .WithMany("AuthorBooks")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodingWiki_Models.Models.Book", "Book")
                        .WithMany("AuthorBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.Book", b =>
                {
                    b.HasOne("CodingWiki_Models.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.BookDetail", b =>
                {
                    b.HasOne("CodingWiki_Models.Models.Book", "Book")
                        .WithOne("BookDetail")
                        .HasForeignKey("CodingWiki_Models.Models.BookDetail", "BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.FluentModels.Fluent_AuthorBook", b =>
                {
                    b.HasOne("CodingWiki_Models.Models.FluentModels.Fluent_Author", "Author")
                        .WithMany("AuthorBooks")
                        .HasForeignKey("Author_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodingWiki_Models.Models.FluentModels.Fluent_Book", "Book")
                        .WithMany("AuthorBooks")
                        .HasForeignKey("Book_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.FluentModels.Fluent_Book", b =>
                {
                    b.HasOne("CodingWiki_Models.Models.FluentModels.Fluent_Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("Publisher_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.FluentModels.Fluent_BookDetail", b =>
                {
                    b.HasOne("CodingWiki_Models.Models.FluentModels.Fluent_Book", "Book")
                        .WithOne("BookDetail")
                        .HasForeignKey("CodingWiki_Models.Models.FluentModels.Fluent_BookDetail", "Book_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.Author", b =>
                {
                    b.Navigation("AuthorBooks");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.Book", b =>
                {
                    b.Navigation("AuthorBooks");

                    b.Navigation("BookDetail");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.FluentModels.Fluent_Author", b =>
                {
                    b.Navigation("AuthorBooks");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.FluentModels.Fluent_Book", b =>
                {
                    b.Navigation("AuthorBooks");

                    b.Navigation("BookDetail");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.FluentModels.Fluent_Publisher", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
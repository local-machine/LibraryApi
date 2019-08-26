﻿// <auto-generated />
using LibraryApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryApi.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20190826221940_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LibraryApi.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("AuthorId");

                    b.ToTable("authors");
                });

            modelBuilder.Entity("LibraryApi.Models.AuthorBook", b =>
                {
                    b.Property<int>("AuthorBookId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthorId");

                    b.Property<int>("BookId");

                    b.HasKey("AuthorBookId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("LibraryApi.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Genre");

                    b.Property<string>("Title");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LibraryApi.Models.Copy", b =>
                {
                    b.Property<int>("CopyId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookId");

                    b.HasKey("CopyId");

                    b.HasIndex("BookId");

                    b.ToTable("copies");
                });

            modelBuilder.Entity("LibraryApi.Models.AuthorBook", b =>
                {
                    b.HasOne("LibraryApi.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LibraryApi.Models.Book", "Book")
                        .WithMany("Authors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LibraryApi.Models.Copy", b =>
                {
                    b.HasOne("LibraryApi.Models.Book", "Book")
                        .WithMany("Copies")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

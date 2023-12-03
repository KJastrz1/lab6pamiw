﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P05Shop.API.Models;

#nullable disable

namespace P05Shop.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("P06Shop.Shared.Auth.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("P06Shop.Shared.MovieModel.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Director = "Nazariusz Szeląg",
                            Title = "Gorgeous Wooden Chair"
                        },
                        new
                        {
                            Id = 2,
                            Director = "Władysław Stępień",
                            Title = "Sleek Concrete Shirt"
                        },
                        new
                        {
                            Id = 3,
                            Director = "Klaudiusz Rogowski",
                            Title = "Ergonomic Plastic Soap"
                        },
                        new
                        {
                            Id = 4,
                            Director = "Eleonora Buczkowski",
                            Title = "Refined Metal Tuna"
                        },
                        new
                        {
                            Id = 5,
                            Director = "Natalia Błaszczak",
                            Title = "Sleek Wooden Chicken"
                        },
                        new
                        {
                            Id = 6,
                            Director = "Eudokia Michałowski",
                            Title = "Incredible Steel Chair"
                        },
                        new
                        {
                            Id = 7,
                            Director = "Klemens Szymański",
                            Title = "Fantastic Rubber Salad"
                        },
                        new
                        {
                            Id = 8,
                            Director = "Filemon Pieczek",
                            Title = "Ergonomic Metal Shoes"
                        },
                        new
                        {
                            Id = 9,
                            Director = "Arkadiusz Kaźmierczak",
                            Title = "Rustic Soft Car"
                        },
                        new
                        {
                            Id = 10,
                            Director = "Aleksander Kaczorowski",
                            Title = "Ergonomic Metal Hat"
                        },
                        new
                        {
                            Id = 11,
                            Director = "Lea Skalski",
                            Title = "Practical Cotton Mouse"
                        },
                        new
                        {
                            Id = 12,
                            Director = "Gerald Madej",
                            Title = "Rustic Cotton Keyboard"
                        },
                        new
                        {
                            Id = 13,
                            Director = "Wilhelmina Krawiec",
                            Title = "Fantastic Concrete Chicken"
                        },
                        new
                        {
                            Id = 14,
                            Director = "Jakub Nowaczyk",
                            Title = "Sleek Cotton Shoes"
                        },
                        new
                        {
                            Id = 15,
                            Director = "Aleksy Wiśniewski",
                            Title = "Rustic Concrete Bike"
                        },
                        new
                        {
                            Id = 16,
                            Director = "Walenty Andrzejewski",
                            Title = "Handmade Steel Tuna"
                        },
                        new
                        {
                            Id = 17,
                            Director = "Mikołaj Cholewa",
                            Title = "Generic Rubber Chips"
                        },
                        new
                        {
                            Id = 18,
                            Director = "Modest Rogowski",
                            Title = "Small Cotton Computer"
                        },
                        new
                        {
                            Id = 19,
                            Director = "Renata Góral",
                            Title = "Handcrafted Rubber Bike"
                        },
                        new
                        {
                            Id = 20,
                            Director = "Karolina Tracz",
                            Title = "Tasty Steel Car"
                        },
                        new
                        {
                            Id = 21,
                            Director = "Paweł Dudziński",
                            Title = "Generic Concrete Bike"
                        },
                        new
                        {
                            Id = 22,
                            Director = "Ofelia Adamczyk",
                            Title = "Gorgeous Wooden Mouse"
                        },
                        new
                        {
                            Id = 23,
                            Director = "Izajasz Urbańczyk",
                            Title = "Small Soft Tuna"
                        },
                        new
                        {
                            Id = 24,
                            Director = "Olga Krawiec",
                            Title = "Refined Concrete Gloves"
                        },
                        new
                        {
                            Id = 25,
                            Director = "Wilfryd Wąsowski",
                            Title = "Ergonomic Plastic Computer"
                        },
                        new
                        {
                            Id = 26,
                            Director = "Justyna Wolak",
                            Title = "Generic Frozen Gloves"
                        },
                        new
                        {
                            Id = 27,
                            Director = "Koralia Konieczny",
                            Title = "Handcrafted Steel Chips"
                        },
                        new
                        {
                            Id = 28,
                            Director = "Gilbert Turek",
                            Title = "Fantastic Plastic Towels"
                        },
                        new
                        {
                            Id = 29,
                            Director = "Miron Piasecki",
                            Title = "Licensed Concrete Bike"
                        },
                        new
                        {
                            Id = 30,
                            Director = "Apollinary Kołodziejczyk",
                            Title = "Refined Frozen Chips"
                        },
                        new
                        {
                            Id = 31,
                            Director = "Gwido Sołtysiak",
                            Title = "Licensed Metal Mouse"
                        },
                        new
                        {
                            Id = 32,
                            Director = "Samson Modzelewski",
                            Title = "Incredible Wooden Chicken"
                        },
                        new
                        {
                            Id = 33,
                            Director = "Wiktoria Jasiński",
                            Title = "Gorgeous Fresh Shirt"
                        },
                        new
                        {
                            Id = 34,
                            Director = "Olimpia Kędziora",
                            Title = "Small Soft Chips"
                        },
                        new
                        {
                            Id = 35,
                            Director = "Albert Nawrot",
                            Title = "Sleek Rubber Computer"
                        },
                        new
                        {
                            Id = 36,
                            Director = "Filipa Bożek",
                            Title = "Refined Wooden Cheese"
                        },
                        new
                        {
                            Id = 37,
                            Director = "Nazary Czajka",
                            Title = "Generic Steel Ball"
                        },
                        new
                        {
                            Id = 38,
                            Director = "Nina Bielak",
                            Title = "Tasty Fresh Cheese"
                        },
                        new
                        {
                            Id = 39,
                            Director = "Kornelia Olszewski",
                            Title = "Incredible Metal Computer"
                        },
                        new
                        {
                            Id = 40,
                            Director = "Artur Niedzielski",
                            Title = "Unbranded Fresh Bike"
                        },
                        new
                        {
                            Id = 41,
                            Director = "Zachary Wiącek",
                            Title = "Small Frozen Car"
                        },
                        new
                        {
                            Id = 42,
                            Director = "Beatrycze Wójcik",
                            Title = "Rustic Rubber Keyboard"
                        },
                        new
                        {
                            Id = 43,
                            Director = "Pankracy Wypych",
                            Title = "Intelligent Plastic Cheese"
                        },
                        new
                        {
                            Id = 44,
                            Director = "Martyna Kaczmarczyk",
                            Title = "Intelligent Rubber Chair"
                        },
                        new
                        {
                            Id = 45,
                            Director = "Malwina Duda",
                            Title = "Intelligent Steel Car"
                        },
                        new
                        {
                            Id = 46,
                            Director = "Pankracy Pietrzak",
                            Title = "Refined Granite Shoes"
                        },
                        new
                        {
                            Id = 47,
                            Director = "Laurenty Banach",
                            Title = "Small Fresh Chicken"
                        },
                        new
                        {
                            Id = 48,
                            Director = "Reginald Zawadzki",
                            Title = "Handcrafted Frozen Chicken"
                        },
                        new
                        {
                            Id = 49,
                            Director = "Stella Szczygieł",
                            Title = "Fantastic Metal Keyboard"
                        },
                        new
                        {
                            Id = 50,
                            Director = "Florencja Kowalski",
                            Title = "Tasty Fresh Chicken"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

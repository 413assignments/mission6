﻿// <auto-generated />
using System;
using MIssion06_Bassett.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MIssion06_Bassett.Migrations
{
    [DbContext(typeof(MoviesContext))]
    partial class MoviesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("MIssion06_Bassett.Models.Category", b =>
                {
                    b.Property<int>("categoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("categoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("categoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MIssion06_Bassett.Models.Movie", b =>
                {
                    b.Property<int>("movieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("categoryID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("copiedToPlex")
                        .HasColumnType("INTEGER");

                    b.Property<string>("director")
                        .HasColumnType("TEXT");

                    b.Property<bool>("edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("lentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("notes")
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("rating")
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("year")
                        .HasColumnType("INTEGER");

                    b.HasKey("movieID");

                    b.HasIndex("categoryID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MIssion06_Bassett.Models.Movie", b =>
                {
                    b.HasOne("MIssion06_Bassett.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("categoryID");

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}

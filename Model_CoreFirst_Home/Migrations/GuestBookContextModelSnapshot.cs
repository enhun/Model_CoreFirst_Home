﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model_CoreFirst_Home.Models;

#nullable disable

namespace Model_CoreFirst_Home.Migrations
{
    [DbContext(typeof(GuestBookContext))]
    partial class GuestBookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Model_CoreFirst_Home.Models.Book", b =>
                {
                    b.Property<string>("BookID")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasMaxLength(44)
                        .HasColumnType("nvarchar(44)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("BookID");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Model_CoreFirst_Home.Models.ReBook", b =>
                {
                    b.Property<string>("ReBookID")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("BookID")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("ReBookID");

                    b.HasIndex("BookID");

                    b.ToTable("ReBook");
                });

            modelBuilder.Entity("Model_CoreFirst_Home.Models.ReBook", b =>
                {
                    b.HasOne("Model_CoreFirst_Home.Models.Book", "Book")
                        .WithMany("ReBooks")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Model_CoreFirst_Home.Models.Book", b =>
                {
                    b.Navigation("ReBooks");
                });
#pragma warning restore 612, 618
        }
    }
}

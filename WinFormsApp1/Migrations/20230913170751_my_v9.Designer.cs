﻿// <auto-generated />
using System;
using EFD2.mymodels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WinFormsApp1.Migrations
{
    [DbContext(typeof(ITIContex))]
    [Migration("20230913170751_my_v9")]
    partial class my_v9
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFD2.mymodels.Author", b =>
                {
                    b.Property<int>("Auth_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Auth_id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.HasKey("Auth_id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("EFD2.mymodels.Catalog", b =>
                {
                    b.Property<int>("Cat_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cat_id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cat_id");

                    b.ToTable("Catalogs");
                });

            modelBuilder.Entity("EFD2.mymodels.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Auth_id")
                        .HasColumnType("int");

                    b.Property<int?>("AuthorAuth_id")
                        .HasColumnType("int");

                    b.Property<string>("Bref")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Cat_id")
                        .HasColumnType("int");

                    b.Property<int?>("CatalogCat_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorAuth_id");

                    b.HasIndex("CatalogCat_id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("EFD2.mymodels.Post", b =>
                {
                    b.HasOne("EFD2.mymodels.Author", null)
                        .WithMany("posts_auth")
                        .HasForeignKey("AuthorAuth_id");

                    b.HasOne("EFD2.mymodels.Catalog", null)
                        .WithMany("posts_cat")
                        .HasForeignKey("CatalogCat_id");
                });

            modelBuilder.Entity("EFD2.mymodels.Author", b =>
                {
                    b.Navigation("posts_auth");
                });

            modelBuilder.Entity("EFD2.mymodels.Catalog", b =>
                {
                    b.Navigation("posts_cat");
                });
#pragma warning restore 612, 618
        }
    }
}

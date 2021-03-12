﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iwp.Entity;

namespace iwp.Migrations
{
    [DbContext(typeof(NewsContext))]
    [Migration("20210110161229_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("iwp.Models.Category", b =>
                {
                    b.Property<int>("categoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("categoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("iwp.Models.News", b =>
                {
                    b.Property<int>("haberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("categoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("haberBasligi")
                        .HasColumnType("TEXT");

                    b.Property<string>("haberIcerigi")
                        .HasColumnType("TEXT");

                    b.Property<string>("haberKaynagi")
                        .HasColumnType("TEXT");

                    b.Property<string>("haberResmi")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("haberTarihi")
                        .HasColumnType("TEXT");

                    b.Property<int>("haberTiklanmasi")
                        .HasColumnType("INTEGER");

                    b.Property<string>("haberYazari")
                        .HasColumnType("TEXT");

                    b.HasKey("haberId");

                    b.ToTable("News");
                });
#pragma warning restore 612, 618
        }
    }
}

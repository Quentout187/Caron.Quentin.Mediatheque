﻿// <auto-generated />
using System;
using Mediatheque.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mediatheque.Core.Migrations
{
    [DbContext(typeof(ApplicationDBcontexte))]
    [Migration("20240409143903_CDModif")]
    partial class CDModif
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Mediatheque.Core.Model.CD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateDeSortie")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Emprunteur")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Groupe")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TitreDeLObjet")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("CDs");
                });
#pragma warning restore 612, 618
        }
    }
}
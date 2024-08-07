﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using basicoEF.Context;

#nullable disable

namespace basicoEF.Context.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240807002047_MIG005")]
    partial class MIG005
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CinePelicula", b =>
                {
                    b.Property<int>("CinesCineId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculasPeliculaId")
                        .HasColumnType("int");

                    b.HasKey("CinesCineId", "PeliculasPeliculaId");

                    b.HasIndex("PeliculasPeliculaId");

                    b.ToTable("CinePelicula");
                });

            modelBuilder.Entity("basicoEF.Models.Cine", b =>
                {
                    b.Property<int>("CineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CineId"));

                    b.Property<string>("NombreCine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CineId");

                    b.ToTable("Cine");
                });

            modelBuilder.Entity("basicoEF.Models.CineOferta", b =>
                {
                    b.Property<int>("CineOfertaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CineOfertaId"));

                    b.Property<int>("CineId")
                        .HasColumnType("int");

                    b.Property<decimal>("Descuento")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreOferta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CineOfertaId");

                    b.HasIndex("CineId")
                        .IsUnique();

                    b.ToTable("CineOferta");
                });

            modelBuilder.Entity("basicoEF.Models.Pelicula", b =>
                {
                    b.Property<int>("PeliculaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PeliculaId"));

                    b.Property<DateTime>("FechaEstreno")
                        .HasColumnType("datetime2");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PeliculaId");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("basicoEF.Models.Prueba", b =>
                {
                    b.Property<int>("PruebaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PruebaId"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("PruebaId");

                    b.ToTable("Pruebas");
                });

            modelBuilder.Entity("basicoEF.Models.SalaCine", b =>
                {
                    b.Property<int>("SalaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalaId"));

                    b.Property<int>("CineId")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SalaId");

                    b.HasIndex("CineId");

                    b.ToTable("SalaCine");
                });

            modelBuilder.Entity("CinePelicula", b =>
                {
                    b.HasOne("basicoEF.Models.Cine", null)
                        .WithMany()
                        .HasForeignKey("CinesCineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("basicoEF.Models.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PeliculasPeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("basicoEF.Models.CineOferta", b =>
                {
                    b.HasOne("basicoEF.Models.Cine", null)
                        .WithOne("CineOferta")
                        .HasForeignKey("basicoEF.Models.CineOferta", "CineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("basicoEF.Models.SalaCine", b =>
                {
                    b.HasOne("basicoEF.Models.Cine", "Cine")
                        .WithMany("SalasCine")
                        .HasForeignKey("CineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cine");
                });

            modelBuilder.Entity("basicoEF.Models.Cine", b =>
                {
                    b.Navigation("CineOferta");

                    b.Navigation("SalasCine");
                });
#pragma warning restore 612, 618
        }
    }
}

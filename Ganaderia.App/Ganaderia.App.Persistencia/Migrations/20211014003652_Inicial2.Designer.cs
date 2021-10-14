﻿// <auto-generated />
using System;
using Ganaderia.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ganaderia.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211014003652_Inicial2")]
    partial class Inicial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Ganaderia.App.Dominio.Ganado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Alias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Raza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("veterinarioID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("veterinarioID");

                    b.ToTable("Ganados");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Persona", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Vacuna", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fabricante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GanadoId")
                        .HasColumnType("int");

                    b.Property<string>("Lote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("GanadoId");

                    b.ToTable("Vacunas");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Ganadero", b =>
                {
                    b.HasBaseType("Ganaderia.App.Dominio.Persona");

                    b.Property<float>("latitude")
                        .HasColumnType("real");

                    b.Property<float>("longitud")
                        .HasColumnType("real");

                    b.HasDiscriminator().HasValue("Ganadero");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Veterinario", b =>
                {
                    b.HasBaseType("Ganaderia.App.Dominio.Persona");

                    b.Property<string>("Especialidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTarjeta")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Veterinario");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Ganado", b =>
                {
                    b.HasOne("Ganaderia.App.Dominio.Veterinario", "veterinario")
                        .WithMany()
                        .HasForeignKey("veterinarioID");

                    b.Navigation("veterinario");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Vacuna", b =>
                {
                    b.HasOne("Ganaderia.App.Dominio.Ganado", null)
                        .WithMany("Vacunas")
                        .HasForeignKey("GanadoId");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Ganado", b =>
                {
                    b.Navigation("Vacunas");
                });
#pragma warning restore 612, 618
        }
    }
}
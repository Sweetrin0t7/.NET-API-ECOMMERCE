﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iShirtsAPI.Data;

#nullable disable

namespace iShirtsAPI.Migrations
{
    [DbContext(typeof(iShirtsAPIContext))]
    partial class iShirtsAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("iShirtsAPI.Models.USUARIO", b =>
                {
                    b.Property<int>("ID_USUARIO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ATIVO")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CARGO")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("EMAIL")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NOME")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SENHA")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID_USUARIO");

                    b.ToTable("USUARIO");
                });
#pragma warning restore 612, 618
        }
    }
}

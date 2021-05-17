﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using personagemAPI.Model;

namespace personagemAPI.Migrations
{
    [DbContext(typeof(personagemContext))]
    partial class personagemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("personagemAPI.Models.personagem", b =>
                {
                    b.Property<int>("personagemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("caracteristicas")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("personagemId");

                    b.ToTable("personagens");
                });
#pragma warning restore 612, 618
        }
    }
}

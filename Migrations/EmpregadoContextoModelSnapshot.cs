﻿// <auto-generated />
using Web_AdminLTE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace WebAdminLTE.Migrations
{
    [DbContext(typeof(EmpregadoContexto))]
    partial class EmpregadoContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Crud_Asp.net.Models.Empregado", b =>
                {
                    b.Property<int>("EmpregadoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmpCode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("LocalizacaoTrabalho")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NameCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Posicao")
                        .HasColumnType("varchar(100)");

                    b.HasKey("EmpregadoId");

                    b.ToTable("Empregado");
                });
#pragma warning restore 612, 618
        }
    }
}

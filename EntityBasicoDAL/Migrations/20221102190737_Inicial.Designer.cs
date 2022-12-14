// <auto-generated />
using System;
using EntityBasicoDAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EntityBasicoDAL.Migrations
{
    [DbContext(typeof(AccesoDC))]
    [Migration("20221102190737_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("EntityBasicoDAL.empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("nombre_empleado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("empleados");
                });

            modelBuilder.Entity("EntityBasicoDAL.nivel_acc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("desc_acceso")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("empleadoId")
                        .HasColumnType("integer");

                    b.Property<string>("nivel_acceso")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("empleadoId");

                    b.ToTable("nivel_accesos");
                });

            modelBuilder.Entity("EntityBasicoDAL.nivel_acc", b =>
                {
                    b.HasOne("EntityBasicoDAL.empleado", null)
                        .WithMany("nivel_accesos")
                        .HasForeignKey("empleadoId");
                });

            modelBuilder.Entity("EntityBasicoDAL.empleado", b =>
                {
                    b.Navigation("nivel_accesos");
                });
#pragma warning restore 612, 618
        }
    }
}

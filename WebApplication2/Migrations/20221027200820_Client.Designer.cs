// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Context;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221027200820_Client")]
    partial class Client
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication2.Models.Client", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CPF")
                        .HasColumnType("bigint");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailClient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameClient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Neighborhood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PostalCode")
                        .HasColumnType("int");

                    b.Property<int?>("States")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ContactsId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("WebApplication2.Models.Contact", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("ContactMobile")
                        .HasColumnType("bigint");

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("WebApplication2.Models.Client", b =>
                {
                    b.HasOne("WebApplication2.Models.Contact", "Contacts")
                        .WithMany()
                        .HasForeignKey("ContactsId");

                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}

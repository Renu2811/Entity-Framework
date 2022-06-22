﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderDetails;

#nullable disable

namespace OrderDetails.Migrations
{
    [DbContext(typeof(DemoDbContext))]
    partial class DemoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OrderDetails.Entities.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("Email")
                        .HasColumnType("int");

                    b.Property<string>("FirstNAme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.ToTable("customer");
                });

            modelBuilder.Entity("OrderDetails.Entities.Item", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemQuantity")
                        .HasColumnType("int");

                    b.Property<int>("ItemRate")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("items");
                });

            modelBuilder.Entity("OrderDetails.Entities.Customer", b =>
                {
                    b.HasOne("OrderDetails.Entities.Customer", null)
                        .WithMany("customer")
                        .HasForeignKey("CustomerID");
                });

            modelBuilder.Entity("OrderDetails.Entities.Customer", b =>
                {
                    b.Navigation("customer");
                });
#pragma warning restore 612, 618
        }
    }
}

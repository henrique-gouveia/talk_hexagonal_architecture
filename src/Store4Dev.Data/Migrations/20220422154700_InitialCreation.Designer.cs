﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Store4Dev.Data;

#nullable disable

namespace Store4Dev.Data.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20220422154700_InitialCreation")]
    partial class InitialCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("Store4Dev.Domain.Entities.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("created_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("brands", (string)null);
                });

            modelBuilder.Entity("Store4Dev.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER")
                        .HasColumnName("active");

                    b.Property<Guid>("BrandId")
                        .HasColumnType("TEXT")
                        .HasColumnName("brand_id");

                    b.Property<decimal>("CostPrice")
                        .HasColumnType("numeric(19,2)")
                        .HasColumnName("cost_price");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("created_at");

                    b.Property<decimal>("CurrentStock")
                        .HasColumnType("numeric(19,2)")
                        .HasColumnName("current_stock");

                    b.Property<decimal>("MinStock")
                        .HasColumnType("numeric(19,2)")
                        .HasColumnName("min_stock");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("numeric(19,2)")
                        .HasColumnName("sale_price");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("products", (string)null);
                });

            modelBuilder.Entity("Store4Dev.Domain.Entities.Product", b =>
                {
                    b.HasOne("Store4Dev.Domain.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("Store4Dev.Domain.Entities.Brand", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
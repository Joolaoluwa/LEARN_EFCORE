﻿// <auto-generated />
using System;
using LEARN_EFCORE.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LEARN_EFCORE.Migrations
{
    [DbContext(typeof(OnXDbContext))]
    partial class OnXDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LEARN_EFCORE.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("OrderFulfilled")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("OrderSent")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("LEARN_EFCORE.Models.OrderDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("LEARN_EFCORE.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Choices")
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .HasColumnType("longtext");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("ProductColor")
                        .HasColumnType("longtext");

                    b.Property<string>("ProductName")
                        .HasColumnType("longtext");

                    b.Property<string>("ProductType")
                        .HasColumnType("longtext");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("LEARN_EFCORE.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("LEARN_EFCORE.Models.Order", b =>
                {
                    b.HasOne("LEARN_EFCORE.Models.User", "User")
                        .WithMany("UserOrder")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LEARN_EFCORE.Models.OrderDetail", b =>
                {
                    b.HasOne("LEARN_EFCORE.Models.Order", "Order")
                        .WithMany("OrderDetail")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LEARN_EFCORE.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("LEARN_EFCORE.Models.Product", b =>
                {
                    b.HasOne("LEARN_EFCORE.Models.User", null)
                        .WithMany("UserProduct")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("LEARN_EFCORE.Models.Order", b =>
                {
                    b.Navigation("OrderDetail");
                });

            modelBuilder.Entity("LEARN_EFCORE.Models.User", b =>
                {
                    b.Navigation("UserOrder");

                    b.Navigation("UserProduct");
                });
#pragma warning restore 612, 618
        }
    }
}

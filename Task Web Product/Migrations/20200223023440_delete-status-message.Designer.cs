﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Task_Web_Product.Models;

namespace Task_Web_Product.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200223023440_delete-status-message")]
    partial class deletestatusmessage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Task_Web_Product.Models.Carts", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("totalPrice")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("carts");
                });

            modelBuilder.Entity("Task_Web_Product.Models.Conversation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("receiver_id")
                        .HasColumnType("int");

                    b.Property<int>("sender_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Conversations");
                });

            modelBuilder.Entity("Task_Web_Product.Models.Items", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CartsId")
                        .HasColumnType("int");

                    b.Property<string>("desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<int>("rate")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("total_item_in_cart")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("CartsId");

                    b.ToTable("items");
                });

            modelBuilder.Entity("Task_Web_Product.Models.Purchase", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CartsId")
                        .HasColumnType("int");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Regency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Zip")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idPurchase")
                        .HasColumnType("int");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("namaBarang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("orderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shippingAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("totalBarang")
                        .HasColumnType("int");

                    b.Property<int>("totalPrice")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("CartsId");

                    b.ToTable("purchases");
                });

            modelBuilder.Entity("Task_Web_Product.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Task_Web_Product.Models.Items", b =>
                {
                    b.HasOne("Task_Web_Product.Models.Carts", "Carts")
                        .WithMany("Items")
                        .HasForeignKey("CartsId");
                });

            modelBuilder.Entity("Task_Web_Product.Models.Purchase", b =>
                {
                    b.HasOne("Task_Web_Product.Models.Carts", "Carts")
                        .WithMany("purchase")
                        .HasForeignKey("CartsId");
                });
#pragma warning restore 612, 618
        }
    }
}

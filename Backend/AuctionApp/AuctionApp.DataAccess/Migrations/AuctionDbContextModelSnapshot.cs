﻿// <auto-generated />
using System;
using AuctionApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AuctionApp.DataAccess.Migrations
{
    [DbContext(typeof(AuctionDbContext))]
    partial class AuctionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuctionApp.Entities.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Surname")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("AuctionApp.Entities.Auction", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdminID")
                        .HasColumnType("int");

                    b.Property<int>("AuctionStatusID")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("EndingTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StartingPrice")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Winner")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AdminID");

                    b.HasIndex("AuctionStatusID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Auctions");
                });

            modelBuilder.Entity("AuctionApp.Entities.AuctionStatus", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Status")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.ToTable("AuctionStatuses");
                });

            modelBuilder.Entity("AuctionApp.Entities.Bid", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuctionID")
                        .HasColumnType("int");

                    b.Property<DateTime>("BidDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserBid")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AuctionID");

                    b.HasIndex("UserID");

                    b.ToTable("Bids");
                });

            modelBuilder.Entity("AuctionApp.Entities.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("AuctionApp.Entities.Image", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuctionID")
                        .HasColumnType("int");

                    b.Property<byte[]>("Img")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("ID");

                    b.HasIndex("AuctionID");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("AuctionApp.Entities.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Surname")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AuctionApp.Entities.Auction", b =>
                {
                    b.HasOne("AuctionApp.Entities.Admin", "Admin")
                        .WithMany("Auctions")
                        .HasForeignKey("AdminID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AuctionApp.Entities.AuctionStatus", "AuctionStatus")
                        .WithMany("Auctions")
                        .HasForeignKey("AuctionStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AuctionApp.Entities.Category", "Category")
                        .WithMany("Auctions")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("AuctionStatus");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("AuctionApp.Entities.Bid", b =>
                {
                    b.HasOne("AuctionApp.Entities.Auction", "Auction")
                        .WithMany("Bids")
                        .HasForeignKey("AuctionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AuctionApp.Entities.User", "User")
                        .WithMany("Bids")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auction");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AuctionApp.Entities.Image", b =>
                {
                    b.HasOne("AuctionApp.Entities.Auction", "Auction")
                        .WithMany("Image")
                        .HasForeignKey("AuctionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auction");
                });

            modelBuilder.Entity("AuctionApp.Entities.Admin", b =>
                {
                    b.Navigation("Auctions");
                });

            modelBuilder.Entity("AuctionApp.Entities.Auction", b =>
                {
                    b.Navigation("Bids");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("AuctionApp.Entities.AuctionStatus", b =>
                {
                    b.Navigation("Auctions");
                });

            modelBuilder.Entity("AuctionApp.Entities.Category", b =>
                {
                    b.Navigation("Auctions");
                });

            modelBuilder.Entity("AuctionApp.Entities.User", b =>
                {
                    b.Navigation("Bids");
                });
#pragma warning restore 612, 618
        }
    }
}

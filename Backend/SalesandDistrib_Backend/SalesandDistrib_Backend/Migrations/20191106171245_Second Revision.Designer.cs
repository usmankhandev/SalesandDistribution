﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesandDistrib_Backend.Models;

namespace SalesandDistrib_Backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191106171245_Second Revision")]
    partial class SecondRevision
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SalesandDistrib_Backend.Models.AgentCustomer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<int>("SaleAgentId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SaleAgentId");

                    b.ToTable("AgentCustomer");
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.DistributorAgents", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DistributorId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("DistributorId");

                    b.HasIndex("UserId");

                    b.ToTable("DistributorAgents");
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.DistributorInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<int>("DistributorId");

                    b.Property<int>("PostalCode");

                    b.Property<string>("Province");

                    b.HasKey("Id");

                    b.HasIndex("DistributorId");

                    b.ToTable("DistributorDetail");
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Price");

                    b.Property<int>("ProductId");

                    b.Property<int>("TotalPacket_Cartoon");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.OrderProducts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgentCustomerId");

                    b.Property<DateTime>("OrderDate");

                    b.Property<int>("ProductId");

                    b.Property<int>("QTY");

                    b.HasKey("Id");

                    b.HasIndex("AgentCustomerId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgentCustomerId");

                    b.Property<int>("StatusId");

                    b.HasKey("Id");

                    b.HasIndex("AgentCustomerId");

                    b.HasIndex("StatusId");

                    b.ToTable("OrderStatus");
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.Packages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Bandwidth");

                    b.Property<int>("DurationPerMonth");

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.Property<int>("TotalUsers");

                    b.HasKey("Id");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.Privileges", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Privileges");
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category");

                    b.Property<string>("Company");

                    b.Property<int>("DistributorId");

                    b.Property<DateTime?>("ExpiryDate");

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.Property<int>("PrimaryUnit");

                    b.Property<int>("SecondaryUnit");

                    b.HasKey("Id");

                    b.HasIndex("DistributorId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.SelectedPackages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DistributorId");

                    b.Property<int>("PackageId");

                    b.HasKey("Id");

                    b.HasIndex("DistributorId");

                    b.HasIndex("PackageId");

                    b.ToTable("DistributorPackages");
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.SelectedPrivileges", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DistributorId");

                    b.Property<int>("PrivilgeId");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("DistributorId");

                    b.HasIndex("PrivilgeId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePrivileges");
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OrderStatus");

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.UserRoles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Contact");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.AgentCustomer", b =>
                {
                    b.HasOne("SalesandDistrib_Backend.Models.Users", "_customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalesandDistrib_Backend.Models.Users", "_saleagent")
                        .WithMany()
                        .HasForeignKey("SaleAgentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.DistributorAgents", b =>
                {
                    b.HasOne("SalesandDistrib_Backend.Models.Users", "_distributor")
                        .WithMany()
                        .HasForeignKey("DistributorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalesandDistrib_Backend.Models.Users", "_user")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.DistributorInfo", b =>
                {
                    b.HasOne("SalesandDistrib_Backend.Models.Users", "_distributor")
                        .WithMany()
                        .HasForeignKey("DistributorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.Inventory", b =>
                {
                    b.HasOne("SalesandDistrib_Backend.Models.Products", "_products")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.OrderProducts", b =>
                {
                    b.HasOne("SalesandDistrib_Backend.Models.AgentCustomer", "_agentcustomer")
                        .WithMany()
                        .HasForeignKey("AgentCustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.OrderStatus", b =>
                {
                    b.HasOne("SalesandDistrib_Backend.Models.AgentCustomer", "_agentcustomer")
                        .WithMany()
                        .HasForeignKey("AgentCustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalesandDistrib_Backend.Models.Status", "_status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.Products", b =>
                {
                    b.HasOne("SalesandDistrib_Backend.Models.Users", "_distributorId")
                        .WithMany()
                        .HasForeignKey("DistributorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.SelectedPackages", b =>
                {
                    b.HasOne("SalesandDistrib_Backend.Models.Users", "_distributor")
                        .WithMany()
                        .HasForeignKey("DistributorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalesandDistrib_Backend.Models.Packages", "_packages")
                        .WithMany()
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.SelectedPrivileges", b =>
                {
                    b.HasOne("SalesandDistrib_Backend.Models.Users", "_distributor")
                        .WithMany()
                        .HasForeignKey("DistributorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalesandDistrib_Backend.Models.Privileges", "_privilge")
                        .WithMany()
                        .HasForeignKey("PrivilgeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalesandDistrib_Backend.Models.Roles", "_role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.Store", b =>
                {
                    b.HasOne("SalesandDistrib_Backend.Models.Users", "_user")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesandDistrib_Backend.Models.UserRoles", b =>
                {
                    b.HasOne("SalesandDistrib_Backend.Models.Roles", "_role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalesandDistrib_Backend.Models.Users", "_user")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
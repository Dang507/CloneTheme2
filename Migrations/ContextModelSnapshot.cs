﻿// <auto-generated />
using System;
using CloneTheme.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CloneTheme.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("CategoryPost", b =>
                {
                    b.Property<int>("CategoriesCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("PostsPostId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesCategoryId", "PostsPostId");

                    b.HasIndex("PostsPostId");

                    b.ToTable("CategoryPost");
                });

            modelBuilder.Entity("CloneTheme.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreateOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("UpdateOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CloneTheme.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("CloneTheme.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("CustomerGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CloneTheme.Models.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CustomersCustomerId")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageId");

                    b.HasIndex("CustomersCustomerId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("CloneTheme.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreateOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("PostName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("UpdateOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("PostId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("CloneTheme.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Roles")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("CustomerRole", b =>
                {
                    b.Property<int>("CustomersCustomerId")
                        .HasColumnType("int");

                    b.Property<int>("RolesRoleId")
                        .HasColumnType("int");

                    b.HasKey("CustomersCustomerId", "RolesRoleId");

                    b.HasIndex("RolesRoleId");

                    b.ToTable("CustomerRole");
                });

            modelBuilder.Entity("ImagePost", b =>
                {
                    b.Property<int>("ImagesImageId")
                        .HasColumnType("int");

                    b.Property<int>("PostsPostId")
                        .HasColumnType("int");

                    b.HasKey("ImagesImageId", "PostsPostId");

                    b.HasIndex("PostsPostId");

                    b.ToTable("ImagePost");
                });

            modelBuilder.Entity("CategoryPost", b =>
                {
                    b.HasOne("CloneTheme.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CloneTheme.Models.Post", null)
                        .WithMany()
                        .HasForeignKey("PostsPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CloneTheme.Models.Comment", b =>
                {
                    b.HasOne("CloneTheme.Models.Customer", "Customer")
                        .WithMany("Comments")
                        .HasForeignKey("CustomerId");

                    b.HasOne("CloneTheme.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("CloneTheme.Models.Image", b =>
                {
                    b.HasOne("CloneTheme.Models.Customer", "Customers")
                        .WithMany("Images")
                        .HasForeignKey("CustomersCustomerId");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("CloneTheme.Models.Post", b =>
                {
                    b.HasOne("CloneTheme.Models.Customer", "Customer")
                        .WithMany("Posts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CustomerRole", b =>
                {
                    b.HasOne("CloneTheme.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CloneTheme.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ImagePost", b =>
                {
                    b.HasOne("CloneTheme.Models.Image", null)
                        .WithMany()
                        .HasForeignKey("ImagesImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CloneTheme.Models.Post", null)
                        .WithMany()
                        .HasForeignKey("PostsPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CloneTheme.Models.Customer", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Images");

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("CloneTheme.Models.Post", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ToManager.DataAccess.Layer;

#nullable disable

namespace ToManager.DataAccess.Layer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240220103629_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ToManage.EntityLayer.CategoryDetail", b =>
                {
                    b.Property<int>("CategoryDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CategoryDetailId"));

                    b.Property<string>("CategoryDetailName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("GoodsCategoryId")
                        .HasColumnType("integer");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("CategoryDetailId");

                    b.HasIndex("GoodsCategoryId");

                    b.ToTable("CategoryDetails");
                });

            modelBuilder.Entity("ToManage.EntityLayer.Goods", b =>
                {
                    b.Property<int>("GoodsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GoodsId"));

                    b.Property<int>("BuyPrice")
                        .HasColumnType("integer");

                    b.Property<int>("CategoryDetailId")
                        .HasColumnType("integer");

                    b.Property<int>("GoodsCount")
                        .HasColumnType("integer");

                    b.Property<string>("GoodsName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("GoodsNumber")
                        .HasColumnType("integer");

                    b.Property<int>("SellPrice")
                        .HasColumnType("integer");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("GoodsId");

                    b.HasIndex("CategoryDetailId");

                    b.ToTable("Goodss");
                });

            modelBuilder.Entity("ToManage.EntityLayer.GoodsCategory", b =>
                {
                    b.Property<int>("GoodsCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GoodsCategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("GoodsCategoryId");

                    b.ToTable("GoodsCategorys");
                });

            modelBuilder.Entity("ToManage.EntityLayer.CategoryDetail", b =>
                {
                    b.HasOne("ToManage.EntityLayer.GoodsCategory", null)
                        .WithMany("CategoryDetails")
                        .HasForeignKey("GoodsCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ToManage.EntityLayer.Goods", b =>
                {
                    b.HasOne("ToManage.EntityLayer.CategoryDetail", null)
                        .WithMany("Goodss")
                        .HasForeignKey("CategoryDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ToManage.EntityLayer.CategoryDetail", b =>
                {
                    b.Navigation("Goodss");
                });

            modelBuilder.Entity("ToManage.EntityLayer.GoodsCategory", b =>
                {
                    b.Navigation("CategoryDetails");
                });
#pragma warning restore 612, 618
        }
    }
}

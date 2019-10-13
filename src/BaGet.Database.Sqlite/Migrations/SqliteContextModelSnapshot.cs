﻿// <auto-generated />
using System;
using BaGet.Database.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BaGet.Database.Sqlite.Migrations
{
    [DbContext(typeof(SqliteContext))]
    partial class SqliteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("BaGet.Core.Entities.Package", b =>
                {
                    b.Property<int>("Key")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Authors")
                        .HasMaxLength(4000);

                    b.Property<string>("Description")
                        .HasMaxLength(4000);

                    b.Property<long>("Downloads");

                    b.Property<bool>("HasReadme");

                    b.Property<string>("IconUrl")
                        .HasMaxLength(4000);

                    b.Property<string>("Id")
                        .IsRequired()
                        .HasColumnType("TEXT COLLATE NOCASE")
                        .HasMaxLength(128);

                    b.Property<bool>("IsPrerelease");

                    b.Property<string>("Language")
                        .HasMaxLength(20);

                    b.Property<string>("LicenseUrl")
                        .HasMaxLength(4000);

                    b.Property<bool>("Listed");

                    b.Property<string>("MinClientVersion")
                        .HasMaxLength(44);

                    b.Property<string>("NormalizedVersionString")
                        .IsRequired()
                        .HasColumnName("Version")
                        .HasMaxLength(64);

                    b.Property<string>("OriginalVersionString")
                        .HasColumnName("OriginalVersion")
                        .HasMaxLength(64);

                    b.Property<string>("ProjectUrl")
                        .HasMaxLength(4000);

                    b.Property<DateTime>("Published");

                    b.Property<string>("RepositoryType")
                        .HasMaxLength(100);

                    b.Property<string>("RepositoryUrl")
                        .HasMaxLength(4000);

                    b.Property<bool>("RequireLicenseAcceptance");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("SemVerLevel");

                    b.Property<string>("Summary")
                        .HasMaxLength(4000);

                    b.Property<string>("Tags")
                        .HasMaxLength(4000);

                    b.Property<string>("Title")
                        .HasMaxLength(256);

                    b.HasKey("Key");

                    b.HasIndex("Id");

                    b.HasIndex("Id", "NormalizedVersionString")
                        .IsUnique();

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("BaGet.Core.Entities.PackageDependency", b =>
                {
                    b.Property<int>("Key")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Id")
                        .HasColumnType("TEXT COLLATE NOCASE")
                        .HasMaxLength(128);

                    b.Property<int?>("PackageKey");

                    b.Property<string>("TargetFramework")
                        .HasMaxLength(256);

                    b.Property<string>("VersionRange")
                        .HasMaxLength(256);

                    b.HasKey("Key");

                    b.HasIndex("Id");

                    b.HasIndex("PackageKey");

                    b.ToTable("PackageDependencies");
                });

            modelBuilder.Entity("BaGet.Core.Entities.PackageType", b =>
                {
                    b.Property<int>("Key")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasColumnType("TEXT COLLATE NOCASE")
                        .HasMaxLength(512);

                    b.Property<int>("PackageKey");

                    b.Property<string>("Version")
                        .HasMaxLength(64);

                    b.HasKey("Key");

                    b.HasIndex("Name");

                    b.HasIndex("PackageKey");

                    b.ToTable("PackageTypes");
                });

            modelBuilder.Entity("BaGet.Core.Entities.TargetFramework", b =>
                {
                    b.Property<int>("Key")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Moniker")
                        .HasColumnType("TEXT COLLATE NOCASE")
                        .HasMaxLength(256);

                    b.Property<int>("PackageKey");

                    b.HasKey("Key");

                    b.HasIndex("Moniker");

                    b.HasIndex("PackageKey");

                    b.ToTable("TargetFrameworks");
                });

            modelBuilder.Entity("BaGet.Core.Entities.PackageDependency", b =>
                {
                    b.HasOne("BaGet.Core.Entities.Package", "Package")
                        .WithMany("Dependencies")
                        .HasForeignKey("PackageKey");
                });

            modelBuilder.Entity("BaGet.Core.Entities.PackageType", b =>
                {
                    b.HasOne("BaGet.Core.Entities.Package", "Package")
                        .WithMany("PackageTypes")
                        .HasForeignKey("PackageKey")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BaGet.Core.Entities.TargetFramework", b =>
                {
                    b.HasOne("BaGet.Core.Entities.Package", "Package")
                        .WithMany("TargetFrameworks")
                        .HasForeignKey("PackageKey")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

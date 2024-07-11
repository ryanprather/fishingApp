﻿// <auto-generated />
using System;
using FishingApp.Storage.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FishingApp.Storage.Migrations
{
    [DbContext(typeof(FishingAppContext))]
    partial class FishingAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("FishingApp.Storage.Datasets.MonitoredNOAALocation", b =>
                {
                    b.Property<Guid>("MonitoredNOAALocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Latitude")
                        .HasColumnType("REAL");

                    b.Property<double>("Longitude")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StationId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MonitoredNOAALocationID");

                    b.ToTable("MonitoredNOAALocations");
                });

            modelBuilder.Entity("FishingApp.Storage.Datasets.PersonalGPSLocation", b =>
                {
                    b.Property<Guid>("PersonalGPSLocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<double>("Latitude")
                        .HasColumnType("REAL");

                    b.Property<double>("Longitude")
                        .HasColumnType("REAL");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("WaterDepth")
                        .HasColumnType("INTEGER");

                    b.HasKey("PersonalGPSLocationID");

                    b.ToTable("PersonalGPSLocations");
                });

            modelBuilder.Entity("FishingApp.Storage.Datasets.PersonalGPSLocationNote", b =>
                {
                    b.Property<Guid>("PersonalGPSLocationNoteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FishingDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PersonalGPSLocationID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PersonalGPSLocationNoteID");

                    b.ToTable("PersonalGPSLocationNotes");
                });
#pragma warning restore 612, 618
        }
    }
}

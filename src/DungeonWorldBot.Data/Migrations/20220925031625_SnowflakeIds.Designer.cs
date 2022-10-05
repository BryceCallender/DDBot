﻿// <auto-generated />
using System;
using DungeonWorldBot.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DungeonWorldBot.Data.Migrations
{
    [DbContext(typeof(DungeonWorldContext))]
    [Migration("20220925031625_SnowflakeIds")]
    partial class SnowflakeIds
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("DungeonWorldBot.Data.Entities.Bond", b =>
                {
                    b.Property<ulong>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("CharacterID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CharacterID");

                    b.ToTable("Bond");
                });

            modelBuilder.Entity("DungeonWorldBot.Data.Entities.Character", b =>
                {
                    b.Property<ulong>("ID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Alignment")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Race")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("DungeonWorldBot.Data.Entities.Debility", b =>
                {
                    b.Property<ulong>("ID")
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("CharacterID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Modifier")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatType")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("CharacterID");

                    b.ToTable("Debility");
                });

            modelBuilder.Entity("DungeonWorldBot.Data.Entities.Stat", b =>
                {
                    b.Property<ulong>("ID")
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("CharacterID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Modifier")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatType")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("CharacterID");

                    b.ToTable("Stat");
                });

            modelBuilder.Entity("DungeonWorldBot.Data.Entities.Bond", b =>
                {
                    b.HasOne("DungeonWorldBot.Data.Entities.Character", null)
                        .WithMany("Bonds")
                        .HasForeignKey("CharacterID");
                });

            modelBuilder.Entity("DungeonWorldBot.Data.Entities.Debility", b =>
                {
                    b.HasOne("DungeonWorldBot.Data.Entities.Character", null)
                        .WithMany("Debilities")
                        .HasForeignKey("CharacterID");
                });

            modelBuilder.Entity("DungeonWorldBot.Data.Entities.Stat", b =>
                {
                    b.HasOne("DungeonWorldBot.Data.Entities.Character", null)
                        .WithMany("Stats")
                        .HasForeignKey("CharacterID");
                });

            modelBuilder.Entity("DungeonWorldBot.Data.Entities.Character", b =>
                {
                    b.Navigation("Bonds");

                    b.Navigation("Debilities");

                    b.Navigation("Stats");
                });
#pragma warning restore 612, 618
        }
    }
}

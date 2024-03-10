﻿// <auto-generated />
using System;
using EuroleagueStatisticsBackend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EuroleagueStatisticsBackend.Migrations
{
    [DbContext(typeof(StatisticsDbContext))]
    [Migration("20240309174838_FantasyStats1")]
    partial class FantasyStats1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EuroleagueStatisticsBackend.Data.Entities.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double>("Assists")
                        .HasColumnType("double precision");

                    b.Property<double>("Availability")
                        .HasColumnType("double precision");

                    b.Property<double>("BNFPoints")
                        .HasColumnType("double precision");

                    b.Property<double>("Blocks")
                        .HasColumnType("double precision");

                    b.Property<double>("BlocksAllowed")
                        .HasColumnType("double precision");

                    b.Property<double>("DRating")
                        .HasColumnType("double precision");

                    b.Property<double>("DRebounds")
                        .HasColumnType("double precision");

                    b.Property<double>("Efficiency")
                        .HasColumnType("double precision");

                    b.Property<double>("FPoints")
                        .HasColumnType("double precision");

                    b.Property<double>("Fg")
                        .HasColumnType("double precision");

                    b.Property<double>("Fga")
                        .HasColumnType("double precision");

                    b.Property<double>("Fgm")
                        .HasColumnType("double precision");

                    b.Property<double>("Ft")
                        .HasColumnType("double precision");

                    b.Property<double>("Fta")
                        .HasColumnType("double precision");

                    b.Property<double>("Ftm")
                        .HasColumnType("double precision");

                    b.Property<int>("GamesPlayed")
                        .HasColumnType("integer");

                    b.Property<int>("Losses")
                        .HasColumnType("integer");

                    b.Property<double>("Minutes")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("NetRating")
                        .HasColumnType("double precision");

                    b.Property<double>("ORating")
                        .HasColumnType("double precision");

                    b.Property<double>("ORebounds")
                        .HasColumnType("double precision");

                    b.Property<double>("Pace")
                        .HasColumnType("double precision");

                    b.Property<double>("PersonalFouls")
                        .HasColumnType("double precision");

                    b.Property<double>("PersonalFoulsDrawn")
                        .HasColumnType("double precision");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("PlusMinus")
                        .HasColumnType("double precision");

                    b.Property<double>("Points")
                        .HasColumnType("double precision");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Possesions")
                        .HasColumnType("double precision");

                    b.Property<string>("RealName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Rebounds")
                        .HasColumnType("double precision");

                    b.Property<double>("Steals")
                        .HasColumnType("double precision");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uuid");

                    b.Property<double>("TrueShooting")
                        .HasColumnType("double precision");

                    b.Property<double>("Turnovers")
                        .HasColumnType("double precision");

                    b.Property<int>("Wins")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("EuroleagueStatisticsBackend.Data.Entities.PlayerRound", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double>("Assists")
                        .HasColumnType("double precision");

                    b.Property<double>("Blocks")
                        .HasColumnType("double precision");

                    b.Property<double>("BlocksAllowed")
                        .HasColumnType("double precision");

                    b.Property<double>("DRating")
                        .HasColumnType("double precision");

                    b.Property<double>("DRebounds")
                        .HasColumnType("double precision");

                    b.Property<double>("Efficiency")
                        .HasColumnType("double precision");

                    b.Property<double>("Fg")
                        .HasColumnType("double precision");

                    b.Property<double>("Fga")
                        .HasColumnType("double precision");

                    b.Property<double>("Fgm")
                        .HasColumnType("double precision");

                    b.Property<double>("Ft")
                        .HasColumnType("double precision");

                    b.Property<double>("Fta")
                        .HasColumnType("double precision");

                    b.Property<double>("Ftm")
                        .HasColumnType("double precision");

                    b.Property<double>("Minutes")
                        .HasColumnType("double precision");

                    b.Property<double>("NetRating")
                        .HasColumnType("double precision");

                    b.Property<double>("ORating")
                        .HasColumnType("double precision");

                    b.Property<double>("ORebounds")
                        .HasColumnType("double precision");

                    b.Property<double>("Pace")
                        .HasColumnType("double precision");

                    b.Property<double>("PersonalFouls")
                        .HasColumnType("double precision");

                    b.Property<double>("PersonalFoulsDrawn")
                        .HasColumnType("double precision");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("uuid");

                    b.Property<double>("PlusMinus")
                        .HasColumnType("double precision");

                    b.Property<double>("Points")
                        .HasColumnType("double precision");

                    b.Property<double>("Possesions")
                        .HasColumnType("double precision");

                    b.Property<double>("Rebounds")
                        .HasColumnType("double precision");

                    b.Property<int>("Round")
                        .HasColumnType("integer");

                    b.Property<double>("Steals")
                        .HasColumnType("double precision");

                    b.Property<double>("TrueShooting")
                        .HasColumnType("double precision");

                    b.Property<double>("Turnovers")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("PlayerRounds");
                });

            modelBuilder.Entity("EuroleagueStatisticsBackend.Data.Entities.Team", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Assists")
                        .HasColumnType("double precision");

                    b.Property<double>("Availability")
                        .HasColumnType("double precision");

                    b.Property<double>("BNFPoints")
                        .HasColumnType("double precision");

                    b.Property<double>("Blocks")
                        .HasColumnType("double precision");

                    b.Property<double>("BlocksAllowed")
                        .HasColumnType("double precision");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Coach")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("DRating")
                        .HasColumnType("double precision");

                    b.Property<double>("DRebounds")
                        .HasColumnType("double precision");

                    b.Property<double>("Efficiency")
                        .HasColumnType("double precision");

                    b.Property<double>("FPoints")
                        .HasColumnType("double precision");

                    b.Property<double>("Fg")
                        .HasColumnType("double precision");

                    b.Property<double>("Fga")
                        .HasColumnType("double precision");

                    b.Property<double>("Fgm")
                        .HasColumnType("double precision");

                    b.Property<double>("Ft")
                        .HasColumnType("double precision");

                    b.Property<double>("Fta")
                        .HasColumnType("double precision");

                    b.Property<double>("Ftm")
                        .HasColumnType("double precision");

                    b.Property<int>("GamesPlayed")
                        .HasColumnType("integer");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Losses")
                        .HasColumnType("integer");

                    b.Property<double>("Minutes")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("NetRating")
                        .HasColumnType("double precision");

                    b.Property<double>("ORating")
                        .HasColumnType("double precision");

                    b.Property<double>("ORebounds")
                        .HasColumnType("double precision");

                    b.Property<double>("Pace")
                        .HasColumnType("double precision");

                    b.Property<double>("PersonalFouls")
                        .HasColumnType("double precision");

                    b.Property<double>("PersonalFoulsDrawn")
                        .HasColumnType("double precision");

                    b.Property<double>("PlusMinus")
                        .HasColumnType("double precision");

                    b.Property<double>("Points")
                        .HasColumnType("double precision");

                    b.Property<double>("Possesions")
                        .HasColumnType("double precision");

                    b.Property<double>("Rebounds")
                        .HasColumnType("double precision");

                    b.Property<double>("Steals")
                        .HasColumnType("double precision");

                    b.Property<double>("TrueShooting")
                        .HasColumnType("double precision");

                    b.Property<double>("Turnovers")
                        .HasColumnType("double precision");

                    b.Property<int>("Wins")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("EuroleagueStatisticsBackend.Data.Entities.TeamRound", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double>("Assists")
                        .HasColumnType("double precision");

                    b.Property<double>("Blocks")
                        .HasColumnType("double precision");

                    b.Property<double>("BlocksAllowed")
                        .HasColumnType("double precision");

                    b.Property<double>("DRating")
                        .HasColumnType("double precision");

                    b.Property<double>("DRebounds")
                        .HasColumnType("double precision");

                    b.Property<double>("Efficiency")
                        .HasColumnType("double precision");

                    b.Property<double>("Fg")
                        .HasColumnType("double precision");

                    b.Property<double>("Fga")
                        .HasColumnType("double precision");

                    b.Property<double>("Fgm")
                        .HasColumnType("double precision");

                    b.Property<double>("Ft")
                        .HasColumnType("double precision");

                    b.Property<double>("Fta")
                        .HasColumnType("double precision");

                    b.Property<double>("Ftm")
                        .HasColumnType("double precision");

                    b.Property<double>("Minutes")
                        .HasColumnType("double precision");

                    b.Property<double>("NetRating")
                        .HasColumnType("double precision");

                    b.Property<double>("ORating")
                        .HasColumnType("double precision");

                    b.Property<double>("ORebounds")
                        .HasColumnType("double precision");

                    b.Property<double>("Pace")
                        .HasColumnType("double precision");

                    b.Property<double>("PersonalFouls")
                        .HasColumnType("double precision");

                    b.Property<double>("PersonalFoulsDrawn")
                        .HasColumnType("double precision");

                    b.Property<double>("PlusMinus")
                        .HasColumnType("double precision");

                    b.Property<double>("Points")
                        .HasColumnType("double precision");

                    b.Property<double>("Possesions")
                        .HasColumnType("double precision");

                    b.Property<double>("Rebounds")
                        .HasColumnType("double precision");

                    b.Property<int>("Round")
                        .HasColumnType("integer");

                    b.Property<double>("Steals")
                        .HasColumnType("double precision");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uuid");

                    b.Property<double>("TrueShooting")
                        .HasColumnType("double precision");

                    b.Property<double>("Turnovers")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamRounds");
                });

            modelBuilder.Entity("EuroleagueStatisticsBackend.Data.Entities.Player", b =>
                {
                    b.HasOne("EuroleagueStatisticsBackend.Data.Entities.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("EuroleagueStatisticsBackend.Data.Entities.PlayerRound", b =>
                {
                    b.HasOne("EuroleagueStatisticsBackend.Data.Entities.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("EuroleagueStatisticsBackend.Data.Entities.TeamRound", b =>
                {
                    b.HasOne("EuroleagueStatisticsBackend.Data.Entities.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
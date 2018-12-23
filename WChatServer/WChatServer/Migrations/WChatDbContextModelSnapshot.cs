﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WChatDb;

namespace WChatServer.Migrations
{
    [DbContext(typeof(WChatDbContext))]
    partial class WChatDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("WChatDb.Account", b =>
                {
                    b.Property<byte[]>("id")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("WChatDb.AccountDetail", b =>
                {
                    b.Property<byte[]>("id")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<byte[]>("AccountId")
                        .IsRequired()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("id");

                    b.HasIndex("AccountId");

                    b.ToTable("AccountDetails");
                });

            modelBuilder.Entity("WChatDb.App", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<string>("AppSecret");

                    b.Property<string>("Appid");

                    b.HasKey("Id");

                    b.ToTable("Apps");
                });

            modelBuilder.Entity("WChatDb.AppDetail", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<byte[]>("AppId")
                        .IsRequired()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("AppId");

                    b.ToTable("AppDetails");
                });

            modelBuilder.Entity("WChatDb.Device", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<string>("DeviceId");

                    b.Property<byte[]>("UserId")
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.HasKey("Id");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("WChatDb.AccountDetail", b =>
                {
                    b.HasOne("WChatDb.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WChatDb.AppDetail", b =>
                {
                    b.HasOne("WChatDb.App", "App")
                        .WithMany("AppDetails")
                        .HasForeignKey("AppId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

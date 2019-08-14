﻿// <auto-generated />
using System;
using Accounting.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Accounting.Infrastructure.Migrations
{
    [DbContext(typeof(AccountingDbContext))]
    [Migration("20190706232911_UpdatedNatureLength")]
    partial class UpdatedNatureLength
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Accounting.Domain.Entities.AccountType", b =>
                {
                    b.Property<Guid>("AccountTypeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Code")
                        .HasColumnType("varchar(5)");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nature")
                        .HasColumnType("varchar(6)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<Guid>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("AccountTypeID");

                    b.ToTable("AccountTypes");
                });

            modelBuilder.Entity("Accounting.Domain.Entities.ChartOfAccount", b =>
                {
                    b.Property<Guid>("AccountID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AccountTypeID");

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasColumnType("varchar(5)");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(300)");

                    b.Property<Guid>("GroupID");

                    b.Property<string>("Nature")
                        .HasColumnType("varchar(6)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Title")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("AccountID");

                    b.HasIndex("AccountTypeID");

                    b.ToTable("ChartOfAccounts");
                });

            modelBuilder.Entity("Accounting.Domain.Entities.Company", b =>
                {
                    b.Property<Guid>("CompanyID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Address2")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("varchar(200)");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Mobile")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(15)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("TIN")
                        .HasColumnType("varchar(20)");

                    b.Property<Guid>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("CompanyID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Accounting.Domain.Entities.ProfitCentre", b =>
                {
                    b.Property<Guid>("ProfitCentreID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Address1")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Address2")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Address3")
                        .HasColumnType("varchar(50)");

                    b.Property<Guid?>("CompanyID");

                    b.Property<string>("ContactNo")
                        .HasColumnType("varchar(15)");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Mobile")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("ProfitCentreName")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("ProfitCentreType")
                        .HasColumnType("varchar(20)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("TradeName")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("ProfitCentreID");

                    b.HasIndex("CompanyID");

                    b.ToTable("ProfitCentres");
                });

            modelBuilder.Entity("Accounting.Domain.Entities.ProfitCentreAccount", b =>
                {
                    b.Property<Guid>("ProfitCentreID");

                    b.Property<Guid>("AccountID");

                    b.Property<bool>("Active");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<Guid>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("ProfitCentreID");

                    b.HasIndex("AccountID");

                    b.ToTable("ProfitCentreAccounts");
                });

            modelBuilder.Entity("Accounting.Domain.Entities.ChartOfAccount", b =>
                {
                    b.HasOne("Accounting.Domain.Entities.AccountType", "accountType")
                        .WithMany()
                        .HasForeignKey("AccountTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Accounting.Domain.Entities.ProfitCentre", b =>
                {
                    b.HasOne("Accounting.Domain.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID");
                });

            modelBuilder.Entity("Accounting.Domain.Entities.ProfitCentreAccount", b =>
                {
                    b.HasOne("Accounting.Domain.Entities.ChartOfAccount", "ChartOfAccount")
                        .WithMany()
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Accounting.Domain.Entities.ProfitCentre", "ProfitCentre")
                        .WithMany()
                        .HasForeignKey("ProfitCentreID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
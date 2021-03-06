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
    [Migration("20190721031604_AddedBackCodeInAccountType")]
    partial class AddedBackCodeInAccountType
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

            modelBuilder.Entity("Accounting.Domain.Entities.Customer", b =>
                {
                    b.Property<Guid>("CustomerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Address2")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CustomerNo")
                        .HasColumnType("varchar(8)");

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Mobile")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(15)");

                    b.Property<DateTime>("RegDate")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<Guid>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Accounting.Domain.Entities.Journal", b =>
                {
                    b.Property<Guid>("JournalID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Particular")
                        .HasColumnType("varchar(1000)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Status")
                        .HasColumnType("varchar(15)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("JournalID");

                    b.ToTable("Journals");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Journal");
                });

            modelBuilder.Entity("Accounting.Domain.Entities.JournalDetail", b =>
                {
                    b.Property<Guid>("JournalDetailID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("JournalID");

                    b.Property<string>("Nature")
                        .HasColumnType("varchar(6)");

                    b.Property<Guid>("PCAccountID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<Guid>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("JournalDetailID");

                    b.ToTable("JournalDetails");
                });

            modelBuilder.Entity("Accounting.Domain.Entities.PaymentSchedule", b =>
                {
                    b.Property<Guid>("PaymentScheduleID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("PCAccountID");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("ReceivableID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Type")
                        .HasColumnType("varchar(15)");

                    b.Property<Guid>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("PaymentScheduleID");

                    b.ToTable("PaymentSchedules");
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
                    b.Property<Guid>("PCAccountID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AccountID");

                    b.Property<bool>("Active");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("ProfitCentreID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<Guid>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("PCAccountID");

                    b.HasIndex("AccountID");

                    b.HasIndex("ProfitCentreID");

                    b.ToTable("ProfitCentreAccounts");
                });

            modelBuilder.Entity("Accounting.Domain.Entities.Receivable", b =>
                {
                    b.Property<Guid>("ReceivableID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amortization");

                    b.Property<double>("Amount");

                    b.Property<double>("Balance");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<DateTime>("MaturityDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("RSettingID");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Remarks")
                        .HasColumnType("varchar(1000)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Status")
                        .HasColumnType("varchar(15)");

                    b.Property<int>("Term");

                    b.Property<Guid>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("ReceivableID");

                    b.ToTable("Receivables");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Receivable");
                });

            modelBuilder.Entity("Accounting.Domain.Entities.ReceivableSetting", b =>
                {
                    b.Property<Guid>("RSettingID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .HasColumnType("varchar(5)");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<DateTime>("EffectivityDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("IntAccountID");

                    b.Property<int>("IntOutright");

                    b.Property<string>("InterestMode")
                        .HasColumnType("varchar(15)");

                    b.Property<double>("InterestRate");

                    b.Property<Guid>("PCAccountID");

                    b.Property<string>("PaymentMode")
                        .HasColumnType("varchar(15)");

                    b.Property<Guid>("PenaltyAccountID");

                    b.Property<string>("PenaltyMode")
                        .HasColumnType("varchar(15)");

                    b.Property<double>("PenaltyRate");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Term");

                    b.Property<Guid>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<bool>("WithRebates");

                    b.HasKey("RSettingID");

                    b.ToTable("ReceivableSettings");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ReceivableSetting");
                });

            modelBuilder.Entity("Accounting.Domain.Entities.ReceivableTransaction", b =>
                {
                    b.Property<Guid>("ReceivableTransactionID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("JournalID");

                    b.Property<Guid>("ReceivableID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("TransationDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("ReceivableTransactionID");

                    b.ToTable("ReceivableTransactions");
                });

            modelBuilder.Entity("Accounting.Domain.Entities.ReceivableTransactionDetail", b =>
                {
                    b.Property<Guid>("ReceivableID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("JournalDetailID");

                    b.Property<Guid>("PaymentScheduleID");

                    b.Property<Guid>("ReceivableTransactionID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<Guid>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("ReceivableID");

                    b.ToTable("ReceivableTransactionDetails");
                });

            modelBuilder.Entity("Accounting.Domain.Entities.CashReceiptJournal", b =>
                {
                    b.HasBaseType("Accounting.Domain.Entities.Journal");

                    b.Property<string>("CashReceiptNo")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 48)))
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Payee")
                        .HasColumnType("varchar(100)");

                    b.HasDiscriminator().HasValue("CashReceiptJournal");
                });

            modelBuilder.Entity("Accounting.Domain.Entities.AccountsReceivable", b =>
                {
                    b.HasBaseType("Accounting.Domain.Entities.Receivable");

                    b.Property<Guid>("CustomerID");

                    b.HasDiscriminator().HasValue("AccountsReceivable");
                });

            modelBuilder.Entity("Accounting.Domain.Entities.LoansReceivable", b =>
                {
                    b.HasBaseType("Accounting.Domain.Entities.Receivable");

                    b.Property<Guid>("LoanApplicationID");

                    b.Property<Guid>("MemberID");

                    b.HasDiscriminator().HasValue("LoansReceivable");
                });

            modelBuilder.Entity("Accounting.Domain.Entities.ARSetting", b =>
                {
                    b.HasBaseType("Accounting.Domain.Entities.ReceivableSetting");

                    b.Property<Guid>("SalesAccountID");

                    b.HasDiscriminator().HasValue("ARSetting");
                });

            modelBuilder.Entity("Accounting.Domain.Entities.LRSetting", b =>
                {
                    b.HasBaseType("Accounting.Domain.Entities.ReceivableSetting");

                    b.Property<bool>("AllowMultiple");

                    b.Property<string>("Eligibility")
                        .HasColumnType("varchar(max)");

                    b.Property<Guid>("LLAccountID");

                    b.Property<Guid>("LPAccountID");

                    b.Property<Guid>("LRAccountID");

                    b.Property<bool>("MemberOnly");

                    b.Property<double>("MinPayment");

                    b.Property<string>("MinPaymentScheme")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Purpose")
                        .HasColumnType("varchar(max)");

                    b.Property<int>("ReceivedFromA");

                    b.Property<int>("ReceivedFromB");

                    b.Property<int>("ReceivedToA");

                    b.Property<int>("ReceivedToB");

                    b.Property<int>("ReleasedDayA");

                    b.Property<int>("ReleasedDayB");

                    b.Property<int>("RequiredCoMaker");

                    b.Property<string>("Requirements")
                        .HasColumnType("varchar(max)");

                    b.Property<Guid>("UILAccountID");

                    b.Property<bool>("WithCoMaker");

                    b.HasDiscriminator().HasValue("LRSetting");
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

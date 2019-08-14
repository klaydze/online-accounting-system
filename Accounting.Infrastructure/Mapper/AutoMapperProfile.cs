using Accounting.Domain.Entities;
using Accounting.Infrastructure.Models;
using AutoMapper;

namespace Accounting.Infrastructure.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Company, CompanyModel>()
                .ForMember(d => d.CompanyID, map => map.MapFrom(s => s.CompanyID))
                .ForMember(d => d.CompanyName, map => map.MapFrom(s => s.CompanyName))
                .ForMember(d => d.Address1, map => map.MapFrom(s => s.Address1))
                .ForMember(d => d.Address2, map => map.MapFrom(s => s.Address2))
                .ForMember(d => d.Phone, map => map.MapFrom(s => s.Phone))
                .ForMember(d => d.Mobile, map => map.MapFrom(s => s.Mobile))
                .ForMember(d => d.TIN, map => map.MapFrom(s => s.TIN))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<ProfitCentre, ProfitCentreModel>()
                .ForMember(d => d.ProfitCentreID, map => map.MapFrom(s => s.ProfitCentreID))
                .ForMember(d => d.ProfitCentreName, map => map.MapFrom(s => s.ProfitCentreName))
                .ForMember(d => d.ContactNo, map => map.MapFrom(s => s.ContactNo))
                .ForMember(d => d.Mobile, map => map.MapFrom(s => s.Mobile))
                .ForMember(d => d.Address1, map => map.MapFrom(s => s.Address1))
                .ForMember(d => d.Address2, map => map.MapFrom(s => s.Address2))
                .ForMember(d => d.Address3, map => map.MapFrom(s => s.Address3))
                .ForMember(d => d.TradeName, map => map.MapFrom(s => s.TradeName))
                .ForMember(d => d.ProfitCentreType, map => map.MapFrom(s => s.ProfitCentreType))
                .ForMember(d => d.CompanyID, map => map.MapFrom(s => s.CompanyID))
                .ForMember(d => d.Active, map => map.MapFrom(s => s.Active))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ForMember(d => d.Company, map => map.MapFrom(s => s.Company))
                .ReverseMap();

            CreateMap<AccountType, AccountTypeModel>()
                .ForMember(d => d.AccountTypeID, map => map.MapFrom(s => s.AccountTypeID))
                .ForMember(d => d.Category, map => map.MapFrom(s => s.Category))
                .ForMember(d => d.Description, map => map.MapFrom(s => s.Description))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<ChartOfAccount, ChartOfAccountModel>()
                .ForMember(d => d.AccountID, map => map.MapFrom(s => s.AccountID))
                .ForMember(d => d.Code, map => map.MapFrom(s => s.Code))
                .ForMember(d => d.Title, map => map.MapFrom(s => s.Title))
                .ForMember(d => d.Description, map => map.MapFrom(s => s.Description))
                .ForMember(d => d.Nature, map => map.MapFrom(s => s.Nature))
                .ForMember(d => d.GroupID, map => map.MapFrom(s => s.GroupID))
                .ForMember(d => d.AccountTypeID, map => map.MapFrom(s => s.AccountTypeID))
                .ForMember(d => d.Active, map => map.MapFrom(s => s.Active))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<ProfitCentreAccount, ProfitCentreAccountModel>()
                .ForMember(d => d.ProfitCentreID, map => map.MapFrom(s => s.ProfitCentreID))
                .ForMember(d => d.AccountID, map => map.MapFrom(s => s.AccountID))
                .ForMember(d => d.Active, map => map.MapFrom(s => s.Active))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<ARSetting, ARSettingModel>()
                .ForMember(d => d.RSettingID, map => map.MapFrom(s => s.RSettingID))
                .ForMember(d => d.Code, map => map.MapFrom(s => s.Code))
                .ForMember(d => d.Description, map => map.MapFrom(s => s.Description))
                .ForMember(d => d.PaymentMode, map => map.MapFrom(s => s.PaymentMode))
                .ForMember(d => d.PenaltyMode, map => map.MapFrom(s => s.PenaltyMode))
                .ForMember(d => d.InterestMode, map => map.MapFrom(s => s.InterestMode))
                .ForMember(d => d.InterestRate, map => map.MapFrom(s => s.InterestRate))
                .ForMember(d => d.PenaltyRate, map => map.MapFrom(s => s.PenaltyRate))
                .ForMember(d => d.Term, map => map.MapFrom(s => s.Term))
                .ForMember(d => d.IntOutright, map => map.MapFrom(s => s.IntOutright))
                .ForMember(d => d.WithRebates, map => map.MapFrom(s => s.WithRebates))
                .ForMember(d => d.SalesAccountID, map => map.MapFrom(s => s.SalesAccountID))
                .ForMember(d => d.PCAccountID, map => map.MapFrom(s => s.PCAccountID))
                .ForMember(d => d.IntAccountID, map => map.MapFrom(s => s.IntAccountID))
                .ForMember(d => d.PenaltyAccountID, map => map.MapFrom(s => s.PenaltyAccountID))
                .ForMember(d => d.EffectivityDate, map => map.MapFrom(s => s.EffectivityDate))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<LRSetting, LRSettingModel>()
                .ForMember(d => d.RSettingID, map => map.MapFrom(s => s.RSettingID))
                .ForMember(d => d.Code, map => map.MapFrom(s => s.Code))
                .ForMember(d => d.Description, map => map.MapFrom(s => s.Description))
                .ForMember(d => d.PaymentMode, map => map.MapFrom(s => s.PaymentMode))
                .ForMember(d => d.PenaltyMode, map => map.MapFrom(s => s.PenaltyMode))
                .ForMember(d => d.InterestMode, map => map.MapFrom(s => s.InterestMode))
                .ForMember(d => d.InterestRate, map => map.MapFrom(s => s.InterestRate))
                .ForMember(d => d.PenaltyRate, map => map.MapFrom(s => s.PenaltyRate))
                .ForMember(d => d.Term, map => map.MapFrom(s => s.Term))
                .ForMember(d => d.IntOutright, map => map.MapFrom(s => s.IntOutright))
                .ForMember(d => d.WithRebates, map => map.MapFrom(s => s.WithRebates))
                .ForMember(d => d.Purpose, map => map.MapFrom(s => s.Purpose))
                .ForMember(d => d.Eligibility, map => map.MapFrom(s => s.Eligibility))
                .ForMember(d => d.Requirements, map => map.MapFrom(s => s.Requirements))
                .ForMember(d => d.MinPayment, map => map.MapFrom(s => s.MinPayment))
                .ForMember(d => d.MinPaymentScheme, map => map.MapFrom(s => s.MinPaymentScheme))
                .ForMember(d => d.WithCoMaker, map => map.MapFrom(s => s.WithCoMaker))
                .ForMember(d => d.RequiredCoMaker, map => map.MapFrom(s => s.RequiredCoMaker))
                .ForMember(d => d.MemberOnly, map => map.MapFrom(s => s.MemberOnly))
                .ForMember(d => d.AllowMultiple, map => map.MapFrom(s => s.AllowMultiple))
                .ForMember(d => d.ReceivedFromA, map => map.MapFrom(s => s.ReceivedFromA))
                .ForMember(d => d.ReceivedToA, map => map.MapFrom(s => s.ReceivedToA))
                .ForMember(d => d.ReleasedDayA, map => map.MapFrom(s => s.ReleasedDayA))
                .ForMember(d => d.ReceivedFromB, map => map.MapFrom(s => s.ReceivedFromB))
                .ForMember(d => d.ReceivedToB, map => map.MapFrom(s => s.ReceivedToB))
                .ForMember(d => d.ReleasedDayB, map => map.MapFrom(s => s.ReleasedDayB))
                .ForMember(d => d.PCAccountID, map => map.MapFrom(s => s.PCAccountID))
                .ForMember(d => d.IntAccountID, map => map.MapFrom(s => s.IntAccountID))
                .ForMember(d => d.PenaltyAccountID, map => map.MapFrom(s => s.PenaltyAccountID))
                .ForMember(d => d.LRAccountID, map => map.MapFrom(s => s.LRAccountID))
                .ForMember(d => d.LPAccountID, map => map.MapFrom(s => s.LPAccountID))
                .ForMember(d => d.LLAccountID, map => map.MapFrom(s => s.LLAccountID))
                .ForMember(d => d.UILAccountID, map => map.MapFrom(s => s.UILAccountID))
                .ForMember(d => d.EffectivityDate, map => map.MapFrom(s => s.EffectivityDate))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<Customer, CustomerModel>()
                .ForMember(d => d.CustomerID, map => map.MapFrom(s => s.CustomerID))
                .ForMember(d => d.CustomerNo, map => map.MapFrom(s => s.CustomerNo))
                .ForMember(d => d.RegDate, map => map.MapFrom(s => s.RegDate))
                .ForMember(d => d.LastName, map => map.MapFrom(s => s.LastName))
                .ForMember(d => d.FirstName, map => map.MapFrom(s => s.FirstName))
                .ForMember(d => d.MiddleName, map => map.MapFrom(s => s.MiddleName))
                .ForMember(d => d.Address1, map => map.MapFrom(s => s.Address1))
                .ForMember(d => d.Address2, map => map.MapFrom(s => s.Address2))
                .ForMember(d => d.Phone, map => map.MapFrom(s => s.Phone))
                .ForMember(d => d.Mobile, map => map.MapFrom(s => s.Mobile))
                .ForMember(d => d.BirthDate, map => map.MapFrom(s => s.BirthDate))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<CashReceiptJournal, CashReceiptJournalModel>()
                .ForMember(d => d.JournalID, map => map.MapFrom(s => s.JournalID))
                .ForMember(d => d.TransactionDate, map => map.MapFrom(s => s.TransactionDate))
                .ForMember(d => d.Payee, map => map.MapFrom(s => s.Payee))
                .ForMember(d => d.CashReceiptNo, map => map.MapFrom(s => s.CashReceiptNo))
                .ForMember(d => d.Particular, map => map.MapFrom(s => s.Particular))
                .ForMember(d => d.Amount, map => map.MapFrom(s => s.Amount))
                .ForMember(d => d.Status, map => map.MapFrom(s => s.Status))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<JournalDetail, JournalDetailModel>()
                .ForMember(d => d.JournalDetailID, map => map.MapFrom(s => s.JournalDetailID))
                .ForMember(d => d.JournalID, map => map.MapFrom(s => s.JournalID))
                .ForMember(d => d.PCAccountID, map => map.MapFrom(s => s.PCAccountID))
                .ForMember(d => d.Amount, map => map.MapFrom(s => s.Amount))
                .ForMember(d => d.Nature, map => map.MapFrom(s => s.Nature))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<AccountsReceivable, AccountsReceivableModel>()
                .ForMember(d => d.ReceivableID, map => map.MapFrom(s => s.ReceivableID))
                .ForMember(d => d.RSettingID, map => map.MapFrom(s => s.RSettingID))
                .ForMember(d => d.ReleaseDate, map => map.MapFrom(s => s.ReleaseDate))
                .ForMember(d => d.MaturityDate, map => map.MapFrom(s => s.MaturityDate))
                .ForMember(d => d.Term, map => map.MapFrom(s => s.Term))
                .ForMember(d => d.Amount, map => map.MapFrom(s => s.Amount))
                .ForMember(d => d.Amortization, map => map.MapFrom(s => s.Amortization))
                .ForMember(d => d.Balance, map => map.MapFrom(s => s.Balance))
                .ForMember(d => d.Status, map => map.MapFrom(s => s.Status))
                .ForMember(d => d.Remarks, map => map.MapFrom(s => s.Remarks))
                .ForMember(d => d.CustomerID, map => map.MapFrom(s => s.CustomerID))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<LoansReceivable, LoansReceivableModel>()
                .ForMember(d => d.ReceivableID, map => map.MapFrom(s => s.ReceivableID))
                .ForMember(d => d.RSettingID, map => map.MapFrom(s => s.RSettingID))
                .ForMember(d => d.ReleaseDate, map => map.MapFrom(s => s.ReleaseDate))
                .ForMember(d => d.MaturityDate, map => map.MapFrom(s => s.MaturityDate))
                .ForMember(d => d.Term, map => map.MapFrom(s => s.Term))
                .ForMember(d => d.Amount, map => map.MapFrom(s => s.Amount))
                .ForMember(d => d.Amortization, map => map.MapFrom(s => s.Amortization))
                .ForMember(d => d.Balance, map => map.MapFrom(s => s.Balance))
                .ForMember(d => d.Status, map => map.MapFrom(s => s.Status))
                .ForMember(d => d.Remarks, map => map.MapFrom(s => s.Remarks))
                .ForMember(d => d.MemberID, map => map.MapFrom(s => s.MemberID))
                .ForMember(d => d.LoanApplicationID, map => map.MapFrom(s => s.LoanApplicationID))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<PaymentSchedule, PaymentScheduleModel>()
                .ForMember(d => d.PaymentScheduleID, map => map.MapFrom(s => s.PaymentScheduleID))
                .ForMember(d => d.ReceivableID, map => map.MapFrom(s => s.ReceivableID))
                .ForMember(d => d.PaymentDate, map => map.MapFrom(s => s.PaymentDate))
                .ForMember(d => d.Type, map => map.MapFrom(s => s.Type))
                .ForMember(d => d.Amount, map => map.MapFrom(s => s.Amount))
                .ForMember(d => d.PCAccountID, map => map.MapFrom(s => s.PCAccountID))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<ReceivableTransaction, ReceivableTransactionModel>()
                .ForMember(d => d.ReceivableTransactionID, map => map.MapFrom(s => s.ReceivableTransactionID))
                .ForMember(d => d.TransationDate, map => map.MapFrom(s => s.TransationDate))
                .ForMember(d => d.ReceivableID, map => map.MapFrom(s => s.ReceivableID))
                .ForMember(d => d.Amount, map => map.MapFrom(s => s.Amount))
                .ForMember(d => d.JournalID, map => map.MapFrom(s => s.JournalID))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<ReceivableTransactionDetail, ReceivableTransactionDetailModel>()
                .ForMember(d => d.ReceivableID, map => map.MapFrom(s => s.ReceivableID))
                .ForMember(d => d.ReceivableTransactionID, map => map.MapFrom(s => s.ReceivableTransactionID))
                .ForMember(d => d.JournalDetailID, map => map.MapFrom(s => s.JournalDetailID))
                .ForMember(d => d.PaymentScheduleID, map => map.MapFrom(s => s.PaymentScheduleID))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<Module, ModuleModel>()
                .ForMember(d => d.ModuleID, map => map.MapFrom(s => s.ModuleID))
                .ForMember(d => d.ModuleName, map => map.MapFrom(s => s.ModuleName))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<UserLevel, UserLevelModel>()
                .ForMember(d => d.UserLevelID, map => map.MapFrom(s => s.UserLevelID))
                .ForMember(d => d.Name, map => map.MapFrom(s => s.Name))
                .ForMember(d => d.Description, map => map.MapFrom(s => s.Description))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();
        }
    }
}

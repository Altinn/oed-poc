#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"

namespace dan_oed_poc_razor.Models.External
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class AccountDetail
    {
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AccountStatus Status { get; set; }

        [Newtonsoft.Json.JsonProperty("servicer", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FinancialInstitution Servicer { get; set; }

        [Newtonsoft.Json.JsonProperty("accountIdentifier", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string AccountIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("accountReference", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string AccountReference { get; set; }

        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AccountType Type { get; set; }

        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"[A-Z]{3,3}")]
        public string Currency { get; set; }

        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(70, MinimumLength = 1)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("balances", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Balance> Balances { get; set; }

        [Newtonsoft.Json.JsonProperty("primaryOwner", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AccountRole PrimaryOwner { get; set; }

        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime StartDate { get; set; }

        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime EndDate { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum AccountPermissionType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"rightToUseAlone")]
        RightToUseAlone = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"rightToUseWithOther")]
        RightToUseWithOther = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"rightToSeeOnly")]
        RightToSeeOnly = 2,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class AccountRole
    {
        [Newtonsoft.Json.JsonProperty("permission", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AccountPermissionType Permission { get; set; }

        [Newtonsoft.Json.JsonProperty("identifier", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Identifier Identifier { get; set; }

        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(140, MinimumLength = 1)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime StartDate { get; set; }

        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime EndDate { get; set; }

        [Newtonsoft.Json.JsonProperty("postalAddress", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PostalAddress PostalAddress { get; set; }

        [Newtonsoft.Json.JsonProperty("electronicAddresses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ElectronicAddress> ElectronicAddresses { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum AccountStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"enabled")]
        Enabled = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"disabled")]
        Disabled = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"deleted")]
        Deleted = 2,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum AccountType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"loanAccount")]
        LoanAccount = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"salaryAccount")]
        SalaryAccount = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"currencyAccount")]
        CurrencyAccount = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"savingsAccount")]
        SavingsAccount = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"clientAccount")]
        ClientAccount = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"taxDeductionAccount")]
        TaxDeductionAccount = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"businessAccount")]
        BusinessAccount = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"creditCardAccount")]
        CreditCardAccount = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"prepaidCardAccount")]
        PrepaidCardAccount = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"otherAccount")]
        OtherAccount = 9,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum AddressType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"residential")]
        Residential = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"business")]
        Business = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"mailTo")]
        MailTo = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"deliveryTo")]
        DeliveryTo = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Balance
    {
        [Newtonsoft.Json.JsonProperty("creditLineIncluded", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool CreditLineIncluded { get; set; }

        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double Amount { get; set; }

        [Newtonsoft.Json.JsonProperty("creditDebitIndicator", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CreditOrDebit CreditDebitIndicator { get; set; }

        [Newtonsoft.Json.JsonProperty("registered", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime Registered { get; set; }

        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BalanceType Type { get; set; }

        [Newtonsoft.Json.JsonProperty("creditLineAmount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double CreditLineAmount { get; set; }

        [Newtonsoft.Json.JsonProperty("creditLineCurrency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"[A-Z]{3,3}")]
        public string CreditLineCurrency { get; set; }

        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"[A-Z]{3,3}")]
        public string Currency { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum BalanceType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"availableBalance")]
        AvailableBalance = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"bookedBalance")]
        BookedBalance = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class BankTransactionCode
    {
        [Newtonsoft.Json.JsonProperty("domain", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DomainType Domain { get; set; }

        [Newtonsoft.Json.JsonProperty("family", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FamilyType Family { get; set; }

        [Newtonsoft.Json.JsonProperty("subFamily", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SubFamilyType SubFamily { get; set; }

        [Newtonsoft.Json.JsonProperty("freeText", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(500, MinimumLength = 1)]
        public string FreeText { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Cards
    {
        [Newtonsoft.Json.JsonProperty("responseStatus", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ResponseStatus ResponseStatus { get; set; }

        [Newtonsoft.Json.JsonProperty("paymentCards", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<PaymentCard> PaymentCards { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum CardType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"creditCard")]
        CreditCard = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"debitCard")]
        DebitCard = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class CounterParty
    {
        [Newtonsoft.Json.JsonProperty("accountIdentifier", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("identifier", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Identifier Identifier { get; set; }

        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(140, MinimumLength = 1)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CounterPartyType Type { get; set; }

        [Newtonsoft.Json.JsonProperty("postalAddress", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PostalAddress PostalAddress { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum CounterPartyType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"debtor")]
        Debtor = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"creditor")]
        Creditor = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"ultimateDebtor")]
        UltimateDebtor = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"ultimateCreditor")]
        UltimateCreditor = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum CreditOrDebit
    {
        [System.Runtime.Serialization.EnumMember(Value = @"credit")]
        Credit = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"debit")]
        Debit = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class CurrencyExchange
    {
        [Newtonsoft.Json.JsonProperty("originalAmount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double OriginalAmount { get; set; }

        [Newtonsoft.Json.JsonProperty("sourceCurrency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"[A-Z]{3,3}")]
        public string SourceCurrency { get; set; }

        [Newtonsoft.Json.JsonProperty("targetCurrency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"[A-Z]{3,3}")]
        public string TargetCurrency { get; set; }

        [Newtonsoft.Json.JsonProperty("unitCurrency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"[A-Z]{3,3}")]
        public string UnitCurrency { get; set; }

        [Newtonsoft.Json.JsonProperty("exchangeRate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double ExchangeRate { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum DomainType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"accountManagement")]
        AccountManagement = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"cashManagement")]
        CashManagement = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"foreignExchange")]
        ForeignExchange = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"payments")]
        Payments = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"securities")]
        Securities = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"tradeServices")]
        TradeServices = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"extended")]
        Extended = 6,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class ElectronicAddress
    {
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ElectronicAddressType Type { get; set; }

        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(2048, MinimumLength = 1)]
        public string Value { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum ElectronicAddressType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"phoneNumber")]
        PhoneNumber = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"emailAddress")]
        EmailAddress = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum FamilyType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"additionalMiscellaneousCreditOperations")]
        AdditionalMiscellaneousCreditOperations = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"additionalMiscellaneousDebitOperations")]
        AdditionalMiscellaneousDebitOperations = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"miscellaneousCreditOperations")]
        MiscellaneousCreditOperations = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"miscellaneousDebitOperations")]
        MiscellaneousDebitOperations = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"openingAndClosing")]
        OpeningAndClosing = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"accountBalancing")]
        AccountBalancing = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"cashPooling")]
        CashPooling = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"notAvailable")]
        NotAvailable = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"customerCardTransactions")]
        CustomerCardTransactions = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"counterTransactions")]
        CounterTransactions = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"drafts")]
        Drafts = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"issuedCashConcentrationTransactions")]
        IssuedCashConcentrationTransactions = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"issuedCreditTransfers")]
        IssuedCreditTransfers = 12,

        [System.Runtime.Serialization.EnumMember(Value = @"issuedCheques")]
        IssuedCheques = 13,

        [System.Runtime.Serialization.EnumMember(Value = @"issuedDirectDebits")]
        IssuedDirectDebits = 14,

        [System.Runtime.Serialization.EnumMember(Value = @"lockboxTransactions")]
        LockboxTransactions = 15,

        [System.Runtime.Serialization.EnumMember(Value = @"merchantCardTransactions")]
        MerchantCardTransactions = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"other")]
        Other = 17,

        [System.Runtime.Serialization.EnumMember(Value = @"receivedCashConcentrationTransactions")]
        ReceivedCashConcentrationTransactions = 18,

        [System.Runtime.Serialization.EnumMember(Value = @"receivedCreditTransfers")]
        ReceivedCreditTransfers = 19,

        [System.Runtime.Serialization.EnumMember(Value = @"receivedCheques")]
        ReceivedCheques = 20,

        [System.Runtime.Serialization.EnumMember(Value = @"receivedDirectDebits")]
        ReceivedDirectDebits = 21,

        [System.Runtime.Serialization.EnumMember(Value = @"corporateAction")]
        CorporateAction = 22,

        [System.Runtime.Serialization.EnumMember(Value = @"documentaryCollection")]
        DocumentaryCollection = 23,

        [System.Runtime.Serialization.EnumMember(Value = @"standByLetterOfCredit")]
        StandByLetterOfCredit = 24,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class FinancialInstitution
    {
        [Newtonsoft.Json.JsonProperty("identifier", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Identifier Identifier { get; set; } = new Identifier();

        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(140, MinimumLength = 1)]
        public string Name { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Identifier
    {
        [Newtonsoft.Json.JsonProperty("countryOfResidence", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"[A-Z]{2,2}")]
        public string CountryOfResidence { get; set; }

        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Value { get; set; }

        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public IdentifierType Type { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum IdentifierType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"countryIdentificationCode")]
        CountryIdentificationCode = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"nationalIdentityNumber")]
        NationalIdentityNumber = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Link
    {
        [Newtonsoft.Json.JsonProperty("rel", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(50, MinimumLength = 1)]
        public string Rel { get; set; }

        [Newtonsoft.Json.JsonProperty("href", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(500, MinimumLength = 1)]
        public string Href { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class PaymentCard
    {
        [Newtonsoft.Json.JsonProperty("cardIdentifier", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string CardIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("holderName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(140, MinimumLength = 1)]
        public string HolderName { get; set; }

        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^[0-9]+-([0][1-9]|1[0-2])$")]
        public string StartDate { get; set; }

        [Newtonsoft.Json.JsonProperty("expiryDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^[0-9]+-([0][1-9]|1[0-2])$")]
        public string ExpiryDate { get; set; }

        [Newtonsoft.Json.JsonProperty("cardIssuerName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(140, MinimumLength = 1)]
        public string CardIssuerName { get; set; }

        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CardType Type { get; set; }

        [Newtonsoft.Json.JsonProperty("cardIssuerIdentifier", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Identifier CardIssuerIdentifier { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class PostalAddress
    {
        [Newtonsoft.Json.JsonProperty("postCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(16, MinimumLength = 1)]
        public string PostCode { get; set; }

        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AddressType Type { get; set; }

        [Newtonsoft.Json.JsonProperty("streetName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(70, MinimumLength = 1)]
        public string StreetName { get; set; }

        [Newtonsoft.Json.JsonProperty("buildingNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(16, MinimumLength = 1)]
        public string BuildingNumber { get; set; }

        [Newtonsoft.Json.JsonProperty("townName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        public string TownName { get; set; }

        [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"[A-Z]{2,2}")]
        public string Country { get; set; }

        [Newtonsoft.Json.JsonProperty("addressLines", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> AddressLines { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum ResponseStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"partial")]
        Partial = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"complete")]
        Complete = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Roles
    {
        [Newtonsoft.Json.JsonProperty("responseStatus", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ResponseStatus ResponseStatus { get; set; }

        [Newtonsoft.Json.JsonProperty("roles", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AccountRole> Roles1 { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum SubFamilyType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"valueDate")]
        ValueDate = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"chargesGeneric")]
        ChargesGeneric = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"commissions")]
        Commissions = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"interestsGeneric")]
        InterestsGeneric = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"other")]
        Other = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"accountClosing")]
        AccountClosing = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"notAvailable")]
        NotAvailable = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"sweeping")]
        Sweeping = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"topping")]
        Topping = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"zeroBalancing")]
        ZeroBalancing = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"cashWithdrawal")]
        CashWithdrawal = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"debitCardPayment")]
        DebitCardPayment = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"crossBorderCashWithdrawal")]
        CrossBorderCashWithdrawal = 12,

        [System.Runtime.Serialization.EnumMember(Value = @"cashDeposit")]
        CashDeposit = 13,

        [System.Runtime.Serialization.EnumMember(Value = @"debitAdjustmentGeneric")]
        DebitAdjustmentGeneric = 14,

        [System.Runtime.Serialization.EnumMember(Value = @"travellersChequesDeposit")]
        TravellersChequesDeposit = 15,

        [System.Runtime.Serialization.EnumMember(Value = @"settlementAtMaturity")]
        SettlementAtMaturity = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"intraCompanyTransfer")]
        IntraCompanyTransfer = 17,

        [System.Runtime.Serialization.EnumMember(Value = @"corporateOwnAccountTransfer")]
        CorporateOwnAccountTransfer = 18,

        [System.Runtime.Serialization.EnumMember(Value = @"crossBorderIntraCompanyTransfer")]
        CrossBorderIntraCompanyTransfer = 19,

        [System.Runtime.Serialization.EnumMember(Value = @"achDebit")]
        AchDebit = 20,

        [System.Runtime.Serialization.EnumMember(Value = @"achReturn")]
        AchReturn = 21,

        [System.Runtime.Serialization.EnumMember(Value = @"achTransactionAtxn")]
        AchTransactionAtxn = 22,

        [System.Runtime.Serialization.EnumMember(Value = @"automaticTransfer")]
        AutomaticTransfer = 23,

        [System.Runtime.Serialization.EnumMember(Value = @"bankCheque")]
        BankCheque = 24,

        [System.Runtime.Serialization.EnumMember(Value = @"booked")]
        Booked = 25,

        [System.Runtime.Serialization.EnumMember(Value = @"domesticCreditTransfer")]
        DomesticCreditTransfer = 26,

        [System.Runtime.Serialization.EnumMember(Value = @"dividend")]
        Dividend = 27,

        [System.Runtime.Serialization.EnumMember(Value = @"sepaCreditTransfer")]
        SepaCreditTransfer = 28,

        [System.Runtime.Serialization.EnumMember(Value = @"financialInstitutionCreditTransfer")]
        FinancialInstitutionCreditTransfer = 29,

        [System.Runtime.Serialization.EnumMember(Value = @"principalPayment")]
        PrincipalPayment = 30,

        [System.Runtime.Serialization.EnumMember(Value = @"priorityCreditTransfer")]
        PriorityCreditTransfer = 31,

        [System.Runtime.Serialization.EnumMember(Value = @"reversalDueToPaymentReturn")]
        ReversalDueToPaymentReturn = 32,

        [System.Runtime.Serialization.EnumMember(Value = @"achTransactionSala")]
        AchTransactionSala = 33,

        [System.Runtime.Serialization.EnumMember(Value = @"sameDayValueCreditTransfer")]
        SameDayValueCreditTransfer = 34,

        [System.Runtime.Serialization.EnumMember(Value = @"standingOrder")]
        StandingOrder = 35,

        [System.Runtime.Serialization.EnumMember(Value = @"taxes")]
        Taxes = 36,

        [System.Runtime.Serialization.EnumMember(Value = @"creditTransferWithAgreedCommercialInformation")]
        CreditTransferWithAgreedCommercialInformation = 37,

        [System.Runtime.Serialization.EnumMember(Value = @"crossBorderCreditTransfer")]
        CrossBorderCreditTransfer = 38,

        [System.Runtime.Serialization.EnumMember(Value = @"cashLetter")]
        CashLetter = 39,

        [System.Runtime.Serialization.EnumMember(Value = @"cheques")]
        Cheques = 40,

        [System.Runtime.Serialization.EnumMember(Value = @"chequesReversal")]
        ChequesReversal = 41,

        [System.Runtime.Serialization.EnumMember(Value = @"openCheque")]
        OpenCheque = 42,

        [System.Runtime.Serialization.EnumMember(Value = @"unpaidCheque")]
        UnpaidCheque = 43,

        [System.Runtime.Serialization.EnumMember(Value = @"crossBorderCheque")]
        CrossBorderCheque = 44,

        [System.Runtime.Serialization.EnumMember(Value = @"sepaCoreDirectDebit")]
        SepaCoreDirectDebit = 45,

        [System.Runtime.Serialization.EnumMember(Value = @"directDebitPayment")]
        DirectDebitPayment = 46,

        [System.Runtime.Serialization.EnumMember(Value = @"reversalDueToPayment")]
        ReversalDueToPayment = 47,

        [System.Runtime.Serialization.EnumMember(Value = @"reversalDueToPaymentCancellationRequest")]
        ReversalDueToPaymentCancellationRequest = 48,

        [System.Runtime.Serialization.EnumMember(Value = @"reversalDueToReturnUnpaidDirectDebit")]
        ReversalDueToReturnUnpaidDirectDebit = 49,

        [System.Runtime.Serialization.EnumMember(Value = @"debit")]
        Debit = 50,

        [System.Runtime.Serialization.EnumMember(Value = @"deposit")]
        Deposit = 51,

        [System.Runtime.Serialization.EnumMember(Value = @"adjustments")]
        Adjustments = 52,

        [System.Runtime.Serialization.EnumMember(Value = @"fees")]
        Fees = 53,

        [System.Runtime.Serialization.EnumMember(Value = @"creditCardPayment")]
        CreditCardPayment = 54,

        [System.Runtime.Serialization.EnumMember(Value = @"pointOfSalePosPayment")]
        PointOfSalePosPayment = 55,

        [System.Runtime.Serialization.EnumMember(Value = @"creditAdjustment")]
        CreditAdjustment = 56,

        [System.Runtime.Serialization.EnumMember(Value = @"settlementAfterCollection")]
        SettlementAfterCollection = 57,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Transaction
    {
        [Newtonsoft.Json.JsonProperty("transactionIdentifier", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string TransactionIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("references", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<TransactionReference> References { get; set; }

        [Newtonsoft.Json.JsonProperty("creditDebitIndicator", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CreditOrDebit CreditDebitIndicator { get; set; }

        [Newtonsoft.Json.JsonProperty("reversalIndicator", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool ReversalIndicator { get; set; }

        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TransactionStatus Status { get; set; }

        [Newtonsoft.Json.JsonProperty("transactionCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BankTransactionCode TransactionCode { get; set; }

        [Newtonsoft.Json.JsonProperty("bookingDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime BookingDate { get; set; }

        [Newtonsoft.Json.JsonProperty("valueDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime ValueDate { get; set; }

        [Newtonsoft.Json.JsonProperty("counterParties", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CounterParty> CounterParties { get; set; }

        [Newtonsoft.Json.JsonProperty("additionalInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(500, MinimumLength = 1)]
        public string AdditionalInfo { get; set; }

        [Newtonsoft.Json.JsonProperty("currencyExchange", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CurrencyExchange CurrencyExchange { get; set; }

        [Newtonsoft.Json.JsonProperty("merchant", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(140, MinimumLength = 1)]
        public string Merchant { get; set; }

        [Newtonsoft.Json.JsonProperty("paymentCard", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PaymentCard PaymentCard { get; set; }

        [Newtonsoft.Json.JsonProperty("registered", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime Registered { get; set; }

        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double Amount { get; set; }

        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"[A-Z]{3,3}")]
        public string Currency { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class TransactionReference
    {
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Value { get; set; }

        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TransactionReferenceType Type { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum TransactionReferenceType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"accountServicerReference")]
        AccountServicerReference = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"archiveReference")]
        ArchiveReference = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"chequeNumber")]
        ChequeNumber = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"endToEndIdentification")]
        EndToEndIdentification = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"instructionIdentification")]
        InstructionIdentification = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"invoiceNumber")]
        InvoiceNumber = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"mandateIdentification")]
        MandateIdentification = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"messageIdentification")]
        MessageIdentification = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"otherReference")]
        OtherReference = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"paymentInformationIdentification")]
        PaymentInformationIdentification = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"remittanceReference")]
        RemittanceReference = 10,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum TransactionStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"booked")]
        Booked = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"pending")]
        Pending = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"info")]
        Info = 2,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Transactions
    {
        [Newtonsoft.Json.JsonProperty("responseStatus", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ResponseStatus ResponseStatus { get; set; }

        [Newtonsoft.Json.JsonProperty("transactions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Transaction> Transactions1 { get; set; }

        [Newtonsoft.Json.JsonProperty("links", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Link> Links { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>Error structure for error message 400</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Error400
    {
        /// <summary>error code, for automatic handling</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>Best possible description of the error from Data Provider.</summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Message { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>Error structure for error message 401</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Error401
    {
        /// <summary>error code, for automatic handling</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>Best possible description of the error from Data Provider.</summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Message { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>Error structure for error message 403</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Error403
    {
        /// <summary>error code, for automatic handling</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>Best possible description of the error from Data Provider</summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Message { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>Error structure for error message 404</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Error404
    {
        /// <summary>error code, for automatic handling</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>Best possible description of the error from Data Provider</summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Message { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>Error structure for error message 405</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Error405
    {
        /// <summary>error code, for automatic handling</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>Best possible description of the error from Data Provider</summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Message { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>Error structure for error message 429</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Error429
    {
        /// <summary>error code, for automatic handling</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>Best possible description of the error from Data Provider</summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Message { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>Error structure for error message 500</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Error500
    {
        /// <summary>error code, for automatic handling</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>Best possible description of the error from Data Provider</summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Message { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>Error structure for all error messages</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Error
    {
        /// <summary>error code, for automatic handling</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>Best possible description of the error from Data Provider</summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Message { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum AdditionalReferenceIDType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"pol")]
        Pol = 0,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum AdditionalReferenceIDType2
    {
        [System.Runtime.Serialization.EnumMember(Value = @"pol")]
        Pol = 0,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum AdditionalReferenceIDType3
    {
        [System.Runtime.Serialization.EnumMember(Value = @"pol")]
        Pol = 0,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum AdditionalReferenceIDType4
    {
        [System.Runtime.Serialization.EnumMember(Value = @"pol")]
        Pol = 0,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum AdditionalReferenceIDType5
    {
        [System.Runtime.Serialization.EnumMember(Value = @"pol")]
        Pol = 0,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.13.2.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v11.0.0.0))")]
    internal class DateFormatConverter : Newtonsoft.Json.Converters.IsoDateTimeConverter
    {
        public DateFormatConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016

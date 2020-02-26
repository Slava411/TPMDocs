namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sbyt.tbContract")]
    public partial class tbContract
    {
        [Key]
        public int ContractID { get; set; }

        public int? ParentContractID { get; set; }

        [StringLength(50)]
        public string ParentContractNum { get; set; }

        public DateTime? ParentContractDate { get; set; }

        public int? RegistrationNum { get; set; }

        public DateTime? RegistrationDate { get; set; }

        [StringLength(50)]
        public string ContractNum { get; set; }

        public DateTime? ContractDate { get; set; }

        public int? ContractDocNum { get; set; }

        public int? DocTypeID { get; set; }

        public int? DocContentID { get; set; }

        [StringLength(255)]
        public string DocContent { get; set; }

        public int? ClientID { get; set; }

        public int? EmployeeID { get; set; }

        [StringLength(50)]
        public string Employee { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? FinishDate { get; set; }

        public DateTime? CloseDate { get; set; }

        [StringLength(255)]
        public string CloseDateName { get; set; }

        [StringLength(255)]
        public string FolderNum { get; set; }

        public string FilePath { get; set; }

        public DateTime? DateOriginal { get; set; }

        public DateTime? DocDate1 { get; set; }

        public DateTime? DocDate2 { get; set; }

        public int? IsActive { get; set; }

        [StringLength(3)]
        public string CurrencyID { get; set; }

        [StringLength(3)]
        public string Currency { get; set; }

        public int? TitlePassingTermsID { get; set; }

        public int? TransportMode { get; set; }

        public int? DeliveryTermsID { get; set; }

        [StringLength(255)]
        public string DeliveryTerms { get; set; }

        public int? DeliveryDays { get; set; }

        public int? DeliveryDayTypeID { get; set; }

        public double? PrepayPercent { get; set; }

        public int? PaymentDelayDays { get; set; }

        public int? PenaltyDays { get; set; }

        public double? Penalty { get; set; }

        public int? PaymentTermsID { get; set; }

        public int? PayDayTypeID { get; set; }

        public int? PayDay1 { get; set; }

        public int? PayDay2 { get; set; }

        public int? PayDay3 { get; set; }

        public int? PayDay4 { get; set; }

        public int? PayDay5 { get; set; }

        public int? PayDayCalcMethod { get; set; }

        public int? IsStereo { get; set; }

        public int? IsForm { get; set; }

        public int? IsPallets { get; set; }

        public int? IsFrames { get; set; }

        public int? VATPercent { get; set; }

        public double? ProdSumTotal { get; set; }

        public double? CreditSum { get; set; }

        public int? OrderDays1 { get; set; }

        public int? OrderDays2 { get; set; }

        public int? OrderDayType1ID { get; set; }

        public int? OrderDayType2ID { get; set; }

        public DateTime? ChkDate { get; set; }

        [StringLength(255)]
        public string ChkName { get; set; }

        public DateTime? CrDate { get; set; }

        [StringLength(50)]
        public string CrPC { get; set; }

        public bool? flNoPrintPallets1C { get; set; }

        public bool? flPrice1000 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }

        public bool? flNoKf { get; set; }

        public int? ClientID_Dop { get; set; }

        public int FreeStoreDays { get; set; }
    }
}

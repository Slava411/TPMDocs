namespace TPMDocs.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("sbyt.tbContractDeliveryTerms")]
    public partial class tbContractDeliveryTerm
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CDeliveryTermID { get; set; }

        public int? ContractID { get; set; }

        public int? DeliveryTermID { get; set; }

        [StringLength(3)]
        public string DeliveryTerm { get; set; }

        public int? DeliveryTermPlaceID { get; set; }

        [StringLength(255)]
        public string DeliveryTermPlace { get; set; }

        public DateTime? CrDate { get; set; }

        [StringLength(50)]
        public string CrPC { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}

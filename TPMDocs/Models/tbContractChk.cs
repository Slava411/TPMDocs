namespace TPMDocs.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("sbyt.tbContractChk")]
    public partial class tbContractChk
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string PCName { get; set; }

        public bool? IsChkPrice { get; set; }

        public bool? IsChkDoc { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}

namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sbyt.tbContractProd")]
    public partial class tbContractProd
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CProdID { get; set; }

        public int? ParentCProdID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContractID { get; set; }

        public int? ProdGroupID { get; set; }

        [StringLength(10)]
        public string ProdCode { get; set; }

        public int? ProdID1 { get; set; }

        public int? ProdID2 { get; set; }

        public int? SortOrder { get; set; }

        [StringLength(255)]
        public string ProdName1 { get; set; }

        [StringLength(255)]
        public string ProdName2 { get; set; }

        public int? ProdNameSelect { get; set; }

        public double? QtyStart { get; set; }

        public double? Qty { get; set; }

        public int? QtySelect { get; set; }

        public int? UnitID { get; set; }

        public double? Price { get; set; }

        public double? ProdSum { get; set; }

        public DateTime? ChkDate { get; set; }

        [StringLength(255)]
        public string ChkName { get; set; }

        public int? DeliveryTermID { get; set; }

        [StringLength(3)]
        public string DeliveryTerm { get; set; }

        public int? DeliveryTermPlaceID { get; set; }

        [StringLength(30)]
        public string DeliveryTermPlace { get; set; }

        public DateTime? PriceStartDate { get; set; }

        public DateTime? PriceFinishDate { get; set; }

        public int? TransportMode { get; set; }

        public int? ArchiveDate { get; set; }

        public DateTime? UpDate { get; set; }

        [StringLength(30)]
        public string UpPC { get; set; }

        public DateTime? CrDate { get; set; }

        [StringLength(50)]
        public string CrPC { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool flFixName { get; set; }
    }
}

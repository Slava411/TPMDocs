namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sbyt.tbContractCategories")]
    public partial class tbContractCategory
    {
        public int? Category { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        [StringLength(100)]
        public string Name1 { get; set; }

        [StringLength(100)]
        public string Name2 { get; set; }

        [StringLength(100)]
        public string Name3 { get; set; }

        public double? Double1 { get; set; }

        public double? Double2 { get; set; }

        public int? Long1 { get; set; }

        public int? Long2 { get; set; }

        public bool? IsArchived { get; set; }

        public DateTime? CrDate { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}

namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sbyt.tbGoodCodes")]
    public partial class tbGoodCode
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string GoodCodeID { get; set; }

        [StringLength(255)]
        public string GoodName { get; set; }

        [StringLength(255)]
        public string GoodDesc { get; set; }

        public int? ProdGroupID { get; set; }

        public bool? IsArchived { get; set; }

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

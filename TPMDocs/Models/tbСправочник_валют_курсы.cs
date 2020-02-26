namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spravoh.tbСправочник валют_курсы")]
    public partial class tbСправочник_валют_курсы
    {
        [Key]
        public int Code { get; set; }

        [Required]
        [StringLength(3)]
        public string CurrencyCode { get; set; }

        public int Kf { get; set; }

        public double Rate { get; set; }

        public DateTime RateDate { get; set; }

        public DateTime? CrDate { get; set; }

        public DateTime? EdDate { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}

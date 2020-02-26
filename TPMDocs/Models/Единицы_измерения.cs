namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spravoh.Единицы измерения")]
    public partial class Единицы_измерения
    {
        [Key]
        public int Код { get; set; }

        [StringLength(100)]
        public string Наименование { get; set; }

        [Column("Короткое название")]
        [StringLength(6)]
        public string Короткое_название { get; set; }

        [StringLength(100)]
        public string Наименование_1 { get; set; }

        public bool? InUseTr { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}

namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spravoh.Виды гофропродукции")]
    public partial class Виды_гофропродукции
    {
        [Key]
        public byte Код { get; set; }

        [StringLength(100)]
        public string Вид { get; set; }

        [Column("Родительный падеж")]
        [StringLength(100)]
        public string Родительный_падеж { get; set; }

        [Column("Доп продукция")]
        public bool? Доп_продукция { get; set; }

        [Column("Код соответствия")]
        public int? Код_соответствия { get; set; }

        [StringLength(100)]
        public string ВидРус { get; set; }

        [Column("Родительный падеж Рус")]
        [StringLength(100)]
        public string Родительный_падеж_Рус { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}

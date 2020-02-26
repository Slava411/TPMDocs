namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spravoh.Справочник клиентов_продукция")]
    public partial class Справочник_клиентов_продукция
    {
        public int? Код { get; set; }

        [StringLength(1)]
        public string Признак { get; set; }

        [Column("Наименование продукции")]
        [StringLength(60)]
        public string Наименование_продукции { get; set; }

        [Column("Единица измерения")]
        public byte? Единица_измерения { get; set; }

        public double? Цена { get; set; }

        [StringLength(3)]
        public string Валюта { get; set; }

        public DateTime? Дата { get; set; }

        [Key]
        public int SSMA_RowID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}

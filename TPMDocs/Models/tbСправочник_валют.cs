namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spravoh.tbСправочник валют")]
    public partial class tbСправочник_валют
    {
        [Key]
        [Column("Код валюты")]
        [StringLength(3)]
        public string Код_валюты { get; set; }

        [Column("Код государства")]
        [StringLength(3)]
        public string Код_государства { get; set; }

        [Column("Код Альфа3")]
        [StringLength(3)]
        public string Код_Альфа3 { get; set; }

        [Column("Группа валют")]
        [StringLength(1)]
        public string Группа_валют { get; set; }

        [Column("Группа конвертации")]
        public byte? Группа_конвертации { get; set; }

        [Column("Имя валюты русское")]
        [StringLength(35)]
        public string Имя_валюты_русское { get; set; }

        [Column("Имя валюты украинское")]
        [StringLength(30)]
        public string Имя_валюты_украинское { get; set; }

        public double? Номинал { get; set; }

        [Column("Имя русское")]
        [StringLength(35)]
        public string Имя_русское { get; set; }

        [Column("Имя украинское")]
        [StringLength(30)]
        public string Имя_украинское { get; set; }

        [Column("Имя краткое русское")]
        [StringLength(10)]
        public string Имя_краткое_русское { get; set; }

        [Column("Имя краткое украинское")]
        [StringLength(10)]
        public string Имя_краткое_украинское { get; set; }

        public bool? InUse { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}

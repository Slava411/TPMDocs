namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spravoh.Справочник клиентов_банки")]
    public partial class Справочник_клиентов_банки
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Код { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte Номер { get; set; }

        [StringLength(6)]
        public string МФО { get; set; }

        [Column("Идентификатор банка")]
        [StringLength(10)]
        public string Идентификатор_банка { get; set; }

        [Column("Расчетный счет")]
        [StringLength(25)]
        public string Расчетный_счет { get; set; }

        [StringLength(255)]
        public string Примечание { get; set; }

        public bool? Признак_доп_реквизит { get; set; }

        public string Доп_реквизит { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}

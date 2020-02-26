namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spravoh.Справочник клиентов_жд")]
    public partial class Справочник_клиентов_жд
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Код { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Номер { get; set; }

        [Column("Код ж/д")]
        public int? Код_ж_д { get; set; }

        [Column("Код станции")]
        public int? Код_станции { get; set; }

        [Column("Код клиента по ж_д")]
        public int? Код_клиента_по_ж_д { get; set; }

        [Column("Ж_д ветка")]
        [StringLength(50)]
        public string Ж_д_ветка { get; set; }

        [Column("Код ж/д границы")]
        public int? Код_ж_д_границы { get; set; }

        [Column("Код станции границы")]
        public double? Код_станции_границы { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}

namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spravoh.Справочник клиентов_поставка")]
    public partial class Справочник_клиентов_поставка
    {
        [Column("#КлиентПД")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int C_КлиентПД { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int КодКлиент { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int КодВидТр { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int КодВидПрод { get; set; }

        public int? КодЗона { get; set; }

        public int? КодГород { get; set; }

        [StringLength(255)]
        public string Адрес { get; set; }

        public bool? InUse { get; set; }

        public bool? CrUser { get; set; }

        public DateTime? CrDate { get; set; }

        [StringLength(50)]
        public string CrPC { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}

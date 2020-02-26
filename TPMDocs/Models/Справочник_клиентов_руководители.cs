namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spravoh.Справочник клиентов_руководители")]
    public partial class Справочник_клиентов_руководители
    {
        public int? Код { get; set; }

        [StringLength(50)]
        public string Должность { get; set; }

        [StringLength(1000)]
        public string ФИО { get; set; }

        [StringLength(15)]
        public string Телефон { get; set; }

        [StringLength(255)]
        public string Примечание { get; set; }

        [Key]
        public int SSMA_RowID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}

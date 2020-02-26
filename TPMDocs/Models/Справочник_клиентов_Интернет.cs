namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spravoh.Справочник клиентов_Интернет")]
    public partial class Справочник_клиентов_Интернет
    {
        public int? Код { get; set; }

        [StringLength(100)]
        public string E_mail { get; set; }

        [StringLength(255)]
        public string Комментарий { get; set; }

        [StringLength(255)]
        public string WWW_сервер { get; set; }

        [Key]
        public int SSMA_RowID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}

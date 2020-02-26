namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spravoh.tbУсловия поставки")]
    public partial class tbУсловия_поставки
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int УсловияID { get; set; }

        [StringLength(30)]
        public string УсловияИмя { get; set; }

        [StringLength(255)]
        public string Комментарий { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}

namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spravoh.Виды отгрузки")]
    public partial class Виды_отгрузки
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Код { get; set; }

        [Column("Вид отгрузки")]
        [Required]
        [StringLength(100)]
        public string Вид_отгрузки { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}

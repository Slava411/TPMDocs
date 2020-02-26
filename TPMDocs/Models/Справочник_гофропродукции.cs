namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spravoh.Справочник гофропродукции")]
    public partial class Справочник_гофропродукции
    {
        [Key]
        [Column("Код комплекта")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Код_комплекта { get; set; }

        [Column("Код комплектующего")]
        public int? Код_комплектующего { get; set; }

        [Column("Вид гофропродукции")]
        public int? Вид_гофропродукции { get; set; }

        [Column("Код ГОСТа")]
        public int? Код_ГОСТа { get; set; }

        [StringLength(100)]
        public string ГОСТ_чертеж { get; set; }

        public short? Длина { get; set; }

        public short? Ширина { get; set; }

        public short? Высота { get; set; }

        public double? Площадь { get; set; }

        [Column("Группа сложности")]
        public double? Группа_сложности { get; set; }

        [Column("Вид оборудования")]
        public int? Вид_оборудования { get; set; }

        [Column("Тип оборудования")]
        public int? Тип_оборудования { get; set; }

        public int? КартаНомер { get; set; }

        [StringLength(6)]
        public string КодОтрасли { get; set; }

        public string ДопИнф { get; set; }

        [StringLength(2)]
        public string КодГруппа { get; set; }

        [StringLength(4)]
        public string КодНазнач { get; set; }

        public bool? InUse { get; set; }

        public DateTime? CrDate { get; set; }

        [StringLength(50)]
        public string CrPC { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}

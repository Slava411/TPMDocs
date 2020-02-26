namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spravoh.Работники")]
    public partial class Работники
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Код { get; set; }

        public int? КодЭконОсн { get; set; }

        [StringLength(100)]
        public string Фамилия { get; set; }

        public bool? ОВЭС { get; set; }

        [StringLength(16)]
        public string Имя_машины { get; set; }

        [StringLength(100)]
        public string Должность { get; set; }

        public bool? Руководитель { get; set; }

        public bool? ОперРаб { get; set; }

        public bool? ФинРаб { get; set; }

        public bool? ТехнРаб { get; set; }

        [Column("Код региона")]
        [StringLength(5)]
        public string Код_региона { get; set; }

        public bool? InUse { get; set; }

        [Column("Дата создания")]
        public DateTime? Дата_создания { get; set; }

        public bool? FlagSign { get; set; }

        [StringLength(100)]
        public string ИмяРабУкр { get; set; }

        [StringLength(30)]
        public string Телефон { get; set; }

        public int ArtiosDesignerID { get; set; }

        [StringLength(100)]
        public string Login { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        public int RoleId { get; set; }
    }
}

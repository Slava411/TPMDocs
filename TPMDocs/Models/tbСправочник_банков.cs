namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spravoh.tbСправочник банков")]
    public partial class tbСправочник_банков
    {
        [Key]
        [Column("Идентификатор банка")]
        [StringLength(10)]
        public string Идентификатор_банка { get; set; }

        [Column("Код государства")]
        [StringLength(3)]
        public string Код_государства { get; set; }

        [StringLength(6)]
        public string МФО { get; set; }

        [Column("Наименование банка")]
        [StringLength(100)]
        public string Наименование_банка { get; set; }

        [StringLength(14)]
        public string Коррсчет { get; set; }

        [Column("Почтовый индекс")]
        [StringLength(6)]
        public string Почтовый_индекс { get; set; }

        [Column("Тип нас_пункта")]
        [StringLength(5)]
        public string Тип_нас_пункта { get; set; }

        [Column("Название нас_пункта")]
        [StringLength(100)]
        public string Название_нас_пункта { get; set; }

        [StringLength(255)]
        public string Адрес { get; set; }

        [Column("Междугородный код")]
        [StringLength(6)]
        public string Междугородный_код { get; set; }

        [Column("Фамилия управляющего")]
        [StringLength(100)]
        public string Фамилия_управляющего { get; set; }

        [StringLength(7)]
        public string Телефон_управляющий { get; set; }

        [Column("Фамилия главбуха")]
        [StringLength(100)]
        public string Фамилия_главбуха { get; set; }

        [StringLength(7)]
        public string Телефон_главбух { get; set; }

        [StringLength(7)]
        public string Телефон_дополнительный { get; set; }

        [StringLength(10)]
        public string ОКПО { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}

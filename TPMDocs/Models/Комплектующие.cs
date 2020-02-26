namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spravoh.Комплектующие")]
    public partial class Комплектующие
    {
        [Key]
        public int Код { get; set; }

        [StringLength(100)]
        public string Наименование { get; set; }

        [StringLength(100)]
        public string НаименованиеРус { get; set; }
    }
}

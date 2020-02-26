namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spravoh.Справочник_городов")]
    public partial class Справочник_городов
    {
        [Key]
        public int Code { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string NameUA { get; set; }

        public int? OblastCode { get; set; }

        public int? DistrictCode { get; set; }

        public int? PostalCode { get; set; }

        public int? LogistProID { get; set; }
    }
}

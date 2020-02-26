namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Docs.DocsContracts")]
    public partial class DocsContract
    {
        public int Id { get; set; }

        public int? KardId { get; set; }

        public int? VidDoc { get; set; }

        public int? RegNo { get; set; }

        public int? KlientId { get; set; }

        public int? EcontId { get; set; }

        public DateTime? DateCreate { get; set; }

       
        public int? SubjectId { get; set; }
    }
}

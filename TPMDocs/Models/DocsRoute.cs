namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Docs.DocsRoutes")]
    public partial class DocsRoute
    {
        public int Id { get; set; }

        public int? StatusId { get; set; }

        public int? RouteUsersId { get; set; }

        public DateTime? DateSave { get; set; }

        public int? UserId { get; set; }

        public string Comments { get; set; }

        public int? ContractId { get; set; }
    }
}

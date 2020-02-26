namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Docs.DocsRouteUsers")]
    public partial class DocsRouteUser
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        public int? UserPriority { get; set; }
    }
}

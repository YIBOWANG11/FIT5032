namespace Fit_5032_ass.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Activities
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Location { get; set; }

        [StringLength(10)]
        public string Date { get; set; }

        public int ClientId { get; set; }

        public virtual Clients Clients { get; set; }
    }
}

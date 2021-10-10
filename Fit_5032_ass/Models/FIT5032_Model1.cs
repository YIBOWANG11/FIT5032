using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Fit_5032_ass.Models
{
    public partial class FIT5032_Model1 : DbContext
    {
        public FIT5032_Model1()
            : base("name=FIT5032_Model1")
        {
        }

        public virtual DbSet<Activities> Activities { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clients>()
                .HasMany(e => e.Activities)
                .WithRequired(e => e.Clients)
                .HasForeignKey(e => e.ClientId)
                .WillCascadeOnDelete(false);
        }
    }
}

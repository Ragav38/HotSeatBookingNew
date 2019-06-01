namespace HotSeatBooking
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB_Entities : DbContext
    {
        public DB_Entities()
            : base("name=DB_Entities")
        {
        }

        public virtual DbSet<LoginName> UserProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoginName>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<LoginName>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}

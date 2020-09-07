namespace NepalPayment
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Register> Registers { get; set; }
        public virtual DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>()
                .Property(e => e.SameUserName)
                .IsFixedLength();

            modelBuilder.Entity<Register>()
                .Property(e => e.UserName)
                .IsFixedLength();

            modelBuilder.Entity<Register>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Register>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<Table>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Table>()
                .Property(e => e.TaskList)
                .IsFixedLength();
        }
    }
}

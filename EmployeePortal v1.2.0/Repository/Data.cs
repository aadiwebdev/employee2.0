namespace Repository
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Data : DbContext
    {
        public Data()
            : base("name=Data")
        {
        }

        public virtual DbSet<UserInfo> UserInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInfo>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.IsStudent)
                .IsUnicode(false);
        }
    }
}

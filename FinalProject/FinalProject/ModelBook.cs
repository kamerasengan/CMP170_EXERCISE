using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FinalProject
{
    public partial class ModelBook : DbContext
    {
        public ModelBook()
            : base("name=ModelBook")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookType> BookTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookType>()
                .HasMany(e => e.Books)
                .WithRequired(e => e.BookType)
                .HasForeignKey(e => e.TypeID)
                .WillCascadeOnDelete(false);
        }
    }
}

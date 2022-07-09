using Microsoft.EntityFrameworkCore;
using NoteAppRepository.Entities;

namespace NoteAppRepository.Db_Content
{
    public class DbContent: DbContext
    {
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=localhost;Database=master;Trusted_Connection=True;");
        }
    }
}

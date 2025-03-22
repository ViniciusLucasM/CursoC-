using Microsoft.EntityFrameworkCore;

namespace Person.Data;

public class PersonContext : DbContext
{
    public DbSet<PersonModel> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; Database=master; trusted_connection=true; trustservercertificate=true;");
        base.OnConfiguring(optionsBuilder);
    }
}

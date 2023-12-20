using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options) //DataContext is a constructor, DbContextOptions provide configuration options to DbContext, base option refers to the base class i.e. DbContext
    {
    }

    public DbSet<AppUser> Users{get;set;}
}

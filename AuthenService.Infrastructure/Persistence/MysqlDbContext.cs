using AuthenService.Domain.User;
using Microsoft.EntityFrameworkCore;

namespace AuthenService.Infrastructure.Persistence;

public class MysqlDbContext : DbContext
{
    public MysqlDbContext(DbContextOptions<MysqlDbContext> options) : base(options)
    {
    }
    public DbSet<UserEntity> UserEntities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MysqlDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}

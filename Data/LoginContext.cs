using LoginAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginAPI.Data;

public class LoginContext : DbContext
{
    public LoginContext(DbContextOptions<LoginContext> options) : base(options) { }
    
    public DbSet<User> Users { get; set; }
    public DbSet<UserCredentials> UserCredentials { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<UserCredentials>()
            .HasKey(uc => uc.UserId);

        modelBuilder.Entity<UserCredentials>()
            .HasOne(uc => uc.User)
            .WithOne(u => u.Credentials)
            .HasForeignKey<UserCredentials>(uc => uc.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        base.OnModelCreating(modelBuilder);
    }
}

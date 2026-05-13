using Microsoft.EntityFrameworkCore;
using Domain.Entities;


using Domain.Enums;
using Domain.Common;

namespace Infrastructure.Data
{
    public class BookNestDbContext : DbContext
    {
        public BookNestDbContext(DbContextOptions<BookNestDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<SwapRequest> SwapRequests { get; set; }
        public DbSet<BookListing> BookListing { get; set; }


        public override int SaveChanges()
        {
            AddOrUpdateTimeStamps();
            return base.SaveChanges();
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            AddOrUpdateTimeStamps();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            AddOrUpdateTimeStamps();
            return base.SaveChangesAsync(cancellationToken);
        }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            AddOrUpdateTimeStamps();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void AddOrUpdateTimeStamps()
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedAt = DateTime.UtcNow;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedAt = DateTime.UtcNow;
                }
            }
        }
    }
}

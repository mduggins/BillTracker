using Microsoft.EntityFrameworkCore;
using BillTracker.Models;

namespace BillTracker.Data {
    public class BillDbContext : DbContext {
        public BillDbContext(DbContextOptions<BillDbContext> options) : base(options) {}
        public DbSet<Bill> Bills { get; set; }
    }
}
using System;
using Microsoft.EntityFrameworkCore;
using BillTracker.Models;

namespace BillTracker.Data {
    public class BillDbContext : DbContext {
        public DbSet<Bill> Bills { get; set; }
    }
}
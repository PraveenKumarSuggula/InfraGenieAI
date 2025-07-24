using Microsoft.EntityFrameworkCore;
using CicdGeneratorService.Models;
using System.Collections.Generic;

namespace CicdGeneratorService.Data
{
    public class PromptDbContext : DbContext
    {
        public PromptDbContext(DbContextOptions<PromptDbContext> options) : base(options) { }

        public DbSet<CiCdPromptEntry> PromptHistories { get; set; }
    }
}

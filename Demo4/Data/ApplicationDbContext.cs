using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Demo4.Data;

namespace Demo4.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Demo4.Data.Application> Application { get; set; } = default!;
        public DbSet<Demo4.Data.TypeEquipment> TypeEquipment { get; set; } = default!;
        public DbSet<Demo4.Data.TypeProblem> TypeProbles { get; set; } = default!;
    }
}

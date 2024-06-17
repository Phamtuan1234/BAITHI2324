using Microsoft.EntityFrameworkCore;
using PMT_BAITHI2324;

namespace PMT_BAITHI2324.Data{
    public class ApplicationDbContext : DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

        public DbSet<Lophoc>Lophoc {get;set;}
        public DbSet<PMT_BAITHI2324.Sinhvien> Sinhvien { get; set; } = default!;
    }
}
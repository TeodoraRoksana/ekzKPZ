using Microsoft.EntityFrameworkCore;

namespace web_api.Model
{
    public class DentalContext : DbContext
    {
        public DentalContext(DbContextOptions options) : base(options) { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<HistoryEntity> History { get; set; }
    }
}

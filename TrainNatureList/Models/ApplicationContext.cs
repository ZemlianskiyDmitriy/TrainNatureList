using Microsoft.EntityFrameworkCore;

namespace TrainNatureList.Models
{
    public class ApplicationContext:DbContext
    {
        public DbSet<Car> Cars => Set<Car>();
        public DbSet<Freight> Freights => Set<Freight>();
        public DbSet<Operation> LastOperations => Set<Operation>();
        public DbSet<OperationDirectory> Operations => Set<OperationDirectory>();
        public DbSet<Station> Stations => Set<Station>();
        public DbSet<Train> Trains => Set<Train>();
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
           : base(options)
        {
            Database.EnsureCreated();   
        }
    }
}

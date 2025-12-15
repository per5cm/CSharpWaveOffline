using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using VPets.Data;

namespace VPets.Data
{
    public class VPetsContextFactory : IDesignTimeDbContextFactory<VPetsContext>
    {
        public VPetsContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<VPetsContext>();

            // Design-time connection string (can be same as runtime)
            optionsBuilder.UseSqlite("Data Source=vPets.db");

            return new VPetsContext(optionsBuilder.Options);
        }
    }
}

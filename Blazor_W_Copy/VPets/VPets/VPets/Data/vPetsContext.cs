using Microsoft.EntityFrameworkCore;
using VPets.Models;

namespace VPets.Data
{
    // Der DbContext ist die Verbindung zwischen C#-Klassen und der Datenbank.
    public class VPetsContext : DbContext
    {
        public VPetsContext(DbContextOptions<VPetsContext> options)
            : base(options)
        { }

        public DbSet<Pet> Pets { get; set; }
    }
}

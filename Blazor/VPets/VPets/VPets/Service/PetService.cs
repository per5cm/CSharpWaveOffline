using Microsoft.EntityFrameworkCore;
using VPets.Data;
using VPets.Models;

namespace VPets.Services
{
    public class PetService
    {
        private readonly VPetsContext _db;

        public PetService(VPetsContext db)
        {
            _db = db;
        }

        public async Task<List<Pet>> GetPetsAsync()
        {
            return await _db.Pets.ToListAsync();
        }

        public async Task<Pet?> GetPetAsync(int id)
        {
            return await _db.Pets.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task AddPetAsync(Pet pet)
        {
            _db.Pets.Add(pet);
            await _db.SaveChangesAsync();
        }

        public async Task UpdatePetAsync(Pet pet)
        {
            _db.Pets.Update(pet);
            await _db.SaveChangesAsync();
        }

        public async Task DeletePetAsync(int id)
        {
            var found = await _db.Pets.FirstOrDefaultAsync(p => p.Id == id);
            if (found != null)
            {
                _db.Pets.Remove(found);
                await _db.SaveChangesAsync();
            }
        }
    }
}


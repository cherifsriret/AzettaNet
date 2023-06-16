using AzettaNet.Models;
using Microsoft.EntityFrameworkCore;

namespace AzettaNet.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private readonly DataContext _context;
        public SuperHeroService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<SuperHero>> GetAllHeroes()
        {
            var heroes = await _context.SuperHeroes.ToListAsync();
            return heroes;
        }

        public async Task<SuperHero?> GetSingleHero(int id)
        {
            var hero = await _context.SuperHeroes.FindAsync(id);
            if (hero == null)
                return null;
            return hero;
        }

        public async Task<List<SuperHero>> AddHero(SuperHero hero)
        {

            await _context.SuperHeroes.AddAsync(hero);
            await _context.SaveChangesAsync();
            var heroes = await _context.SuperHeroes.ToListAsync();
            return heroes;
        }

        public async Task<List<SuperHero>?> DeleteHero(int id)
        {
            var hero = await _context.SuperHeroes.FindAsync(id);
            if (hero == null)
                return null;

            _context.SuperHeroes.Remove(hero);
            await _context.SaveChangesAsync();
            var heroes = await _context.SuperHeroes.ToListAsync();
            return heroes;
        }

     

      

        public async Task<List<SuperHero>?> UpdateHero(int id, SuperHero super_hero)
        {
            var hero = await _context.SuperHeroes.FindAsync(id);
            if (hero == null)
                return null;
            hero.FirstName = super_hero.FirstName;
            hero.LastName = super_hero.LastName;
            hero.Name = super_hero.Name;
            hero.Place = super_hero.Place;

            await _context.SaveChangesAsync();
            var heroes = await _context.SuperHeroes.ToListAsync();
            return heroes;

        }
    }
}

using AzettaNet.Models;

namespace AzettaNet.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        Task<List<SuperHero >> GetAllHeroes();
        Task<SuperHero?> GetSingleHero(int i);
        Task<List<SuperHero>> AddHero(SuperHero hero);
        Task<List<SuperHero>?> UpdateHero(int i ,SuperHero hero);
        Task<List<SuperHero>?> DeleteHero(int i);
    }
}

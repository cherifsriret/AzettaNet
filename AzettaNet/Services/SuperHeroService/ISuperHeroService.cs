using AzettaNet.Models;

namespace AzettaNet.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        List<SuperHero > GetAllHeroes();
        SuperHero? GetSingleHero(int i);
        List<SuperHero> AddHero(SuperHero hero);
        List<SuperHero>? UpdateHero(int i ,SuperHero hero);
        List<SuperHero>? DeleteHero(int i);
    }
}

using AzettaNet.Models;

namespace AzettaNet.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
       

        private List<SuperHero> superHeroes = new List<SuperHero>
            {
                new SuperHero
                {
                   Id = 1,
                   FirstName = "Peter",
                   LastName = "Parker",
                   Name = "Spider Man",
                   Place = "New York City"
                },
                 new SuperHero
                {
                   Id = 2,
                   FirstName = "Tony",
                   LastName = "Stark",
                   Name = "Iron Man",
                   Place = "Malibu"
                }
            };

        public List<SuperHero> AddHero(SuperHero hero)
        {
            superHeroes.Add(hero);
            return superHeroes;
        }

        public List<SuperHero>? DeleteHero(int i)
        {
            var hero = superHeroes.Find(x => x.Id == i);
            if (hero == null)
                return null;
            superHeroes.Remove(hero);
            return superHeroes;
        }

        public List<SuperHero> GetAllHeroes()
        {
           return superHeroes;
        }

        public SuperHero? GetSingleHero(int i)
        {
            var hero = superHeroes.Find(x => x.Id == i);
            if (hero == null)
                return null;
            return hero;
        }

        public List<SuperHero>? UpdateHero(int i, SuperHero super_hero)
        {
            var hero = superHeroes.Find(x => x.Id == i);
            if (hero == null)
                return null;
            hero.FirstName = super_hero.FirstName;
            hero.LastName = super_hero.LastName;
            hero.Name = super_hero.Name;
            hero.Place = super_hero.Place;
            return superHeroes;

        }
    }
}

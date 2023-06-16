using AzettaNet.Models;
using AzettaNet.Services.SuperHeroService;
using Microsoft.AspNetCore.Http;

namespace AzettaNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {

        private readonly ISuperHeroService _superHeroService;

        public SuperHeroController(ISuperHeroService superHeroService)
        {
            
            _superHeroService = superHeroService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            return Ok(await _superHeroService.GetAllHeroes());
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetSingleHero(int id)
        {
            var result = await _superHeroService.GetSingleHero(id);
            if(result == null)
                return NotFound("Sorry, But this hero doesn't exist.");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero (SuperHero hero)
        {
            var result = await _superHeroService.AddHero(hero);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<SuperHero>>>  UpdateHero(int id ,SuperHero super_hero)
        {

            var result = await _superHeroService.UpdateHero(id, super_hero);
            if (result == null)
                return NotFound("Sorry, But this hero doesn't exist.");
            return Ok(result);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        {
            var result = await _superHeroService.DeleteHero(id);
            if (result == null)
                return NotFound("Sorry, But this hero doesn't exist.");
            return Ok(result);

        }

    }
}

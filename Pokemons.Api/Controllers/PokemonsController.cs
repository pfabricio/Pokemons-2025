using Microsoft.AspNetCore.Mvc;
using Pokemons.Api.Extension;
using Pokemons.Api.Services;

namespace Pokemons.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonsController : ControllerBase
    {
        private readonly PokeApiService _pokeApiService;
        public PokemonsController(PokeApiService pokeApiService)
        {
            _pokeApiService = pokeApiService;
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetPokemon(string name)
        {
            try
            {
                var pokemon = await _pokeApiService.GetPokemonAsync(name);
                if (pokemon == null)
                {
                    return NotFound($"Pokémon {name} não encontrado.");
                }

                return Ok(pokemon);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Erro ao consumir a API externa. {e.Message}");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetPokemons()
        {
            try
            {
                var pokemon = await _pokeApiService.GetPokemonsAsync();
                if (pokemon == null)
                {
                    return NotFound($"Registros não encontrado.");
                }

                var qnext = pokemon.next.GetQueryString();
                var qprevious = pokemon.previous.GetQueryString();


                var fullUrl = $"{Request.Scheme}://{Request.Host}{Request.Path}/GetPokemonsOffSet";

                pokemon.next = string.IsNullOrEmpty(qnext) ? null : $"{fullUrl}{qnext}";
                pokemon.previous = string.IsNullOrEmpty(qprevious) ? null : $"{fullUrl}{qprevious}";

                return Ok(pokemon);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Erro ao consumir a API externa. {e.Message}");
            }
        }

        [HttpGet("GetPokemonsOffSet")]
        public async Task<IActionResult> GetPokemonsOffSet([FromQuery] int offset, [FromQuery] int limit)
        {
            try
            {
                var pokemon = await _pokeApiService.GetPokemonsAsync(offset, limit);
                if (pokemon == null)
                {
                    return NotFound($"Registros não encontrado.");
                }

                var qnext = pokemon.next.GetQueryString();
                var qprevious = pokemon.previous.GetQueryString();


                var fullUrl = $"{Request.Scheme}://{Request.Host}{Request.Path}/GetPokemonsOffSet";

                pokemon.next = string.IsNullOrEmpty(qnext) ? null : $"{fullUrl}{qnext}";
                pokemon.previous = string.IsNullOrEmpty(qprevious) ? null : $"{fullUrl}{qprevious}";

                return Ok(pokemon);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Erro ao consumir a API externa. {e.Message}");
            }
        }
    }
}

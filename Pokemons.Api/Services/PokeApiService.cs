using Pokemons.Api.Models;
using System.Xml.Linq;

namespace Pokemons.Api.Services;

public class PokeApiService
{
    private readonly HttpClient _httpClient;

    public PokeApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<pokemon?> GetPokemonAsync(string name)
    {
        var url = $"https://pokeapi.co/api/v2/pokemon/{name}";
        return await _httpClient.GetFromJsonAsync<pokemon>(url);
    }

    public async Task<pokemons> GetPokemonsAsync()
    {
        var url = $"https://pokeapi.co/api/v2/pokemon";
        return await _httpClient.GetFromJsonAsync<pokemons>(url);
    }

    public async Task<pokemons> GetPokemonsAsync(int offset, int limit)
    {
        var url = $"https://pokeapi.co/api/v2/pokemon?offset={offset}&limit={limit}";
        return await _httpClient.GetFromJsonAsync<pokemons>(url);
    }
}
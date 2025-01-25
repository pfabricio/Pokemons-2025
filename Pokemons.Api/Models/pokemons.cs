namespace Pokemons.Api.Models;

public class pokemons
{
    public int count { get; set; }
    public string? next { get; set; }
    public string? previous { get; set; }
    public List<Results> results { get; set; }
}
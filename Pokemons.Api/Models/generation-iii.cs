using System.Text.Json.Serialization;

namespace Pokemons.Api.Models;

public class generation_iii
{
    public generation_iii_emerald emerald { get; set; }

    [JsonPropertyName("firered-leafgreen")]
    public generation_iii_firered_leafgreen firered_leafgreen { get; set; }

    [JsonPropertyName("ruby-sapphire")]
    public generation_iii_ruby_sapphire ruby_sapphire { get; set; }
}
using System.Text.Json.Serialization;

namespace Pokemons.Api.Models;

public class generation_v
{
    [JsonPropertyName("black-white")]
    public generation_v_black_white black_white { get; set; }
}
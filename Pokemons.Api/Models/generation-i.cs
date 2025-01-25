using System.Text.Json.Serialization;

namespace Pokemons.Api.Models;

public class generation_i
{
    [JsonPropertyName("red-blue")]
    public generation_i_red_blue red_blue { get; set; }
    public generation_i_yellow yellow { get; set; }
}
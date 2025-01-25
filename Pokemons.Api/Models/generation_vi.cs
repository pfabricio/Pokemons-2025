using System.Text.Json.Serialization;

namespace Pokemons.Api.Models;

public class generation_vi
{
    [JsonPropertyName("omegaruby-alphasapphire")]
    public generation_vi_omegaruby_alphasapphire omegaruby_alphasapphire { get; set; }

    [JsonPropertyName("x-y")]
    public generation_vi_x_y x_y { get; set; }  
}
using System.Text.Json.Serialization;

namespace Pokemons.Api.Models;

public class generation_vii
{
    public sprite_versions_icons icons { get; set; }

    [JsonPropertyName("ultra-sun-ultra-moon")]
    public generation_vii_ultra_sun_ultra_moon ultra_sun_ultra_moon { get; set; }
}
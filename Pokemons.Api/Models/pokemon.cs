namespace Pokemons.Api.Models;

public class pokemon
{
    public int id { get; set; }
    public string name { get; set; }
    public int order { get; set; }
    public bool is_default { get; set; }
    public string location_area_encounters { get; set; }
    public List<abilities> abilities { get; set; }
    public int base_experience { get; set; }
    public cries cries { get; set; }
    public List<forms> forms { get; set; }
    public List<game_indices> game_indices { get; set; }
    public int height { get; set; }
    public int weight { get; set; }
    public List<held_items> held_items { get; set; }
    public List<moves> moves { get; set; }
    public species species { get; set; }
    public List<stats> stats { get; set; }
    public List<types> types { get; set; }
    public List<past_abilities> past_abilities { get; set; }
    public List<past_types> past_types { get; set; }
    public sprites sprites { get; set; }
}
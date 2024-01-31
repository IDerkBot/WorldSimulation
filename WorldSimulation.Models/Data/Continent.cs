namespace WorldSimulation.Models.Data;

public class Continent
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Planet Planet { get; set; }

    public Area Area { get; set; }

    public ICollection<Country> Countries { get; set; }
}
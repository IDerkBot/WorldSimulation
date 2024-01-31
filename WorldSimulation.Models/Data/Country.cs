namespace WorldSimulation.Models.Data;

public class Country
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Continent Continent { get; set; }

    public Area Area { get; set; }

    public ICollection<City> Cities { get; set; }
}
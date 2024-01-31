namespace WorldSimulation.Models.Data;

public class Planet
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<Continent> Continents { get; set; }
}
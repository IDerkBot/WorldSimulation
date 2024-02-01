namespace WorldSimulation.Models.Data;

public class Project
{
    public ICollection<Planet> Planets { get; set; } = new List<Planet>();
}
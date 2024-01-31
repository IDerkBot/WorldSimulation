namespace WorldSimulation.Models.Data;

public class Build
{
    public int Id { get; set; }
    public string Street { get; set; }
    public string Name { get; set; }

    public City City { get; set; }
    public Area Area { get; set; }
}
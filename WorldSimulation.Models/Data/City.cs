namespace WorldSimulation.Models.Data;

public class City
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Country Country { get; set; }
    
    public Area Area { get; set; }
    
}
namespace WorldSimulation.Models.Data;

public class Entity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Specie? Specie { get; set; }
    public DateTime? BirthDay { get; set; }
    public int? Age { get; set; }
    public DateTime? DeathTime { get; set; }
    public Location? ActualLocation { get; set; }
    public Location? PlaceOfBirth { get; set; }
}
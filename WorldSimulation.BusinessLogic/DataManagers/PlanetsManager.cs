using WorldSimulation.Models.Data;

namespace WorldSimulation.BusinessLogic.DataManagers;

public class PlanetsManager
{
    private readonly ICollection<Planet> _planets;

    public PlanetsManager()
    {
        _planets = new List<Planet>();
    }
    
    public Planet? GetById(int id)
    {
        return _planets.FirstOrDefault(planet => planet.Id == id);
    }

    public Planet? GetByName(string name)
    {
        return _planets.FirstOrDefault(planet => planet.Name == name);
    }

    public ICollection<Planet> GetAll()
    {
        return _planets;
    }

    public void Add(Planet planet)
    {
        _planets.Add(planet);
    }

    public void Remove(Planet planet)
    {
        _planets.Remove(planet);
    }
}
using WorldSimulation.BusinessLogic.DataManagers.Interfaces;
using WorldSimulation.Models.Data;

namespace WorldSimulation.BusinessLogic.DataManagers;

public class PlanetsManager : IDataManager<Planet>
{
    private readonly ICollection<Planet> _items = new List<Planet>();

    public Planet? GetById(int id)
    {
        return _items.FirstOrDefault(planet => planet.Id == id);
    }

    public Planet? GetByName(string name)
    {
        return _items.FirstOrDefault(planet => planet.Name == name);
    }

    public ICollection<Planet> GetAll()
    {
        return _items;
    }

    public void Add(Planet planet)
    {
        if (planet.Id == 0)
        {
            planet.Id = _items.Count + 1;
        }
        _items.Add(planet);
    }

    public void Remove(Planet planet)
    {
        _items.Remove(planet);
    }
}
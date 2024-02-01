using WorldSimulation.BusinessLogic.DataManagers.Interfaces;
using WorldSimulation.Models.Data;

namespace WorldSimulation.BusinessLogic.DataManagers;

public class CitiesManager : IDataManager<City>
{
    private readonly ICollection<City> _items = new List<City>();
    public City? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public City? GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public ICollection<City> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Add(City item)
    {
        throw new NotImplementedException();
    }

    public void Remove(City item)
    {
        throw new NotImplementedException();
    }
}
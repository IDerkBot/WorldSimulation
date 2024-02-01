using WorldSimulation.BusinessLogic.DataManagers.Interfaces;
using WorldSimulation.Models.Data;

namespace WorldSimulation.BusinessLogic.DataManagers;

public class CountriesManager : IDataManager<Country>
{
    private readonly ICollection<Country> _items = new List<Country>();
    public Country? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Country? GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public ICollection<Country> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Add(Country item)
    {
        throw new NotImplementedException();
    }

    public void Remove(Country item)
    {
        throw new NotImplementedException();
    }
}
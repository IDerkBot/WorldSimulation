using WorldSimulation.BusinessLogic.DataManagers.Interfaces;
using WorldSimulation.Models.Data;

namespace WorldSimulation.BusinessLogic.DataManagers;

public class SpeciesManager : IDataManager<Specie>
{
    private readonly ICollection<Specie> _items = new List<Specie>();
    public Specie? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Specie? GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public ICollection<Specie> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Add(Specie item)
    {
        throw new NotImplementedException();
    }

    public void Remove(Specie item)
    {
        throw new NotImplementedException();
    }
}
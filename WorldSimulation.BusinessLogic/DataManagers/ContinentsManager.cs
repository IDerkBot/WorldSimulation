using WorldSimulation.BusinessLogic.DataManagers.Interfaces;
using WorldSimulation.Models.Data;

namespace WorldSimulation.BusinessLogic.DataManagers;

public class ContinentsManager : IDataManager<Continent>
{
    private readonly ICollection<Continent> _items = new List<Continent>();
    
    public Continent? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Continent? GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public ICollection<Continent> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Add(Continent item)
    {
        throw new NotImplementedException();
    }

    public void Remove(Continent item)
    {
        throw new NotImplementedException();
    }
}
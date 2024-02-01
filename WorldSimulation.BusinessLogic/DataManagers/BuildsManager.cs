using WorldSimulation.BusinessLogic.DataManagers.Interfaces;
using WorldSimulation.Models.Data;

namespace WorldSimulation.BusinessLogic.DataManagers;

public class BuildsManager : IDataManager<Build>
{
    private readonly ICollection<Build> _items = new List<Build>();

    public Build? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Build? GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public ICollection<Build> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Add(Build item)
    {
        throw new NotImplementedException();
    }

    public void Remove(Build item)
    {
        throw new NotImplementedException();
    }
}
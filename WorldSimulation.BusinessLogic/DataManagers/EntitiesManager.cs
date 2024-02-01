using WorldSimulation.BusinessLogic.DataManagers.Interfaces;
using WorldSimulation.Models.Data;

namespace WorldSimulation.BusinessLogic.DataManagers;

public class EntitiesManager : IDataManager<Entity>
{
    private readonly ICollection<Entity> _items = new List<Entity>();
    public Entity? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Entity? GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public ICollection<Entity> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Add(Entity item)
    {
        throw new NotImplementedException();
    }

    public void Remove(Entity item)
    {
        throw new NotImplementedException();
    }
}
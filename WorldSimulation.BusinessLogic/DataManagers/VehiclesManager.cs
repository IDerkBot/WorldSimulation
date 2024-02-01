using WorldSimulation.BusinessLogic.DataManagers.Interfaces;
using WorldSimulation.Models.Data;

namespace WorldSimulation.BusinessLogic.DataManagers;

public class VehiclesManager : IDataManager<Vehicle>
{
    private readonly ICollection<Vehicle> _items = new List<Vehicle>();
    public Vehicle? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Vehicle? GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public ICollection<Vehicle> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Add(Vehicle item)
    {
        throw new NotImplementedException();
    }

    public void Remove(Vehicle item)
    {
        throw new NotImplementedException();
    }
}
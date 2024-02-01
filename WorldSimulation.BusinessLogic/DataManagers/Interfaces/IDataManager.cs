namespace WorldSimulation.BusinessLogic.DataManagers.Interfaces;

public interface IDataManager<T>
{
    T? GetById(int id);

    T? GetByName(string name);

    ICollection<T> GetAll();

    void Add(T item);

    void Remove(T item);
}
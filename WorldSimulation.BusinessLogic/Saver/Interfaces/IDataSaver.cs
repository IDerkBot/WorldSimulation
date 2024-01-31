namespace WorldSimulation.BusinessLogic.Saver.Interfaces;

public interface IDataSaver
{
    T? Load<T>(string filePath) where T : class;
    void Save<T>(string filePath, T item) where T : class;
}
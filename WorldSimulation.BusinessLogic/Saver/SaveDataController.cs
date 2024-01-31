using WorldSimulation.BusinessLogic.Saver.Interfaces;

namespace WorldSimulation.BusinessLogic.Saver;

public class SaveDataController
{
    private static readonly IDataSaver Manager = new DataSaver();

    protected static void Save<T>(string filePath, T item) where T : class => Manager.Save(filePath, item);
    
    public static T? Load<T>(string filePath) where T : class => Manager.Load<T>(filePath);
}
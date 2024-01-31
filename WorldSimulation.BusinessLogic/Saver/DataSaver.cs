using System.Xml.Serialization;
using WorldSimulation.BusinessLogic.Saver.Interfaces;

namespace WorldSimulation.BusinessLogic.Saver;

public class DataSaver : IDataSaver
{
    public T? Load<T>(string filePath) where T : class
    {
        if (string.IsNullOrWhiteSpace(filePath))
        {
            throw new ArgumentNullException(nameof(filePath), "Путь до файла не может быть пустым!");
        }

        var formatter = new XmlSerializer(typeof(T));

        using var fs = new FileStream(filePath, FileMode.OpenOrCreate);

        if (fs.Length > 0 && formatter.Deserialize(fs) is T item)
            return item;

        return null;
    }

    public void Save<T>(string filePath, T item) where T : class
    {
        if (string.IsNullOrWhiteSpace(filePath))
        {
            throw new ArgumentNullException(nameof(filePath), "Путь до файла не может быть пустым!");
        }

        if (item == null)
        {
            throw new ArgumentNullException(nameof(item), "Данные для сохранения не могут быть NULL!");
        }

        var formatter = new XmlSerializer(typeof(T));

        using var fs = new FileStream(filePath, FileMode.OpenOrCreate);

        formatter.Serialize(fs, item);
    }
}
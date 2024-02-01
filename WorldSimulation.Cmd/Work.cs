using System.Threading.Channels;
using WorldSimulation.BusinessLogic.DataManagers;
using WorldSimulation.Models.Data;

namespace WorldSimulation.Cmd;

public class Work
{
    private GeneralManager _generalManager;

    public Work()
    {
        _generalManager = new GeneralManager();
    }

    public void Run()
    {
        Console.WriteLine("Добро пожаловать в редактор лора!");

        ShowMainMenu();
    }

    private void ShowMainMenu()
    {
        Console.WriteLine("MAIN MENU");
        Console.WriteLine("1. Planets");
        Console.WriteLine("2. Species");
        Console.WriteLine("3. Other");

        var text = Console.ReadLine();

        if (text == "1")
        {
            // Отображение планет
            ShowPlanets();
        }
        else if (text == "2")
        {
            // Отображение рас
        }
        else if (text == "3")
        {
            // Другое
        }
    }

    private void ShowPlanets()
    {
        Console.Clear();
        
        Console.WriteLine("Planets");
        Console.WriteLine("0. Back");
        Console.WriteLine("1. Add");
        var planets = _generalManager.PlanetsManager.GetAll();
        for (int i = 0; i < planets.Count; i++)
        {
            var planet = planets.ToList()[i];
            Console.WriteLine($"{i+2}. {planet.Name}");
        }

        var select = Console.ReadLine();

        if (select == "0") ShowMainMenu();
        else if (select == "1") AddPlanet();
        else if (int.TryParse(select, out var id))
        {
            var planet = _generalManager.PlanetsManager.GetById(id - 1);
            if (planet == null)
            {
                Console.WriteLine("Такой планеты не существует");
            }
            else
                GetPlanetData(planet);
        }
    }

    private void AddPlanet()
    {
        Console.Write("Введите имя планеты: ");
        var name = Console.ReadLine();

        var planet = new Planet
        {
            Name = name
        };
        
        _generalManager.PlanetsManager.Add(planet);
        _generalManager.SaveData();
        Console.WriteLine("Планета добавлена");
        
        ShowPlanets();
    }

    private void GetPlanetData(Planet planet)
    {
        Console.Clear();
        
        Console.WriteLine("=== Планета ===");
        Console.WriteLine($"Название: {planet.Name}");

        Console.WriteLine();
        Console.WriteLine("=== Материки ===");

        var continents = planet.Continents.ToList();
        
        Console.WriteLine("0. Back");
        Console.WriteLine("1. Add");
        
        for (int i = 0; i < planet.Continents.Count; i++)
        {
            Console.WriteLine($"{i+2}. {continents[i].Name}");    
        }
    }
}
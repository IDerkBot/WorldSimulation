using WorldSimulation.BusinessLogic.Saver;

namespace WorldSimulation.BusinessLogic.DataManagers;

public class GeneralManager : SaveDataController
{
    #region Properties

    public BuildsManager BuildsManager { get; } = new();

    public CitiesManager CitiesManager { get; } = new();

    public ContinentsManager ContinentsManager { get; } = new();

    public CountriesManager CountriesManager { get; } = new();

    public EntitiesManager EntitiesManager { get; } = new();

    public PlanetsManager PlanetsManager { get; } = new();

    public SpeciesManager SpeciesManager { get; } = new();

    public VehiclesManager VehiclesManager { get; } = new();

    #endregion Properties
    
    public GeneralManager()
    {
        
    }

    public void SaveData()
    {
        
    }
}
namespace WorldSimulation.BusinessLogic.DataManagers;

public class GeneralManager
{
    private readonly BuildsManager _buildsManager = new();
    private readonly CitiesManager _citiesManager = new();
    private readonly ContinentsManager _continentsManager = new();
    private readonly CountriesManager _countriesManager = new();
    private readonly EntitiesManager _entitiesManager = new();
    private readonly PlanetsManager _planetsManager = new();
    private readonly SpeciesManager _speciesManager = new();
    private readonly VehiclesManager _vehiclesManager = new();

    public GeneralManager()
    {
        
    }

    public BuildsManager GetBuildsManager() => _buildsManager;
    public CitiesManager GetCitiesManager() => _citiesManager;
    public ContinentsManager GetContinentsManager() => _continentsManager;
    public CountriesManager GetCountriesManager() => _countriesManager;
    public EntitiesManager GetEntitiesManager() => _entitiesManager;
    public PlanetsManager GetPlanetsManager() => _planetsManager;
    public SpeciesManager GetSpeciesManager() => _speciesManager;
    public VehiclesManager GetVehiclesManager() => _vehiclesManager;
}
using MotoApp.Components.CsvReader;

namespace MotoApp;

public class App : IApp
{
    private readonly ICsvReader _csvReader;

    public App(ICsvReader csvReader)
    {
        _csvReader = csvReader;
    }
    
    public void Run()
    {
        var cars = _csvReader.ProcessCars("Resources\\Files\\fuel.csv");
    }
}

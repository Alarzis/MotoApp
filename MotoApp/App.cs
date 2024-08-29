using MotoApp.Repositories;
using MotoApp.Entities;

namespace MotoApp;

public class App : IApp
{
    private readonly IRepository<Employee> _employeesRepository;

    public App(IRepository<Employee> employeesRepository)
    {
        _employeesRepository = employeesRepository;
    }


    public void Run()
    {
        Console.WriteLine("I'm here in Run() method");

        //adding
        var employees = new[]
        {
            new Employee { FirstName = "Andrzej" },
            new Employee { FirstName = "Monika" },
            new Employee { FirstName = "Ewa" }
        };

        foreach (var employee in employees)
        {
            _employeesRepository.Add(employee);
        }

        _employeesRepository.Save();

        //reading
        var items = _employeesRepository.GetAll();
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}

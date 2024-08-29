using Microsoft.Extensions.DependencyInjection;
using MotoApp;
using MotoApp.Entities;
using MotoApp.Repositories;

var services = new ServiceCollection();
services.AddSingleton<IApp, App>();
services.AddSingleton<IRepository<Employee>, ListRepository<Employee>>();

var serviceProvider = services.BuildServiceProvider();
var app = serviceProvider.GetService<IApp>()!;
app.Run();

//using MotoApp.Entities;
//using MotoApp.Repositories;
//using MotoApp.Data;
//using MotoApp.Repositories.Extensions;

//var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext(), EmployeeAdded);
//employeeRepository.ItemAdded += EmployeeRepositoryOnItemAdded;

//static void EmployeeRepositoryOnItemAdded(object? sender, Employee e)
//{
//    Console.WriteLine($"Employee added => {e.FirstName} from {sender?.GetType().Name}");
//}

//AddEmployees(employeeRepository);
//WriteAllToConsole(employeeRepository);

//static void EmployeeAdded(Employee item)
//{
//    Console.WriteLine($"{item.FirstName} added");
//}

//static void AddEmployees(IRepository<Employee> repository)
//{
//    var employees = new[]
//    {
//        new Employee { FirstName = "Andrzej" },
//        new Employee { FirstName = "Monika" },
//        new Employee { FirstName = "Ewa" }
//    };

//    repository.AddBatch(employees);
//    "string".AddBatch(employees);
//    AddBatch(employeeRepository, employees);

//    employeeRepository.Add(new Employee { FirstName = "Andrzej" });
//    employeeRepository.Add(new Employee { FirstName = "Monika" });
//    employeeRepository.Add(new Employee { FirstName = "Ewa" });
//    employeeRepository.Save();
//}

//static void AddBatch<T>(IRepository<T> repository, T[] items)
//    where T : class, IEntity
//{
//    foreach (var item in items)
//    {
//        repository.Add(item);
//    }

//    repository.Save();
//}

//static void WriteAllToConsole(IReadRepository<IEntity> repository)
//{
//    var items = repository.GetAll();
//    foreach (var item in items)
//    {
//        Console.WriteLine(item);
//    }
//}
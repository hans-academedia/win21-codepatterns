using _02_LSP.Employees;
using _02_LSP.Interfaces;
using System.ComponentModel;

BaseEmployee ceo = new CEO { FirstName = "Hans", LastName = "Mattin-Lassei", HourlySalary = 360 };
Employee teamleader = new TeamLeader { FirstName = "Tommy", LastName = "Mattin-Lassei", HourlySalary = 250, Manager = ceo };
Employee consultant = new Consultant { FirstName = "Joakim", LastName = "Wahlström", HourlySalary = 240, Manager = teamleader };

var list = new List<IEmployee>();
list.Add(ceo);
list.Add(teamleader);
list.Add(consultant);

ceo.GetMonthlySalary();
ceo.GetYearlySalary();
Console.WriteLine("");

consultant.GetMonthlySalary();
consultant.GetYearlySalary();
consultant.ShowManager();
Console.WriteLine("");

Console.ReadKey();
using _01_LSP.Employees;

var ceo = new CEO { FirstName = "Hans", LastName = "Mattin-Lassei" };
var teamleader = new Teamleader { FirstName = "Tommy", LastName = "Mattin-Lassei" };
var employee = new Employee { FirstName = "Joakim", LastName = "Wahlström" };


ceo.ReviewEmployee(employee);
ceo.GetMonthlySalary();
ceo.GetYearlySalary();

teamleader.ReviewEmployee(employee);
teamleader.AssignManager(ceo);
teamleader.GetMonthlySalary();
teamleader.GetYearlySalary();


employee.AssignManager(teamleader);
employee.GetMonthlySalary();
employee.GetYearlySalary();


Console.ReadKey();
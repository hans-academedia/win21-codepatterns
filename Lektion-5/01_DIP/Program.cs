using _01_DIP;
using _01_DIP.Interfaces;

IProjectOwner owner = Factory.ProjectOwner("Hans", "Mattin-Lassei", "hans@domain.com", "073-986 89 50");
IConsultant consultant = Factory.Consultant("Joakim", "Wahlström", "joakim@domain.com", "070-452 67 87");

IProject project = Factory.Project("The Amazing Project", owner, consultant);
project.RegisterHours(1);
project.RegisterHours(2);
project.RegisterHours(1);
project.MarkAsCompleted();

Console.ReadKey();
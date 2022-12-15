namespace _01_DIP.Interfaces
{
    internal interface IProject
    {
        IPerson Consultant { get; set; }
        bool IsCompleted { get; }
        IPerson Owner { get; set; }
        string ProjectName { get; set; }
        Guid ProjectNumber { get; set; }
        double SpentHours { get; }

        void MarkAsCompleted();
        void RegisterHours(double hours);
    }
}
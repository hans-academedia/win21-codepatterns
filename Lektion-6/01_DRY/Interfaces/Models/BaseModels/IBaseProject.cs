namespace _01_DRY.Interfaces.Models.BaseModels;

internal interface IBaseProject
{
    string ProjectName { get; set; }
    Guid ProjectNumber { get; set; }
    IBasePerson ProjectOwner { get; set; }
}
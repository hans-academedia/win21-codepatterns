using _01_DRY.Interfaces.Models.BaseModels;

namespace _01_DRY.Models.BaseModels;

internal abstract class BaseProject : IBaseProject
{
    public Guid ProjectNumber { get; set; } = Guid.NewGuid();
    public string ProjectName { get; set; } = null!;
    public IBasePerson ProjectOwner { get; set; } = null!;
}

using _01_DRY.Interfaces.Models.BaseModels;
using _01_DRY.Models;

namespace _01_DRY.Factories;

internal static class ProjectFactory
{
    public static Project Create(string projectName, IBasePerson owner)
    {
        return new Project()
        {
            ProjectName = projectName,
            ProjectOwner = owner
        };
    }
}

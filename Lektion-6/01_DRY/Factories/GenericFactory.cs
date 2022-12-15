namespace _01_DRY.Factories;

internal static class GenericFactory
{
    public static T Create<T>() where T : class, new()
    {
        return new T();
    }
}

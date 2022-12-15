namespace _02_gRPC_Server.Models;

public interface IProductModel
{
    string Description { get; set; }
    int Id { get; set; }
    string Name { get; set; }
    double Price { get; set; }
}
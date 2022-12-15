namespace _03_ISP.Interfaces
{
    public interface IHandBag : IProductItem
    {
        bool IsWaterProof { get; set; }
        bool HasZipper { get; set; }
    }
}

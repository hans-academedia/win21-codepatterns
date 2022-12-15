namespace _03_ISP.Interfaces
{
    public interface IWatch : IProductItem
    {
        public bool IsDigital { get; set; }
        public bool WatherProof { get; set; }
    }
}

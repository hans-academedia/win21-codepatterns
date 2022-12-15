namespace _03_ISP.Models.Entities
{
    public class CategoryEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public ICollection<ProductEntity> Products { get; set; }
    }
}

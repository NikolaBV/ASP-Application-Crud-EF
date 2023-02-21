namespace Borsa_Nikola12a.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType? ProductTypes { get; set; }
        public DateTime DateCreated { get; set; }
        ICollection<Order>? Orders { get; set; }
    }
}

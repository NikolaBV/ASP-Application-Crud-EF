namespace Borsa_Nikola12a.Data
{
    public class ProductType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? RegisteredOn { get; set; }
        ICollection<Product>? Products { get; set; }
    }
}

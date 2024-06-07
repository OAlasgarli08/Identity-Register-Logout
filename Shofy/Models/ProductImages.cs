namespace Shofy.Models
{
    public class ProductImages : BaseEntity
    {
        public string Name { get; set; }
        public bool isMain { get; set; } = false;
        public Product Product { get; set; }
    }
}

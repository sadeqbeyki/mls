using Framework.Core;

namespace MLS.Core.Entities
{
    public class ProductCategory : EntityBase
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Product>? Products { get; set; }

        public ProductCategory()
        {
            Products = new List<Product>();
        }

        public ProductCategory(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}

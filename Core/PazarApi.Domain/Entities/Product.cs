
using PazarApi.Domain.Common;

namespace PazarApi.Domain.Entities
{
    public class Product:EntityBase
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required int BrandId { get; set; }
        public Brand Brand { get; set; }
        public required decimal Discount { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}

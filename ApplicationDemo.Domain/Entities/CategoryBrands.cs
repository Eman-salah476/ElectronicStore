using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationDemo.Domain.Entities
{
    public class CategoryBrands
    {
        public Guid Id { get; set; }
        public Guid CatgoryId { get; set; }
        public Guid BrandId { get; set; }

        public Category Category { get; set; }
        public Brand Brand { get; set; }
    }
}

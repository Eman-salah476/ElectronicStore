using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationDemo.Domain.Entities
{
    public class CategoryBrands
    {
        public Guid Id { get; set; }
        [ForeignKey("Category")]
        public Guid CatgoryId { get; set; }
        [ForeignKey("Brand")]
        public Guid BrandId { get; set; }

        public Category Category { get; set; }
        public Brand Brand { get; set; }
    }
}

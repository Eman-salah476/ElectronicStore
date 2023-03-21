using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationDemo.Domain.Entities
{
    public class CategoryProps
    {
        public Guid Id { get; set; }
        [ForeignKey("Category")]
        public Guid CatgoryId { get; set; }
        [ForeignKey("Property")]
        public Guid PropertyId { get; set; }

        public Category Category { get; set; }
        public Property Property { get; set; }
    }
}

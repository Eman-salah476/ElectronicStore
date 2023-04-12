using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationDemo.Domain.Entities
{
    public class CategoryProps
    {
        public Guid Id { get; set; }
        public Guid CatgoryId { get; set; }
        public Guid PropertyId { get; set; }

        public Category Category { get; set; }
        public Property Property { get; set; }
    }
}

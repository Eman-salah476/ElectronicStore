using ApplicationDemo.Domain.Entities;
using ApplicationDemo.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApplicationDemo.Infrastructure.DataSeeder
{
    public class CategorySeeder : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            try
            {
                var categories = new List<Category>();
                foreach (int catgoryIndex in Enum.GetValues(typeof(DeviceCategory)))
                {
                    var category = new Category
                    {
                        Id = Guid.NewGuid(),
                        Name = Enum.GetName(typeof(DeviceCategory), catgoryIndex)
                    };
                    categories.Add(category);   
                }
                builder.HasData(categories);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}

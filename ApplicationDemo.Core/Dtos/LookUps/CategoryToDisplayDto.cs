namespace ApplicationDemo.Core.Dtos.LookUp
{
    public class CategoryToDisplayDto : LookUpDto
    {
        public List<CategoryBrandsDto> CategoryBrands { get; set; }
        public List<CategoryPropsDto> CategoryProps { get; set; }
    }

    public class CategoryBrandsDto
    {
        public Guid BrandId { get; set; }
        public string BrandName { get; set; }
    }

    public class CategoryPropsDto
    {
        public Guid PropertyId { get; set; }
        public string PropertyName { get; set; }
    }
}

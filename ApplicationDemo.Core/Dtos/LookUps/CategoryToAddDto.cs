using ApplicationDemo.Core.Dtos.LookUp;

namespace ApplicationDemo.Core.Dtos.LookUps
{
    public class CategoryToAddDto : LookUpDto
    {
        public List<int> CategoryProps { get; set; }
        public List<int> CategoryBrands { get; set; }

    }   
}

using ApplicationDemo.Application.Dtos.LookUp;

namespace ApplicationDemo.Application.Dtos.LookUps
{
    public class CategoryToAddDto 
    {
        public string Name { get; set; }
        public List<int> CategoryProps { get; set; }
        public List<int> CategoryBrands { get; set; }

    }   
}

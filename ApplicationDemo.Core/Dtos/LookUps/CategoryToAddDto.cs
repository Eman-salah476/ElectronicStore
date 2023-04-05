using ApplicationDemo.Core.Dtos.LookUp;

namespace ApplicationDemo.Core.Dtos.LookUps
{
    public class CategoryToAddDto 
    {
        public string Name { get; set; }
        public List<int> CategoryProps { get; set; }
        public List<int> CategoryBrands { get; set; }

    }   
}

using ApplicationDemo.Core.Dtos.LookUp;

namespace ApplicationDemo.Core.Services.Interfaces
{
    public interface ILookUpService<T> where T : class
    {
        List<LookUpDto> GetLookUps();
        bool AddLookUp(LookUpToAdd lookUpToAdd);
    }
}

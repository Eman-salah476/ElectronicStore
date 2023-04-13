using ApplicationDemo.Core.Dtos.LookUp;

namespace ApplicationDemo.Core.Services.Interfaces
{
    public interface ILookUpService
    {
        List<LookUpDto> GetLookUps();
        bool AddLookUp(LookUpToAdd lookUpToAdd);
    }
}

using ApplicationDemo.Core.Dtos.LookUp;

namespace ApplicationDemo.Core.Services.LookUpService
{
    public interface ILookUpService
    {
        List<LookUpDto> GetLookUps();
        bool AddLookUp(LookUpToAdd lookUpToAdd);
    }
}

using ApplicationDemo.Application.Dtos.LookUp;

namespace ApplicationDemo.Application.Services.Interfaces
{
    public interface ILookUpService
    {
        List<LookUpDto> GetLookUps();
        bool AddLookUp(LookUpToAdd lookUpToAdd);
    }
}

using ProjectTemplate.Domain.DTO.Address;
using System.Threading.Tasks;

namespace ProjectTemplate.BL.FindCep
{
    public interface IFindCepBO
    {
        Task<AddressZipCodeDTO> Find(string zipcode);
    }
}

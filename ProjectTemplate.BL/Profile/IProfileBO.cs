using ProjectTemplate.BL.Excel;
using ProjectTemplate.Domain.DTO;
using ProjectTemplate.Domain.DTO.Profile;
using ProjectTemplate.Domain.Helpers;
using System.Threading.Tasks;

namespace ProjectTemplate.BL.Profile
{
    public interface IProfileBO
    {
        Task<GridViewData<ProfileListDTO>> GetAll(ProfileFilterDTO filter);
        Task<bool> SaveUpdate(ProfileDTO model);
        Task<BaseResponseDTO> DeleteProfile(long id);
        Task<BaseResponseDTO> ActivateDisable(ActivateDisableDeleteDTO model);
        Task<ProfileDTO> GetById(long id);
        Task<FileDownloadDTO> Export2Excel(ProfileFilterDTO filter);
    }
}

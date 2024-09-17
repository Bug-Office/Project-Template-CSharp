using ProjectTemplate.BL.Excel;
using ProjectTemplate.Domain.DTO;
using ProjectTemplate.Domain.DTO.EntityName;
using ProjectTemplate.Domain.Helpers;

namespace ProjectTemplate.BL
{
    public interface IEntityNameBO
    {
        Task<GridViewData<EntityNameListDTO>> GetAll(EntityNameFilterDTO filter);
        Task<bool> SaveUpdate(EntityNameDTO entityName);
        Task<bool> Delete(long entityNameId);
        Task<bool> ActivateDisable(ActivateDisableDeleteDTO model);
        Task<EntityNameDTO> GetById(long id);
        Task<FileDownloadDTO> Export2Excel(EntityNameFilterDTO filter);
    }
}

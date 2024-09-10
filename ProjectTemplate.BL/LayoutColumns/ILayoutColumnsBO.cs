using ProjectTemplate.Domain.DTO.LayoutLot;
using ProjectTemplate.Domain.Helpers;

namespace ProjectTemplate.BL.LayoutLot
{
    public interface ILayoutColumnsBO
    {
        Task<GridViewData<ListLayoutColumnsDTO>> GetAll(long userId, string table);
        Task<long> SaveUpdate(CreateLayoutDTO dto);
        Task<bool> DeleteLayout(long id);
    }
}

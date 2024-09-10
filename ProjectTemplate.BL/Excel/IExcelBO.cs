using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectTemplate.BL.Excel
{
    public interface IExcelBO
    {
        Task<FileDownloadDTO> ExportExcel<T>(List<T> result, string fileName = "ExportExcel.xlsx");
    }
}

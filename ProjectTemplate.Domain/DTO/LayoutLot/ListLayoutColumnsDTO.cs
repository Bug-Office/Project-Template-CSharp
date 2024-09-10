using System.Collections.Generic;

namespace ProjectTemplate.Domain.DTO.LayoutLot
{
    public class ListLayoutColumnsDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<string> Columns { get; set; }
    }
}

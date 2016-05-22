using System.Collections.Generic;
namespace Entities
{
    public class DepartmentBookDTO
    {
        public int dept_id { get; set; }
        public int book_id { get; set; }
        public string dept_name { get; set; }
        public string book_name { get; set; }
    }
    public class DepartmentDTO
    {
        public int dept_id { get; set; }
        public string dept_name { get; set; }
        public List<SimpleDTO> dtos { get; set; }
    }
    public class SimpleDTO
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
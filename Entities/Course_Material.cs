namespace Entities
{
    using System.ComponentModel.DataAnnotations;

    public partial class Course_Material
    {
        [Key]
        public int mat_id { get; set; }

        public int course_id { get; set; }

        public int file_id { get; set; }

        public int uploadBy { get; set; }

        public int? type { get; set; }
    }
}

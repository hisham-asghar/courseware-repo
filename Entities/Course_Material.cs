namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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

namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Courses")]
    public partial class Cours
    {
        [Key]
        public int course_id { get; set; }

        [Required]
        [StringLength(200)]
        public string course_name { get; set; }

        public int file_id { get; set; }

        public int dept_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string description { get; set; }
    }
}

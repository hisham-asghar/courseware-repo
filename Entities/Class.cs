namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Class
    {
        [Key]
        public int class_id { get; set; }

        public int course_id { get; set; }

        [Required]
        public string description { get; set; }

        [Required]
        public string courseOutline { get; set; }

        [Required]
        [StringLength(50)]
        public string image_path { get; set; }
    }
}

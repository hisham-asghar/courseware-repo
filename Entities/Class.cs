namespace Entities
{
    using System.ComponentModel.DataAnnotations;

    public partial class Class
    {
        [Key]
        public int class_id { get; set; }

        public int course_id { get; set; }

        [Required]
        [StringLength(5000)]
        public string description { get; set; }

        [Required]
        [StringLength(5000)]
        public string courseOutline { get; set; }

        [Required]
        [StringLength(50)]
        public string image_path { get; set; }
    }
}

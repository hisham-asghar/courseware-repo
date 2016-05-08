namespace Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Courses")]
    public partial class Cours
    {
        [Key]
        public int course_id { get; set; }

        [Required]
        [StringLength(50)]
        public string course_name { get; set; }

        public int credits { get; set; }

        [Required]
        [StringLength(200)]
        public string description { get; set; }
    }
}

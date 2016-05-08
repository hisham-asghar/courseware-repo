namespace Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class File
    {
        [Key]
        public int file_id { get; set; }

        [Required]
        [StringLength(50)]
        public string file_path { get; set; }

        public DateTime uploadTime { get; set; }
    }
}

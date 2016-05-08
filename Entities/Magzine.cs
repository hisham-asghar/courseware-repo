namespace Entities
{
    using System.ComponentModel.DataAnnotations;

    public partial class Magzine
    {
        [Key]
        public int mag_id { get; set; }

        public int mag_file_id { get; set; }

        public int mag_img_id { get; set; }

        [Required]
        [StringLength(50)]
        public string mag_name { get; set; }

        public int mag_cat_id { get; set; }
    }
}

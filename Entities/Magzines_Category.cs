namespace Entities
{
    using System.ComponentModel.DataAnnotations;

    public partial class Magzines_Category
    {
        [Key]
        public int mag_cat_id { get; set; }

        [Required]
        [StringLength(50)]
        public string mag_cat_name { get; set; }
    }
}

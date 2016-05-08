namespace Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Category")]
    public partial class Category
    {
        [Key]
        public int cat_id { get; set; }

        [Required]
        [StringLength(100)]
        public string cat_name { get; set; }
    }
}

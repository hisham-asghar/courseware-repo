namespace Entities
{
    using System.ComponentModel.DataAnnotations;

    public partial class Book
    {
        [Key]
        public int book_id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        public int author_id { get; set; }

        public int category_id { get; set; }

        public int sub_category_id { get; set; }
    }
}

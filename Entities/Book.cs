namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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

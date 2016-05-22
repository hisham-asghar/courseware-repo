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
        [StringLength(200)]
        public string name { get; set; }

        public int author_id { get; set; }

        public int? cat_id { get; set; }

        public int file_id { get; set; }

        public int book_img { get; set; }

        [Required]
        [StringLength(150)]
        public string book_link { get; set; }
    }
}

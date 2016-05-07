namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Author")]
    public partial class Author
    {
        [Key]
        public int author_id { get; set; }

        [Required]
        [StringLength(50)]
        public string author_name { get; set; }
    }
}

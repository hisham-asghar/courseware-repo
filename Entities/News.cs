namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        [Key]
        public int news_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string news_text { get; set; }

        [Required]
        [StringLength(50)]
        public string news_images { get; set; }
    }
}

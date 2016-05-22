namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Magzines_Category
    {
        [Key]
        public int mag_cat_id { get; set; }

        [Required]
        [StringLength(50)]
        public string mag_cat_name { get; set; }
    }
}

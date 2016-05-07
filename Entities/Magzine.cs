namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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

namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SubCategory")]
    public partial class SubCategory
    {
        [Key]
        public int sub_cat_id { get; set; }

        [StringLength(100)]
        public string sub_cat_name { get; set; }
    }
}

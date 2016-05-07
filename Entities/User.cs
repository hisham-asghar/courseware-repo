namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [Key]
        public int user_id { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        [Required]
        [StringLength(50)]
        public string firstName { get; set; }

        [Required]
        [StringLength(50)]
        public string lastName { get; set; }

        public int gender { get; set; }

        public DateTime dob { get; set; }

        public int account { get; set; }

        [System.ComponentModel.DefaultValue(typeof(DateTime),"")]
        public DateTime onCreated { get; set; }

        public int isActive { get; set; }

        [Required]
        [StringLength(50)]
        public string image { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAPI
{
    [Table("user")]
    public partial class UserProperty
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Email { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? FirstName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? LastName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Roles { get; set; }
        [Column("isCreated")]
        public bool? IsCreated { get; set; }
    }
}

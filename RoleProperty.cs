using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public class RoleProperty
{
    [Table("Role")]
    public partial class RoleProperty
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        public string? Name { get; set; }

    }
}

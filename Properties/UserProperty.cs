using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Properties
{
    [Table("User")]
    public partial class UserProperty
    {

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        [Required]
        public string Email { get; set; }

        //[JsonPropertyName("TeamMembership")]
        
        [StringLength(50)]
        [Required]
        public bool isAdministrator { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        public string? FirstName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? LastName { get; set; }




    }

}



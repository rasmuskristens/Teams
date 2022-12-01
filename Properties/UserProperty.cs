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
    [Table("Sociolite_User")]
    public partial class UserProperty
    {

        [Key]
        [Column("id")]
        public int MSTeamsId { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        [Required]
        public string FirstName { get; set; }
        




    }

}



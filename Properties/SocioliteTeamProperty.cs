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
    [Table("Sociolite_Team")]
    public partial class SocioliteTeamProperty
    {

        [Key]
        public int TeamId { get; set; }
        [StringLength(50)]
        [Unicode(false)]

        //[JsonPropertyName("Team")]
         
        public string? MSTeamsTeamId { get; set; }

        public string MSTeamsChannelId { get; set; }
        
        public string? Name { get; set; }

        public string Recurring { get; set; }

        public bool isActive { get; set; }

        






    }

}



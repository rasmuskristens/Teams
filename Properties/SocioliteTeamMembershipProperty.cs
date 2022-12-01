using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Properties.Team
{
    [Table("Sociolite_Team_Membership")]
    public partial class SocioliteTeamMembershipProperty

    {
        //[JsonPropertyName("User")]
        [Key,Column(Order = 0)]
        [ForeignKey("UserProperty")]
        public int UserId { get; set; }
        [StringLength(50)]
        [Unicode(false)]

        //[JsonPropertyName("Team")]
        [Key, Column(Order = 1)]
        [ForeignKey("SocioliteTeamProperty")]
        public int TeamId { get; set; }
        
        [StringLength(50)]
        [Unicode(false)]
        [Required]
        public string TeamSpecificRole { get; set; }
    }

}

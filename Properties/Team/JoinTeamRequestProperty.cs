using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties.Team
{
    [Table("Join_Team_Request")]
    public class JoinTeamRequestProperty
    {

        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Unicode(false)]
        public DateTime DateRequested { get; set; }

        //[JsonPropertyName("Team_Membership")]
        [ForeignKey("TeamMembershipProperty")]
        public int TeamMembershipId { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        [Required]
        public bool Reviewed { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        [Required]
        public bool Approved { get; set; }

        //[JsonPropertyName("User")]
        [StringLength(50)]
        [Unicode(false)]
        [ForeignKey("UserProperty")]
        public UserProperty ReviewedBy { get; set; }

        [Unicode(false)]

        public DateTime ReviewedDate { get; set; }
    }
}

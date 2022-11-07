using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Properties.Team
{
    [Table("Team_Membership")]
    public partial class TeamMembershipProperty

    {
        //[Key,Column(Order = 0)]
        [ForeignKey("UserProperty")]
        public int UserId { get; set; }
        [StringLength(50)]
        [Unicode(false)]

        //[Key, Column(Order = 1)]
        [ForeignKey("TeamProperty")]
        public int TeamId { get; set; }
        [StringLength(50)]
        [Unicode(false)]

        [ForeignKey("RoleProperty")]
        public int RoleId { get; set; }
        [StringLength(50)]
        [Unicode(false)]

        public bool isActive { get; set; }
    }

}

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
    [Table("Team")]
    public class TeamProperty
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Name { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        //[ForeignKey("DepartmentProperty")]
        public string? DepartmentID { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        [ForeignKey("DepartmentProperty")]
        public ICollection<TeamMembershipProperty>? TeamMembershipProperties { get; set; }

    }
}

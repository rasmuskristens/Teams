using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Properties.Team;

namespace Properties.Activity
{
    public class ActivityProperty
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }


        [Unicode(false)]
        [Required]
        public String Name { get; set; }

        [Unicode(false)]
        
        public DateTime CreationDate { get; set; }

        [Unicode(false)]
        [Required]
        public int DayRecurrance { get; set; }

        [Unicode(false)]
        [Required]
        public String HourRecurrance { get; set; }

        [Unicode(false)]
        [Required]
        public DateTime EndDate { get; set; }

        [Unicode(false)]
        [Required]
        public String Type { get; set; }

        //[JsonPropertyName("User")]
        [ForeignKey("UserProperty")]
        [StringLength(50)]
        [Required]
        public UserProperty? CreatedBy { get; set; }

        //[JsonPropertyName("User")]
        [ForeignKey("TeamProperty")]
        [StringLength(50)]
        [Required]
        public TeamProperty? TeamId { get; set; }



    }
}

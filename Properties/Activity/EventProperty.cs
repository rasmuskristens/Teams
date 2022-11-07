using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties.Activity
{
    [Table("Event")]
    public class EventProperty
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }


        [Unicode(false)]
        [Required]
        public DateTime Date { get; set; }

        [Unicode(false)]
        [Required]
        public String Type { get; set; }

        //[JsonPropertyName("Activity")]
        [ForeignKey("ActivityProperty")]
        [StringLength(50)]
        [Required]
        public ActivityProperty? ParentActivityId { get; set; }
    }
}

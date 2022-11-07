using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Properties.Activity;

namespace Properties.Poll
{
    [Table("Poll")]
    public class PollProperty
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Unicode(false)]
        [Required]
        public string Question { get; set; }

        //[JsonPropertyName("User")]
        [ForeignKey("UserProperty")]
        [StringLength(50)]
        [Required]
        public UserProperty? CreatedBy { get; set; }

        [Required]
        public bool IsExtendable { get; set; }

        //[JsonPropertyName("Event")]
        [ForeignKey("EventProperty")]
        [StringLength(50)]
        [Required]
        public EventProperty? PollOptionsProperties { get; set; }




        


    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties.Poll
{
    public class PollProperty
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Unicode(false)]
        [Required]
        public String Question { get; set; }

        //[JsonPropertyName("TeamMembership")]


        [ForeignKey("UserProperty")]
        [StringLength(50)]
        [Required]
        public UserProperty? CreatedBy { get; set; }

        public bool IsExtendable { get; set; }

        [ForeignKey("PollOptionsProperty")]
        [StringLength(50)]
        [Required]
        public ICollection<PollOptionProperty>? PollOptionsProperties { get; set; }




        


    }
}

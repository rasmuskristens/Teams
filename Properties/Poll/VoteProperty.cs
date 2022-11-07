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
    [Table("Vote")]
    public class VoteProperty
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Unicode(false)]
        [Required]
        public DateTime Time { get; set; }

        //[JsonPropertyName("Poll_Option")]
        [ForeignKey("PollOptionsProperty")]
        [StringLength(50)]
        [Required]
        public PollOptionProperty? PollOptionsProperties { get; set; }

        //[JsonPropertyName("User")]
        [ForeignKey("UserProperty")]
        [StringLength(50)]
        [Required]
        public UserProperty? CreatedBy { get; set; }
    }
}

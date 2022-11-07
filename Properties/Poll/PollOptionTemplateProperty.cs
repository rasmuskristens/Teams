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
    public class PollOptionTemplateProperty
    {
        [Table("Poll_Options_Template   ")]
        public class VoteProperty
        {
            [Key]
            [Column("id")]
            public int Id { get; set; }

            [Unicode(false)]
            [Required]
            public DateTime time { get; set; }

            //[JsonPropertyName("TeamMembership")]

            [ForeignKey("PollOptionsProperty")]
            [StringLength(50)]
            [Required]
            public PollOptionProperty? pollOptionsProperties { get; set; }

            [ForeignKey("UserProperty")]
            [StringLength(50)]
            [Required]
            public UserProperty? CreatedBy { get; set; }
        }
    }
}

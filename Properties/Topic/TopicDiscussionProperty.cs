using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Properties.Topic
{
    [Table("Topic_Discussion")]

    public class TopicDiscussionProperty
    {

        [Key]
        [Column("id")]
        public int Id { get; set; }


        [Unicode(false)]
        [Required]
        public String TopicText { get; set; }

        //[JsonPropertyName("User")]
        [ForeignKey("UserProperty")]
        [StringLength(50)]
        [Required]
        public UserProperty? CreatedBy { get; set; }

        //[JsonPropertyName("Activity")]
        [ForeignKey("ActivityProperty")]
        [Required]
        public UserProperty? ActivityId { get; set; }


    }
}

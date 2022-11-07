using Microsoft.EntityFrameworkCore;
using Properties.Poll;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Properties.Topic
{
    public class TopicResponseProperty
    {
        [Table("Topic_Response")]
        public class VoteProperty
        {
            [Key]
            [Column("id")]
            public int Id { get; set; }

            [Unicode(false)]
            [Required]
            public String ResponseText { get; set; }


            [Unicode(false)]
            [Required]
            public DateTime Created { get; set; }

            //[JsonPropertyName("User")]
            [ForeignKey("UserProperty")]
            [StringLength(50)]
            [Required]
            public UserProperty? CreatedBy { get; set; }

            //[JsonPropertyName("Topic_Discussion")]
            [ForeignKey("TopicDiscussionProperty")]
            [StringLength(50)]
            public TopicDiscussionProperty? DicussionId { get; set; }




        }
    }
}

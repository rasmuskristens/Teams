using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Properties
{
    [Table("Poll_Vote")]
    public partial class PollVoteProperty
    {

        [Key, Column(Order = 0)]
        [ForeignKey("UserProperty")]
        public int UserId { get; set; }
        [StringLength(50)]
        [Unicode(false)]

        //[JsonPropertyName("Team")]
        [Key, Column(Order = 1)]
        [ForeignKey("ActivityOccuranceProperty")]
        public int ActivityOccuranceId { get; set; }

        [Unicode(false)]
        [Required]
        public int VoteOptionNumber { get; set; }
        




    }

}



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
    [Table("Activity_Occurrence")]
    public partial class ActivityOccurenceProperty
    {

        [Key, Column(Order = 0)]
        [ForeignKey("SocioliteTeamProperty")]
        public int TeamId { get; set; }

        //[JsonPropertyName("Team")]
        [Key, Column(Order = 1)]
        public DateTime ActivityOccuranceId { get; set; }


        [ForeignKey("CustomPollProperty")]
        public int PollId { get; set; }

        [ForeignKey("CustomDiscussionProperty")]
        public int DiscussionId { get; set; }




    }

}



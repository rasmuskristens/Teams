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
    [Table("Custom_Discussion")]
    public partial class CustomDiscussionProperty
    {

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey("SocioliteTeamProperty")]
        public int TeamId { get; set; }

        [ForeignKey("UserProperty")]
        public int CreatedBy { get; set; }


        [Required]
        public string? TopicText { get; set; }


        [Required]
        public DateTime CreatedAt { get; set; }





    }

}



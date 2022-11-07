using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties.Poll
{
    public class PollQuestionTemplate
    {
        [Table("Poll_Question_template")]

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Unicode(false)]
        [Required]
        public String Question { get; set; }

        //[JsonPropertyName("TeamMembership")]

        [Unicode(false)]
        [Required]
        public bool IsTeamPersonalized { get; set; }


    }
}

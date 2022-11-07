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
    [Table("Poll_Question_Template")]
    public class PollQuestionTemplate
    {
        
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Unicode(false)]
        [Required]
        public string Question { get; set; }


        [Unicode(false)]
        [Required]
        public bool IsTeamPersonalized { get; set; }


    }
}

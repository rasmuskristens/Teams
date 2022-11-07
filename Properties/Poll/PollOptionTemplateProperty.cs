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
    [Table("Poll_Option_Template")]
    public class PollOptionTemplateProperty
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }


        [Unicode(false)]
        [Required]
        public string? OptionText { get; set; }


    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Properties.Poll
{
    [Table("Poll_Option")]
    public class PollOptionProperty
    {

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string OptionText { get; set; }

        //[JsonPropertyName("User")]
        [ForeignKey("UserProperty")]
        [StringLength(50)]
        [Required]
        public UserProperty? CreatedBy { get; set; }

        [Unicode(false)]
        [Required]
        public DateTime Time { get; set; }

        [ForeignKey("PollOptionsProperty")]
        [StringLength(50)]
        [Required]
        public PollOptionProperty? PollOptionsProperties { get; set; }


        [ForeignKey("PollProperty")]
        [StringLength(50)]
        [Required]
        public PollOptionTemplateProperty PollId { get; set; }

        [ForeignKey("PollOptionTemplateProperty")]
        [StringLength(50)]
        [Required]
        public ICollection<PollOptionTemplateProperty>? Templates { get; set; }

    }
}

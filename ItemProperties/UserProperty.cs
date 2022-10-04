using System.ComponentModel.DataAnnotations;

namespace ItemProperties
{
    public class UserProperty
    {

        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [MaxLength(15)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(15)]
        public string LastName { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        public bool isCreated { get; set; }

    }
}
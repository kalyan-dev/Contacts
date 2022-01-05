using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        
        [MaxLength(50)]
        public string FullName { get; set; }

        [MaxLength(30)]
        public string Email { get; set; }

        [Required]
        [MaxLength(10)]
        [RegularExpression(@"\d{10}", ErrorMessage ="Invalid Mobile Number")]
        public string Mobile { get; set; }
        public string UserId { get; set; }
    }
}

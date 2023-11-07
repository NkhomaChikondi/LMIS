using System.ComponentModel.DataAnnotations;

namespace LMIS.Models
{
    public class ApplicationUser
    {
        [Required]
        public string Full_Name { get; set; }
        [Required]
        public string Location { get; set; }

    }
}
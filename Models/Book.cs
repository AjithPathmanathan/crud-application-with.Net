using System.ComponentModel.DataAnnotations;

namespace MyFirstProject.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name = "Enter Title")]
        [Required]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Enter Description")] // Corrected typo here
        public string Description { get; set; }

        [Display(Name = "Enter Author")]
        [Required]
        public string Author { get; set; }
    }
}

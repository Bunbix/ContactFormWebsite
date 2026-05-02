using System.ComponentModel.DataAnnotations;

namespace ContactFormWebsite.Models
{
    public class ContactForm
    {
        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]
        [Display(Name = "Your Name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [Display(Name = "Email Address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your message")]
        [StringLength(1000, MinimumLength = 5, ErrorMessage = "Message must be between 5 and 1000 characters")]
        [Display(Name = "Your Message")]
        public string Message { get; set; } = string.Empty;
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContactFormWebsite.Models;

namespace ContactFormWebsite.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public ContactForm Contact { get; set; } = new ContactForm();
        
        public bool ShowSuccessMessage { get; set; } = false;
        
        public void OnGet()
        {
            ShowSuccessMessage = false;
        }
        
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                ShowSuccessMessage = true;
                ModelState.Clear();
                Contact = new ContactForm();
                return Page();
            }
            
            ShowSuccessMessage = false;
            return Page();
        }
    }
}

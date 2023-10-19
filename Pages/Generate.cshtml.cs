using Microsoft.AspNetCore.Mvc.RazorPages;
using PassGen.Models; // Dodajte ovu liniju za korištenje PasswordGenerator
using System.Collections.Generic;

namespace PassGen.Pages
{
    public class GenerateModel : PageModel
    {
        public int Length { get; set; } = 12;
        public bool IncludeUpper { get; set; } = true;
        public bool IncludeLower { get; set; } = true;
        public List<string> Passwords { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Passwords = PasswordValidator.GeneratePasswords(Length, IncludeUpper, IncludeLower, 10);
        }
    }
}

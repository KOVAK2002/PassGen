using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using PassGen.Models;

public class CheckModel : PageModel
{
    [BindProperty]
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    public string Message { get; set; }

    public void OnGet()
    {
    }

   public void OnPost(string password)
        {
            bool isValid = PasswordValidator.IsValidPassword(password);
            Message = isValid ? "Lozinka je valjana!" : "Lozinka nije valjana.";
        }
    
}

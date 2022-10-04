using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Xml.Linq;

namespace RazorFirstApp.Pages.forms
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credential Credential { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();
            //Verify Credentials
            if (Credential.UserName == "admin" && Credential.Password == "Password")
            {
                // Creating a security context
                var claims = new List<Claim>
            {
               // new Claim(ClaimTypes.Name, Credential.UserName),
               new Claim(ClaimTypes.Name,"admin"),
                new Claim(ClaimTypes.Email,"admin@RazorFirstApp.com")
            };
                // var identity= new ClaimsIdentity(claims);
                var identity = new ClaimsIdentity("MyCookieTrial");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync("MyCookieTrial", claimsPrincipal);
                return RedirectToPage("/forms/ManageOrders");
            }
            return Page();
        }

    }
    public class Credential
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
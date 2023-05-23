using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.InteropServices;
using System.Security.Claims;

namespace dotnetcoresample.Pages;

public class IndexModel : PageModel
{

    public IEnumerable<Claim> UserClaims { get; set; }
    ClaimsPrincipal principal = HttpContext.Current.User as ClaimsPrincipal;
    public void OnGet()
    {
	    principal = principal.claims;
    }
}

﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.InteropServices;
using System.Security.Claims;

namespace dotnetcoresample.Pages;

public class IndexModel : PageModel
{

    public IEnumerable<Claim> UserClaims { get; set; }
    public string UserName
    public void OnGet()
    {
	    UserClaims = HttpContext.User.Claims;
        UserName = UserClaims.First.toString;
    }
}

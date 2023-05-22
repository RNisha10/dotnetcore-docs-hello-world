﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.InteropServices;
using System.Security.Claims;

namespace dotnetcoresample.Pages;

public class IndexModel : PageModel
{

    public string UserClaims { get; set; }
    public void OnGet()
    {
	    UserClaims = HttpContext.User.FindFirstValue("preferred_username");
    }
}

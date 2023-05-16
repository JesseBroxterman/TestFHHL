using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using Common.Web.Alerts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FHHL.Web.Controllers
{
    public class AccountController: Controller
    {
        [AllowAnonymous]
        public IActionResult SignOut()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("SignOut", "Account", new { Area = "MicrosoftIdentity" });

            return RedirectToAction("Index", "Home");
        }

public IActionResult CreateUser(string userName)
{
    if (string.IsNullOrEmpty(userName))
        return RedirectToAction(nameof(Index), "Home").WithDanger("Error", "The username cannot be left blank.");


    //Execute the rest of the action
    return View();
}
    }
}

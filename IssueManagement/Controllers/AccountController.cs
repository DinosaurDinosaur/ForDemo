using Microsoft.AspNetCore.Mvc;

namespace IssueManagement.Controllers;

public class AccountController : Controller
{
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
}

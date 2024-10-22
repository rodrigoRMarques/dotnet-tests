//What will be your review comments if you are reviewing this code?

using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    [HttpPost]
    public IActionResult Login(string userName, string password)
    {
        var command = conn.CreateCommand();
        command.CommandText = $"SELECT 1 FROM Users WHERE UserName='{userName}' AND Password='{password}'";
        var result = command.ExecuteReader();

        if (!result.HasRows)
        {
            ModelState.AddModelError("", "Incorrect Username or Password");
            return View();
        }

        Response.Cookies.Append("CurrentUser", userName);
        return Redirect("/");
    }
}
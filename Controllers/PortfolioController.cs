using Microsoft.AspNetCore.Mvc;
namespace Portfolio_1.Controllers;
public class Portfolio : Controller
{
    [HttpGet("")]
    public string Home()
    {
        return "This is My Index!";
    }
    [HttpGet("projects")]
    public string Projects()
    {
        return "These are my Projects!";
    }
    [HttpGet("contact")]
    public string Contact()
    {
        return "This is my Contact!";
    }
}


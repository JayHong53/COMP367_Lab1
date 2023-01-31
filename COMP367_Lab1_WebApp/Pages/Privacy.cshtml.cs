using System.Globalization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COMP367_Lab1_WebApp.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        string dateTime = DateTime.Now.ToString("d", new CultureInfo("en-CA"));
        ViewData["TimeStamp"] = dateTime;
    }
}



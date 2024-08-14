using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudsitoWeb.Pages;

public class ReadModel : PageModel
{
    private readonly ILogger<ReadModel> _logger;

    public ReadModel(ILogger<ReadModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}


using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudsitoWeb.Pages;

public class UpdateModel : PageModel
{
    private readonly ILogger<UpdateModel> _logger;

    public UpdateModel(ILogger<UpdateModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}


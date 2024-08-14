using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudsitoWeb.Pages;

public class DeleteModel : PageModel
{
    private readonly ILogger<DeleteModel> _logger;

    public DeleteModel(ILogger<DeleteModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}


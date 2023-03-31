using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clase3.Models;
using Clase3.Services;

namespace Clase3.Pages;

public class IndexModel : PageModel
{
    public List<Movie> MovieList { get; set; }
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        MovieList = MovieServices.GetAll();

        // Add
        // Delete
        // Update
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Clase2.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    [BindProperty]
    public Form Data { get; set; }

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        // Buscar en la BD el form con id que esta en el param
        // var formulario = servicioFormulario.get(parametro)

        var parametro = Request.Query["parametrox"];
        Data = new Form();
        Data.Mail = parametro;
        Data.Password = "12345";

    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Guardar en la BD, procesar info, etc.
        var formValues = Data;
        return RedirectToAction("Index");
    }
}
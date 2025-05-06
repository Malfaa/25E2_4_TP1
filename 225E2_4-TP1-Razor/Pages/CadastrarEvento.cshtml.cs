using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _225E2_4_TP1_Razor.Pages;

public class CadastrarEvento : PageModel
{
    [BindProperty]
    public Evento Evento { get; set; } = new();
    public string Mensagem { get; set; }
    
    public void OnGet()
    {
        
    }

    public void OnPost()
    {
        Mensagem = $"Evento '{Evento.Title}' | '{Evento.Date}' | '{Evento.Location}' cadastrado com sucesso!";
        Console.WriteLine($"Evento '{Evento.Title}' | '{Evento.Date}' | '{Evento.Location}' cadastrado com sucesso!");
    }
}

public class Evento
{
    public string Title { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
}
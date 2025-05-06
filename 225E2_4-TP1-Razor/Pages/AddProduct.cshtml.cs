using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _225E2_4_TP1_Razor.Pages;

public class AddProduct : PageModel
{
    [BindProperty]
    public Produto Produto { get; set; } = new();
    public string Mensagem { get; set; }
    
    public void OnGet()
    {
        
    }
    public void OnPost()
    {
        Mensagem = $"Produto cadastrado com sucesso! Nome: {Produto.Name}," +
                   $" " +
                   $"Preço: {Produto.Price:C}";
    }
}

public class Produto
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}
using Microsoft.AspNetCore.Mvc;

namespace LunchStore.Models
{
    public class Categoria : Controller
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }
        public List<Lanche> Lanches { get; set; }
    }
}

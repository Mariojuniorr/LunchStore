using LunchStore.Context;
using LunchStore.Models;
using LunchStore.Repositories.Interfaces;

namespace LunchStore.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;

    }
}

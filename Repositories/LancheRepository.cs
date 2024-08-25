using LunchStore.Context;
using LunchStore.Models;
using LunchStore.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LunchStore.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;
        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Lanche> Lanches => _context.Lanches;
        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches
            .Where(p => p.IsLanchePreferido)
            .Include(c => c.Categoria);
        public Lanche GetLancheById(int lancheId) => _context.Lanches.FirstOrDefault(I=>I.LancheId == lancheId);
    }
}

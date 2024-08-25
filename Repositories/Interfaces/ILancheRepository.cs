using LunchStore.Models;

namespace LunchStore.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }

        Lanche GetLancheById(int LancheId);
    }
}

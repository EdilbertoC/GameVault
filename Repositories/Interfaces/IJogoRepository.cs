using GameVault.Models;

namespace GameVault.Repositories.Interfaces
{
    public interface IJogoRepository
    {
        IEnumerable<Jogo> GetAllJogosPerUser(string userId);
        Jogo GetJogoById(int jogoId);
        void AddJogo(Jogo jogo);
        void DeleteJogo(int jogoId);
    }
}

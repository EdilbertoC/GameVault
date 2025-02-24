using GameVault.Models;

namespace GameVault.Repositories.Interfaces
{
    public interface IJogoRepository
    {
        IEnumerable<Jogo> GetAllJogos();
        Jogo GetJogoById(int jogoId);
        void AddJogo(Jogo jogo);
    }
}

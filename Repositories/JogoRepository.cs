using GameVault.Context;
using GameVault.Models;
using GameVault.Repositories.Interfaces;

namespace GameVault.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private readonly AppDbContext _context;
        public JogoRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddJogo(Jogo jogo)
        {
            _context.Jogos.Add(jogo);
            _context.SaveChanges();
        }

        public IEnumerable<Jogo> GetAllJogos()
        {
            return _context.Jogos;
        }

        public Jogo GetJogoById(int jogoId)
        {
            return _context.Jogos.FirstOrDefault(j => j.JogoId == jogoId);
        }
    }
}

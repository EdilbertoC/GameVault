﻿using GameVault.Context;
using GameVault.Models;
using GameVault.Repositories.Interfaces;
using System.Security.Claims;

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

        public void DeleteJogo(int jogoId)
        {
            var jogo = _context.Jogos.SingleOrDefault(
                j => j.JogoId == jogoId);
            if (jogo != null)
            {
                _context.Jogos.Remove(jogo);
            }
            _context.SaveChanges();
        }

        public IEnumerable<Jogo> GetAllJogosPerUser(string userId)
        {
            return _context.Jogos.Where(j => j.AppUserId == userId);
        }

        public Jogo GetJogoById(int jogoId)
        {
            return _context.Jogos.FirstOrDefault(j => j.JogoId == jogoId);
        }
    }
}

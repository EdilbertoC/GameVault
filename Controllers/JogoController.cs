using GameVault.Models;
using GameVault.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GameVault.Controllers
{
    public class JogoController : Controller
    {
        private readonly IJogoRepository _jogoRepository;
        public JogoController(IJogoRepository jogoRepository)
        {
            _jogoRepository = jogoRepository;
        }

        public IActionResult List()
        {
            var jogos = _jogoRepository.GetAllJogos().ToList();
            return View(jogos);
        }
    }
}

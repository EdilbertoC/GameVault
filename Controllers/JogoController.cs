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

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                _jogoRepository.AddJogo(jogo);
                return RedirectToAction("List");
            }
            return View(jogo);
        }

        public IActionResult Delete(int jogoId)
        {
            _jogoRepository.DeleteJogo(jogoId);
            return RedirectToAction("List");
        }
    }
}

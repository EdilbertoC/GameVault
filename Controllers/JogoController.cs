using GameVault.Models;
using GameVault.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.Security.Claims;

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
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var jogos = _jogoRepository.GetAllJogosPerUser(userId).ToList();
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
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                jogo.AppUserId = userId;

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

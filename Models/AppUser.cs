using Microsoft.AspNetCore.Identity;

namespace GameVault.Models
{
    public class AppUser : IdentityUser
    {
        public virtual ICollection<Jogo> Jogos { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}

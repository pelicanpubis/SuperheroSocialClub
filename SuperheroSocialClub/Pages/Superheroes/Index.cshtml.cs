using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Database;
using SuperheroSocialClub.Model;

namespace SuperheroSocialClub.Pages.Superheroes
{
    public class IndexModel : PageModel
    {
        public List<SuperheroModel> Superheroes { get; set; }
        public void OnGet()
        {
            Superheroes = SuperheroesRepo.Superheroes;
        }

    }
}

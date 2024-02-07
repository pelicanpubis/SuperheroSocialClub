using Microsoft.AspNetCore.Mvc;
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


        public IActionResult OnPostDelete(int id)
        {
            //Hitta superhero med id
            var superheroToRemove = SuperheroesRepo.Superheroes.FirstOrDefault(s => s.Id == id);

            // Om superhero finns, ta bort den från listan
            if (superheroToRemove != null)
            {
                SuperheroesRepo.Superheroes.Remove(superheroToRemove);
            }

          
            return RedirectToPage();
        }

    }
}

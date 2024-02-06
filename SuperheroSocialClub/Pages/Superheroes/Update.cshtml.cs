using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Database;
using SuperheroSocialClub.Model;

namespace SuperheroSocialClub.Pages.Superheroes
{
    public class UpdateModel : PageModel
    {
        public SuperheroModel? Superhero { get; set; }

        public void OnGet(int id)
        {
            Superhero = SuperheroesRepo.Superheroes.FirstOrDefault(s => s.Id == id);
        }
        public void OnPost(int id)
        {
            Superhero = SuperheroesRepo.Superheroes.FirstOrDefault(s => s.Id == id);

            if (Superhero != null && ModelState.IsValid)
            {
                SuperheroesRepo.UpdateSuperhero(Superhero);
                TempData["Message"] = "Superhero updated successfully!";
            }
            else
            {
                TempData["ErrorMessage"] = "Update failed. Please check your inputs.";
            }
        }
    }
}

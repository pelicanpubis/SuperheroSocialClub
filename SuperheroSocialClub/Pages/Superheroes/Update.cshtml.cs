using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Database;
using SuperheroSocialClub.Model;

namespace SuperheroSocialClub.Pages.Superheroes
{
    public class UpdateModel : PageModel
    {
        [BindProperty]
        public SuperheroModel? Superhero { get; set; }


        public void OnGet(int id)
        {
            Superhero = SuperheroesRepo.Superheroes.FirstOrDefault(s => s.Id == id);
        }
        public IActionResult OnPost()
        {
            if (Superhero != null && ModelState.IsValid)
            {
                SuperheroesRepo.UpdateSuperhero(Superhero);
                TempData["Message"] = "Superhero updated successfully!";
                return RedirectToPage("./Index");
            }
            else
            {
                TempData["ErrorMessage"] = "Update failed. Please check your inputs.";
                return Page();
            }
        }
    }
}

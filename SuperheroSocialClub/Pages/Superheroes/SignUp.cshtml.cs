using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Database;
using SuperheroSocialClub.Model;
using System.Globalization;

namespace SuperheroSocialClub.Pages.Superheroes
{
    public class SignUpModel : PageModel
    {
        public List<SuperheroModel> Superheroes { get; set; }



        //Borde göra de till 
        [BindProperty]
        public string? Name { get; set; } 

        [BindProperty]
        public string SecretIdentity { get; set; } 

        [BindProperty]
        public string Superpower { get; set; }

        [BindProperty]

        public string? Image { get; set; }



        public IActionResult OnPostCreate()
        {

            if (Name != null && SecretIdentity != null && Superpower != null && Image != null)
            {
                // Skapa ett unikt id för den nya superhjälten baserat på antalet befintliga superhjältar
                int newId = SuperheroesRepo.Superheroes.Count + 1;

                // Skapa en ny instans av SuperheroModel med alla nödvändiga parametrar
                SuperheroModel newSuperhero = new SuperheroModel(
                    newId,
                    Name,
                    SecretIdentity,
                    Superpower,
                    Image
                );

                // Lägg till den nya superhjälten i listan
                SuperheroesRepo.Superheroes.Add(newSuperhero);

                return RedirectToPage("/Superheroes");
            }
            else
            {
                return Page();
            }


            //if (Name != null && SecretIdentity != null && Superpower != null && Image != null)
            //{
            //    SuperheroModel newSuperhero = new SuperheroModel
            //    (



            //    Name = Name,
            //    SecretIdentity = SecretIdentity,
            //    Superpower = Superpower,
            //    Image = Image



            //    );

            //    SuperheroesRepo.Superheroes.Add(newSuperhero);

            //    return RedirectToPage("/Superheroes");
            //}

            //else
            //{
            //    return Page();

            //}



        }
        public void OnGet()
        {
        }
    }
}

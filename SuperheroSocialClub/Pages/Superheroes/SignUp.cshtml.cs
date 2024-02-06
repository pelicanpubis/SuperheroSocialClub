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



        //Borde g�ra de till 
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
                // Skapa ett unikt id f�r den nya superhj�lten baserat p� antalet befintliga superhj�ltar
                int newId = SuperheroesRepo.Superheroes.Count + 1;

                // Skapa en ny instans av SuperheroModel med alla n�dv�ndiga parametrar
                SuperheroModel newSuperhero = new SuperheroModel(
                    newId,
                    Name,
                    SecretIdentity,
                    Superpower,
                    Image
                );

                // L�gg till den nya superhj�lten i listan
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

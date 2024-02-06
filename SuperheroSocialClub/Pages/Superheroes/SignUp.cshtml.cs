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


        [BindProperty] 

        public int Id { get; set; } 
        //Borde göra de till 
        [BindProperty]
        public string? Name { get; set; } 

        [BindProperty]
        public string SecretIdentity { get; set; } 

        [BindProperty]
        public string Superpower { get; set; }

        [BindProperty]

        public string? Image { get; set; }




        public IActionResult OnPost()
        {
            if (Name != null && SecretIdentity != null && Superpower != null && Image != null)
            {

                SuperheroModel newSuperhero = new SuperheroModel(
                   Id,
                     Name,
                  SecretIdentity,
                   Superpower,
                   Image
                      );


                //SuperheroModel newSuperhero = new SuperheroModel()
                //(
                //   //Id = Superheroes.Count +1 ,
                //   //Name = Name,
                //   //SecretIdentity = SecretIdentity,
                //   //Superpower = Superpower,
                //   //Image = Image


                //);

                SuperheroesRepo.Superheroes.Add(newSuperhero);

                return RedirectToPage("/Superheroes/Index");
            }
            else
            {
                return Page();
            }
        }

        public void OnGet()
        {
        }
    }
}

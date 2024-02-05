using SuperheroSocialClub.Model;

namespace SuperheroSocialClub.Database
{
    public static class SuperheroesRepo
    {
        public static List<SuperheroModel> Superheroes { get; set; } = new List<SuperheroModel>()
        {
            new SuperheroModel(1, "Batman", "Bruce Wayne", "Super Rich Bitch", "/images/premade/Batman.jpg"),
            new SuperheroModel(2, "Superman", "Clark Kent", "Super fly sass", "/images/premade/Superman.png"),
            new SuperheroModel(3, "Spider-man", "Peter Parker", "Dweeb web", "/images/premade/Spiderman.png")
        };
    }
}

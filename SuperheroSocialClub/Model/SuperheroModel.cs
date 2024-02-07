using System.ComponentModel.DataAnnotations;

namespace SuperheroSocialClub.Model
{
    public class SuperheroModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string SecretIdentity { get; set; }
        [Required]
        public string Superpower { get; set; }

        public string? Image { get; set; }

        public SuperheroModel()
        {

        }
        public SuperheroModel(int id, string name, string secretIdentity, string superpower, string image)
        {
            Id = id;
            Name = name;
            SecretIdentity = secretIdentity;
            Superpower = superpower;
            Image = image;
        }

    }
}

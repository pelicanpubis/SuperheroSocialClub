namespace SuperheroSocialClub.Model
{
    public class SuperheroModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SecretIdentity { get; set; }

        public string Superpower { get; set; }

        public string? Image { get; set; }


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

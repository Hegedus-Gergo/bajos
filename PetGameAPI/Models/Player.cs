namespace PetGameAPI.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Level { get; set; }
        public int IngameCurrency { get; set; }
    }
}

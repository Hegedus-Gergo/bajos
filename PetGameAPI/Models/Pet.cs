namespace PetGameAPI.Models
{
    public class Pet
    {
        public int ID { get; set; }
        public virtual Player Player { get; set; }
        public int PlayerID { get; set; }
        public string PetName { get; set; }
        public PetType PetType { get; set; }
        public int Age { get; set; }
        public int Happiness { get; set; }
        public int Hunger { get; set; }
        public int Energy {  get; set; }
        public virtual List<Inventory> Inventory { get; set; }
    }
}

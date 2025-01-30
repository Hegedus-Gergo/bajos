namespace PetGameAPI.Models
{
    public class Tool
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Energy { get; set; }
        public int Hunger { get; set; }
        public int Happiness { get; set; }
        public int Cost { get; set; }
        public ToolType Type { get; set; }
    }
}

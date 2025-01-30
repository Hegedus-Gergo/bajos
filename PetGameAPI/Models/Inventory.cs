namespace PetGameAPI.Models
{
    public class Inventory
    {
        public int ID { get; set; }
        public virtual Pet Pet { get; set; }
        public int PetID { get; set; }
        public virtual Tool Tool { get; set; }
        public int ToolID { get; set; }
        public int Quantity { get; set; }
    }
}

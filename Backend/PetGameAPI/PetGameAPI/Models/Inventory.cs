using System.ComponentModel.DataAnnotations;

public class Inventory
{
    [Key]
    public int ID { get; set; }

    [Required]
    public int PetID { get; set; }

    [Required]
    public int ToolID { get; set; }

    [Required]
    public int Quantity { get; set; }

    public Pet Pet { get; set; }
    public Tool Tool { get; set; }
}

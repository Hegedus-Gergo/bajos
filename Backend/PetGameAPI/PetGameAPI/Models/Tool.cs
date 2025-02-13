using PetGameAPI.Models;
using System.ComponentModel.DataAnnotations;

public class Tool
{
    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(100)]
    public string? Name { get; set; }

    [Required]
    public int Energy { get; set; } = 0;

    [Required]
    public int Hunger { get; set; } = 0;

    [Required]
    public int Happiness { get; set; } = 0;

    [Required]
    public int Cost { get; set; }

    [Required]
    public ToolType Type { get; set; }
}

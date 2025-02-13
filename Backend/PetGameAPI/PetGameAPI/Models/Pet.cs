using PetGameAPI.Models;
using System.ComponentModel.DataAnnotations;

public class Pet
{
    [Key]
    public int ID { get; set; }

    [Required]
    public int PlayerID { get; set; }

    [Required]
    [StringLength(100)]
    public string? PetName { get; set; }

    [Required]
    public PetType PetType { get; set; }

    [Required]
    public int Age { get; set; } = 1;

    [Required]
    public int Happiness { get; set; } = 75;

    [Required]
    public int Hunger { get; set; } = 30;

    [Required]
    public int Energy { get; set; } = 70;

    public Player? Player { get; set; }
}

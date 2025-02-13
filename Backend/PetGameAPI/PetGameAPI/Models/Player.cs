using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

public class Player : IdentityUser
{
    [Required]
    public int Level { get; set; } = 1;

    [Required]
    public int InGameCurrency { get; set; } = 1000;

    public ICollection<Pet>? Pets { get; set; }
}

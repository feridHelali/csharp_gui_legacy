using System.ComponentModel.DataAnnotations;

namespace Core.Models;

public class Car
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [MaxLength(300)]
    public string Description { get; set; } = string.Empty;
    public double Price { get; set; }
}


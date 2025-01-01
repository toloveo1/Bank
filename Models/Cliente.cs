using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Cliente
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string? Nombre { get; set; }

    [Required]
    [MaxLength(50)]
    public string? Email { get; set; }

    public ICollection<Cuenta>? Cuentas { get; set; }
}

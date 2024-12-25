using System.ComponentModel.DataAnnotations;

public class Cuenta
{
    public int Id { get; set; }

    [Required]
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }

    [Required]
    [MaxLength(20)]
    public string NumeroCuenta { get; set; }

    public decimal Saldo { get; set; }
}

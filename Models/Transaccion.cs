using System;
using System.ComponentModel.DataAnnotations;

public class Transaccion
{
    public int Id { get; set; }

    [Required]
    public int CuentaId { get; set; }
    public Cuenta Cuenta { get; set; } = new Cuenta();

    [Required]
    public decimal Monto { get; set; }

    public DateTime Fecha { get; set; }
    public string Tipo { get; set; } = string.Empty; // Depósito, Retiro, Transferencia
}

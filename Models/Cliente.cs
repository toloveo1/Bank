using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bank.Models 
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Email { get; set; }

         [Required]
        [MaxLength(20)]
        public int? Telefono { get; set; }

        public ICollection<Cuenta>? Cuentas { get; set; }
    }
}

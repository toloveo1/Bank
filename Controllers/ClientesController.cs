using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Bank.Models; 
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bank.Controllers 
{
    [Authorize]
    public class ClientesController : Controller
    {
        private readonly BankDbContext _context;

        public ClientesController(BankDbContext context)
        {
            _context = context;
        }

        // Acción para listar clientes
        public async Task<IActionResult> Index()
        {
            var clientes = await _context.Clientes.ToListAsync(); // Obtiene todos los clientes
            return View(clientes); // Pasa los clientes a la vista
        }
    }
}

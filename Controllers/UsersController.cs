using Microsoft.AspNetCore.Mvc;
using OnlineBerberRandevuSistemi.Data;
using OnlineBerberRandevuSistemi.Models;

namespace OnlineBerberRandevuSistemi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // CRUD işlemleri burada tanımlanacak
    }
}
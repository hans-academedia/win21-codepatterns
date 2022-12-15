using _03_LSP.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _03_LSP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ÚsersController : ControllerBase
    {
        private readonly UserContext _userContext;

        public ÚsersController(UserContext userContext)
        {
            _userContext = userContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return new OkObjectResult(await _userContext.Users.Include(x => x.Profile).ToListAsync());
        }
    }
}

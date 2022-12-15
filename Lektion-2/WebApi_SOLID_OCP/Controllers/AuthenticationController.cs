using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApi_SOLID_OCP.Contexts;
using WebApi_SOLID_OCP.Handlers.Account;
using WebApi_SOLID_OCP.Handlers.Authentication;
using WebApi_SOLID_OCP.Handlers.Mapping;
using WebApi_SOLID_OCP.Models.Account;
using WebApi_SOLID_OCP.Models.Authentication;

namespace WebApi_SOLID_OCP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly DataContext _context;
        public AuthenticationController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("signUp")]
        public async Task<IActionResult> SignUp(SignUpModel model)
        {
            try
            {
                var account = AccountTypes.CreateAccountModel(model.AccountTypeId);
                MappingHandler.Map(account, model);
                var result = await account.AuthenticationHandler.SignUpAsync(account, model.Password, _context);

                if (result is OkResult) return Created("", null);
                if (result is ConflictResult) return new ConflictObjectResult("Det finns redan en användare med samma e-postadress");
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return new BadRequestObjectResult("Något gick fel när användarkontot skulle skapas. Kontakta support.");
        }

    }
}

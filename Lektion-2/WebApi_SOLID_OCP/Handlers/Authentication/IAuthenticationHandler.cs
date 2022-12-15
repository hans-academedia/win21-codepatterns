using Microsoft.AspNetCore.Mvc;
using WebApi_SOLID_OCP.Contexts;
using WebApi_SOLID_OCP.Models.Account;

namespace WebApi_SOLID_OCP.Handlers.Authentication
{
    public interface IAuthenticationHandler
    {
        Task<IActionResult> SignUpAsync(IAccountModel model, string password, DataContext _context);
    }
}
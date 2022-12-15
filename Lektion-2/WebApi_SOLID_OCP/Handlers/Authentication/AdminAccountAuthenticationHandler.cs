using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApi_SOLID_OCP.Contexts;
using WebApi_SOLID_OCP.Models.Account;
using WebApi_SOLID_OCP.Models.Entitites;

namespace WebApi_SOLID_OCP.Handlers.Authentication
{
    public class AdminAccountAuthenticationHandler : IAuthenticationHandler
    {
        public async Task<IActionResult> SignUpAsync(IAccountModel model, string password, DataContext _context)
        {
            try
            {
                if (await _context.AdminAccounts.AnyAsync(x => x.Email == model.Email))
                    return new ConflictResult();

                var adminAccountEntity = new AdminAccountEntity
                {
                    Id = model?.Id ?? Guid.NewGuid(),
                    FirstName = model!.FirstName,
                    LastName = model!.LastName,
                    Email = model!.Email,
                    PhoneNumber = model?.PhoneNumber,
                    RoleId = model!.RoleId
                };
                adminAccountEntity.GeneratePassword(password);

                _context.Add(adminAccountEntity);
                await _context.SaveChangesAsync();
                return new OkResult();
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return new BadRequestResult();
        }
    }
}

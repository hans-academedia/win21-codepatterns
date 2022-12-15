using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApi_SOLID_OCP.Contexts;
using WebApi_SOLID_OCP.Models.Account;
using WebApi_SOLID_OCP.Models.Entitites;

namespace WebApi_SOLID_OCP.Handlers.Authentication
{
    public class UserAccountAuthenticationHandler : IAuthenticationHandler
    {

        public async Task<IActionResult> SignUpAsync(IAccountModel model, string password, DataContext _context)
        {
            try
            {
                if (await _context.UserAccounts.AnyAsync(x => x.Email == model.Email))
                    return new ConflictResult();

                var userAccountEntity = new UserAccountEntity
                {
                    Id = model?.Id ?? Guid.NewGuid(),
                    Email = model!.Email,
                    UserProfile = new UserAccountProfileEntity
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        PhoneNumber = model?.PhoneNumber,
                        StreetName = model?.StreetName,
                        PostalCode = model?.PostalCode,
                        City = model?.City
                    }
                };
                userAccountEntity.GeneratePassword(password);

                _context.Add(userAccountEntity);
                await _context.SaveChangesAsync();
                return new OkResult();
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return new BadRequestResult();
        }
    }
}

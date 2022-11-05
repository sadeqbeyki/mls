using Microsoft.AspNetCore.Identity;

namespace MLS.WebUI.Models.Identity
{
    public class AppUserValidator : IUserValidator<AppUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user)
        {
            List<IdentityError> errors = new();

            //if (!user.Email.EndsWith("@xserver.com"))
            //{
            //    errors.Add(new IdentityError
            //    {
            //        Code = "InvalidEmail",
            //        Description = "Use xServer email for Registration"
            //    });
            //}

            return Task.FromResult(errors.Any() ?
                    IdentityResult.Failed(errors.ToArray()) :
                    IdentityResult.Success);

        }
    }
}

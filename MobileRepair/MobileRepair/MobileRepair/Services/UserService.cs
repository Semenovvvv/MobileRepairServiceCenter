using Microsoft.AspNetCore.Identity;
using MobileRepair.Constants;
using MobileRepair.Data;
using MobileRepair.Interfaces;

namespace MobileRepair.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<UserService> _logger;
        public UserService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole<int>> roleManager, ILogger<UserService> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

        public async Task<IdentityResult> RegisterClient(ApplicationUser user, string password)
        {
            var result = new IdentityResult();
            user.UserName = user.Email;
            try
            {
                if (await _userManager.FindByEmailAsync(user.Email) != null)
                {
                    throw new Exception("Пользователь c такой почтой уже существует");
                }
                

                result = await _userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, RoleConstants.Client);
                }

                return result;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                _logger.LogError(string.Join('\n', result.Errors));
                return result;
            }
        }
    }
}

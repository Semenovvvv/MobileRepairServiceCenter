using Microsoft.AspNetCore.Identity;
using MobileRepair.Data;

namespace MobileRepair.Interfaces
{
    public interface IUserService
    {
        public Task<IdentityResult> RegisterClient(ApplicationUser user, string password);
    }
}

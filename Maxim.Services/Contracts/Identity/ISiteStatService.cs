using System.Collections.Generic;
using System.Threading.Tasks;
using Maxim.Entities.Identity;
using System.Security.Claims;
using Maxim.ViewModels.Identity;

namespace Maxim.Services.Contracts.Identity
{
    public interface ISiteStatService
    {
        Task<List<User>> GetOnlineUsersListAsync(int numbersToTake, int minutesToTake);

        Task<List<User>> GetTodayBirthdayListAsync();

        Task UpdateUserLastVisitDateTimeAsync(ClaimsPrincipal claimsPrincipal);

        Task<AgeStatViewModel> GetUsersAverageAge();
    }
}
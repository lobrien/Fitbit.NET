using System.Threading.Tasks;
using Fitbit.Models;

namespace Fitbit.Portable.Spike
{
    /// <summary>
    /// temporary interface for spike
    /// </summary>
    public interface IFitbitClient
    {
        Task<FitbitResponse<UserProfile>> GetUserProfileAsync(string encodedUserId = default(string));
    }
}
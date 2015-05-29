using System.Net.Http.Headers;

namespace Fitbit.Portable.Spike
{
    public interface IAuthorization
    {
        AuthenticationHeaderValue GetHeader();
    }
}
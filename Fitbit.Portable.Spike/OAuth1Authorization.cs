using System.Net.Http.Headers;

namespace Fitbit.Portable.Spike
{
    internal class OAuth1Authorization : IAuthorization
    {
        public AuthenticationHeaderValue GetHeader()
        {
            throw new System.NotImplementedException();
        }
    }
}
using System;
using System.Net.Http.Headers;

namespace Fitbit.Portable.Spike
{
    internal class OAuth2Authorization : IAuthorization
    {
        public ITokenStore TokenStore { get; private set; }


        public OAuth2Authorization(ITokenStore tokenStore)
        {
            if (tokenStore == null)
                throw new ArgumentNullException("tokenStore", "Token Store can not be null; please provide an ITokenStore instance.");
            TokenStore = tokenStore;
        }

        public AuthenticationHeaderValue GetHeader()
        {
            // go and get the header values and store as required

            throw new System.NotImplementedException();
        }
    }
}

// EXTENSION TOKENSTORE FOR EF - DIFFERENT NUGET PACKAGE ?
namespace Fitbit.Portable.Extensions.EntityFramework
{
    using Fitbit.Portable.Spike;

    public class TokenStore : ITokenStore
    {
        public string Read()
        {
            throw new NotImplementedException();
        }

        public void Write(string bearerToken, string refreshToken, DateTime expiration)
        {
            throw new NotImplementedException();
        }
    }
}

// EXTENSION TOKENSTORE FOR RAVENDB - DIFFERENT NUGET PACKAGE 
namespace Fitbit.Portable.Extensions.RavenDb
{
    using Fitbit.Portable.Spike;

    public class TokenStore : ITokenStore
    {
        public string Read()
        {
            throw new NotImplementedException();
        }

        public void Write(string bearerToken, string refreshToken, DateTime expiration)
        {
            throw new NotImplementedException();
        }
    }
}
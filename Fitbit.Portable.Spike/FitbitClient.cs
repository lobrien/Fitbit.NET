using System;
using System.Net.Http;
using System.Threading.Tasks;
using Fitbit.Models;

namespace Fitbit.Portable.Spike
{
    public class FitbitClient : IFitbitClient
    {
        public IAuthorization Authorization { get; private set; }
        public ISerialization Serialization { get; private set; }
        
        private HttpClient client;

        public FitbitClient(IAuthorization authorization) : this(authorization, new JsonDotNetSerializer())
        {
            
        }

        internal FitbitClient(IAuthorization authorization, ISerialization serialization)
        {
            if (authorization == null)
                throw new ArgumentNullException("authorization", "Authorization can not be null; please provide an Authorization instance.");
            Authorization = authorization;

            if (serialization == null)
                throw new ArgumentNullException("serialization", "Serializer can not be null; please provide an ISerialization instance.");
            Serialization = serialization;
        }

        public Task<FitbitResponse<UserProfile>> GetUserProfileAsync(string encodedUserId = null) // probably should do overrides with CancellationToken parameter
        {
            SetupHttpClient();

            // use the client to call the respource

            // use the serialization implementation to return the values

            throw new NotImplementedException();
        }

        private void SetupHttpClient()
        {
            // not overly happy about this bit but setting up the HttpClient is required at this point
            if (client == null)
            {
                client = new HttpClient();
            }

            client.DefaultRequestHeaders.Authorization = Authorization.GetHeader();
        }
    }
}

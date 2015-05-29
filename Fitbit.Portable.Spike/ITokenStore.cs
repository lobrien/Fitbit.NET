using System;

namespace Fitbit.Portable.Spike
{
    public interface ITokenStore
    {
        string Read();

        void Write(string bearerToken, string refreshToken, DateTime expiration); // Maybe a TimeSpan instead?
    }
}
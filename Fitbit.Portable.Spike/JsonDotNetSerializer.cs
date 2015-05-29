using System;

namespace Fitbit.Portable.Spike
{
    internal class JsonDotNetSerializer : ISerialization
    {
        public T From<T>(string input)
        {
            throw new NotImplementedException();
        }

        public string To<T>(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
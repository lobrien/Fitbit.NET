namespace Fitbit.Portable.Spike
{
    public interface ISerialization
    {
        T From<T>(string input);

        string To<T>(T obj);
    }
}
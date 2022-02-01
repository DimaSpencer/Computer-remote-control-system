namespace M1.Services
{
    public interface IDataSaver
    {
        Task Save<T>(T data);
    }
}
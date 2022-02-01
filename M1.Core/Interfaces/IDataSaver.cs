namespace M1.Infrastructure.Interfaces
{
    public interface IDataSaver
    {
        Task Save<T>(T data);
    }
}
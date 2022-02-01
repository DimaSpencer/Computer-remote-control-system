namespace M1.Infrastructure.Interfaces
{
    public interface ISystem
    {
        Task OpenProcess();
        Task CloseProcess();

        Task GetInfo();
    }
}
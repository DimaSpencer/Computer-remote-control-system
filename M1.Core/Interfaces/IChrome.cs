namespace M1.Infrastructure.Interfaces
{
    public interface IChrome
    {
        Task<IDictionary<string, string>> GetAllUsers();
        Task<List<ChromeHistory>> GetAllHistory();
    }
}
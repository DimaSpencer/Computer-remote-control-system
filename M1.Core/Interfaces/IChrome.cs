namespace M1.Application.Interfaces
{
    public interface IChrome
    {
        Task<IDictionary<string, string>> GetAllUsers();
        //Task<List<ChromeHistory>> GetAllHistory();
    }
}
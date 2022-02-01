namespace M1.Infrastructure.Interfaces
{
    public interface ISteam
    {
        Task<ICollection<FileInfo>> GetUserFiles();
        Task GetVac();
    }
}
using M1.Domain.Entityes;
using M1.Domain.Interfaces;

namespace M1.Application.Machines.Queries.GetMachine;

public class MachineViewModel : IMapWith<Machine>
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public bool IsOnline { get; set; }
    public DateTime LastOnlineTime { get; set; }

    public string System { get; set; }

    public string Description { get; set; }

    public bool HasSteam { get; set; }
    public bool HasChrome { get; set; }

    public string CPU { get; set; }

    public List<ChromeCredential> ChromeCredentials { get; set; }
}
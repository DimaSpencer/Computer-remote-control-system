namespace M1.Domain.Entityes;

public class ChromeCredential
{
    public Guid Id { get; set; }
    public string Site { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }

    public Guid MachineId { get; set; }
    public Machine Machine { get; set; }
}

namespace TaskChallenge.Communication.Responses;

public class ResponseGetByIdTaskJson
{
    public Guid Id;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Priority { get; set; }
    public DateTime DateLimit { get; set; }
    public int Status { get; set; }
}

namespace TaskChallenge.Communication.Responses;

public class ResponseRegisterTaskJson
{
    public Guid Id;
    public string Task {  get; set; } = string.Empty;
    public int Priority { get; set; }
    public DateTime DateLimit { get; set; }
    public int Status { get; set; }
}

using TaskChallenge.Communication.Requests;
using TaskChallenge.Communication.Responses;

namespace TaskChallenge.Application.UseCases.Task.Register;

public class RegisterTaskUseCase
{
    public ResponseRegisterTaskJson Execute (RequestRegisterTaskJson request)
    {
        return new ResponseRegisterTaskJson
        {
            Id = Guid.NewGuid(),
            Task = "teste primeira task",
            Priority = 1,
            DateLimit = new DateTime(year: 2020, month: 1, day: 1),
            Status = 2
        };
    }
}

using TaskChallenge.Communication.Responses;

namespace TaskChallenge.Application.UseCases.Task.GetById;

public class GetByIdUseCase
{
    public ResponseGetByIdTaskJson Execute(Guid Id)
    {
        Guid IdFake = new Guid("d06da52f-04d0-489b-b254-06c9b7192c50");

        if (IdFake != Id)
        {
            throw new ArgumentException("O id fornecido é inválido");
        }

        return new ResponseGetByIdTaskJson
        {
            Id = new Guid("d06da52f-04d0-489b-b254-06c9b7192c50"),
            Name = "Ficar de chamego com meu love",
            Description = "A tarefa consiste em ficar de grude e dengo com meu amor",
            Status = 1,
            DateLimit = new DateTime(year: 2024, month: 11, day: 3),
            Priority = 3
        };
    }
}

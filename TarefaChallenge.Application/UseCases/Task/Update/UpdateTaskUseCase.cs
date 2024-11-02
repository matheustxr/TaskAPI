using TaskChallenge.Communication.Requests;

namespace TaskChallenge.Application.UseCases.Task.Update;

public class UpdateTaskUseCase
{
    public void Execute(Guid Id, RequestRegisterTaskJson request)
    {
        Guid IdFake = new Guid("d06da52f-04d0-489b-b254-06c9b7192c50");

        if (IdFake != Id)
        {
            throw new ArgumentException("O Id fornecido é inválido.");
        }

        string Name = request.Name;
        string Description = request.Description;
        int Priority = request.Priority;
        DateTime DateLimit = request.DateLimit;
        int Status = request.Status;


        return;
    }
}

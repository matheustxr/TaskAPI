namespace TaskChallenge.Application.UseCases.Task.Delete;

public class DeleteTaskUseCase
{
    public void Execute(Guid Id)
    {
        Guid IdFake = new Guid("d06da52f-04d0-489b-b254-06c9b7192c50");

        if (IdFake != Id)
        {
            throw new ArgumentException("O id fornecido é inválido");
        }

        return;
    }
}

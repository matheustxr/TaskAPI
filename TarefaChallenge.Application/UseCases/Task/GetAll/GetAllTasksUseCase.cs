using TaskChallenge.Communication.Responses;

namespace TaskChallenge.Application.UseCases.Task.GetAll;

public class GetAllTasksUseCase
{
    public ResponseGetAllTasksJson Execute()
    {
        return new ResponseGetAllTasksJson
        {
            Tasks = new List<ResponseRegisterTaskJson>
            {
                new ResponseRegisterTaskJson
                {
                    Id = new Guid ("d06da52f-04d0-489b-b254-06c9b7192c50"),
                    Name = "Ficar de chamego com meu love",
                    Status = 1,
                    DateLimit = new DateTime(year: 2024, month: 11, day: 3),
                    Priority = 3
                }
            }
        };
    }
}

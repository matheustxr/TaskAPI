# TaskChallenge API

### Description

This project is an API for a Task Management system. The API allows users to create, view, update, and delete tasks, helping to track activities and monitor their progress.

### Features

The system allows the following operations:

- **Create a task**: Register a new task with detailed information.
- **View all tasks**: Display all tasks stored in the system.
- **View a task by ID**: Retrieve details of a specific task using its ID.
- **Update a task**: Edit the information of an existing task.
- **Delete a task**: Remove a specific task from the system.

### Task Structure

Each task contains the following fields:

- `Id`: Unique identifier for the task.
- `Name`: Task name.
- `Description`: Task description.
- `Priority`: Task priority level (high, medium, low).
- `Due Date`: Deadline for task completion.
- `Status`: Current task status (completed, in progress, pending).

### Endpoints

Below are the available endpoints in the API, handled by the `TaskController`:

- **POST /api/task**: Create a new task.
  - **Request**: `RequestRegisterTaskJson`
  - **Response**: `ResponseRegisterTaskJson` (201 Created), `ResponseErrorJson` (400 Bad Request)

- **PUT /api/task/{Id}**: Update an existing task.
  - **Request**: `RequestRegisterTaskJson`
  - **Response**: No content (204), `ResponseErrorJson` (404 Not Found)

- **GET /api/task**: Return all tasks.
  - **Response**: `ResponseGetAllTasksJson` (200 OK), `ResponseErrorJson` (400 Bad Request)

- **GET /api/task/{Id}**: Return a specific task by ID.
  - **Response**: `ResponseGetByIdTaskJson` (200 OK), `ResponseErrorJson` (404 Not Found)

- **DELETE /api/task/{Id}**: Delete a specific task by ID.
  - **Response**: No content (204), `ResponseErrorJson` (404 Not Found)

### Project Structure

The solution is organized into three main layers to promote separation of concerns:

1. **TaskChallenge.API**: Contains the `TaskController`, which exposes the endpoints and directs requests to the appropriate use cases in the application layer.

2. **TaskChallenge.Application**: Contains the business logic, divided into different use cases. Here, operations like creating, updating, viewing, and deleting tasks are implemented.

3. **TaskChallenge.Communication**: Contains communication contracts such as enums, requests, and responses:
   - **Enums**: Defines the types `PriorityTask` and `StatusTask` to represent task priority and status.
   - **Requests**: Defines the `RequestRegisterTaskJson` input format for registering a new task.
   - **Responses**: Defines the response formats for various operations, including errors.

### Technologies Used

- **C# and .NET**: Programming language and framework used to develop the API.
- **ASP.NET Core**: Framework for creating RESTful endpoints.
- **Entity Framework**: (If applicable) Used for mapping and manipulating data.

### How to Run the Project

1. Navigate to the project folder:
   ```bash
   git clone https://github.com/seu-usuario/TaskChallenge.git

2. Navigate to the project folder:
   ```bash
   cd TaskChallenge

3. Run the project:
   ```bash
   dotnet run --project TaskChallenge.API





**PT-BR**
# Task API 

### Descrição

Este projeto é uma API para um sistema de Gerenciamento de Tarefas. A API permite que os usuários criem, visualizem, editem e excluam tarefas, facilitando o controle de atividades e o acompanhamento de seu progresso.

### Funcionalidades

O sistema permite as seguintes operações:

- **Criar uma tarefa**: Cadastrar uma nova tarefa com informações detalhadas.
- **Visualizar todas as tarefas**: Exibir todas as tarefas cadastradas no sistema.
- **Visualizar uma tarefa por ID**: Consultar os detalhes de uma tarefa específica usando seu ID.
- **Editar uma tarefa**: Atualizar as informações de uma tarefa existente.
- **Excluir uma tarefa**: Remover uma tarefa específica do sistema.

### Estrutura da Tarefa

Cada tarefa possui os seguintes campos:

- `Id`: Identificador único da tarefa.
- `Nome`: Nome da tarefa.
- `Descrição`: Descrição da tarefa.
- `Prioridade`: Nível de prioridade da tarefa (alta, média, baixa).
- `Data Limite`: Prazo para a conclusão da tarefa.
- `Status`: Status atual da tarefa (concluída, em andamento, aguardando).

### Endpoints

Abaixo estão os endpoints disponíveis na API, organizados pelo controller `TaskController`:

- **POST /api/task**: Cria uma nova tarefa.
  - **Request**: `RequestRegisterTaskJson`
  - **Response**: `ResponseRegisterTaskJson` (201 Created), `ResponseErrorJson` (400 Bad Request)

- **PUT /api/task/{Id}**: Atualiza uma tarefa existente.
  - **Request**: `RequestRegisterTaskJson`
  - **Response**: No content (204), `ResponseErrorJson` (404 Not Found)

- **GET /api/task**: Retorna todas as tarefas.
  - **Response**: `ResponseGetAllTasksJson` (200 OK), `ResponseErrorJson` (400 Bad Request)

- **GET /api/task/{Id}**: Retorna uma tarefa específica pelo ID.
  - **Response**: `ResponseGetByIdTaskJson` (200 OK), `ResponseErrorJson` (404 Not Found)

- **DELETE /api/task/{Id}**: Exclui uma tarefa específica pelo ID.
  - **Response**: No content (204), `ResponseErrorJson` (404 Not Found)

### Estrutura do Projeto

Este projeto segue a arquitetura em camadas para organizar a lógica de negócios, comunicação e API, facilitando a manutenção e escalabilidade do sistema. A imagem acima fornece uma visão geral da estrutura de pastas e suas responsabilidades.

A solução está organizada em três camadas principais para promover a separação de responsabilidades:

1. **TaskChallenge.API**: Contém o controller `TaskController`, que expõe os endpoints e direciona as solicitações para os respectivos casos de uso na camada de aplicação.

2. **TaskChallenge.Application**: Contém a lógica de negócios dividida em diferentes casos de uso (`UseCases`). Aqui estão implementadas as operações de criação, atualização, visualização e exclusão de tarefas.

3. **TaskChallenge.Communication**: Contém os contratos de comunicação, como enums, requests e responses:
   - **Enums**: Define os tipos de `PriorityTask` e `StatusTask` para representar a prioridade e o status de cada tarefa.
   - **Requests**: Define o formato de entrada `RequestRegisterTaskJson` para o registro de uma nova tarefa.
   - **Responses**: Define os formatos de resposta para diferentes operações, incluindo erros.

### Tecnologias Utilizadas

- **C# e .NET**: Linguagem e framework utilizados para desenvolver a API.
- **ASP.NET Core**: Framework para criação dos endpoints RESTful.
- **Entity Framework**: (Caso aplicável) Utilizado para mapeamento e manipulação dos dados.

### Como Executar o Projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/TaskChallenge.git

2. Navegue até a pasta do projeto:
   ```bash
   cd TaskChallenge

3. Execute o projeto:
   ```bash
   dotnet run --project TaskChallenge.API



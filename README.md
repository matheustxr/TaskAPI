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

3. cd TaskChallenge
   ```bash
   dotnet run --project TaskChallenge.API



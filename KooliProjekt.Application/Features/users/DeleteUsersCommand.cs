using KooliProjekt.Application.Behaviors;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.users
{
    public class DeleteUsersCommand : IRequest<OperationResult>, ITransactional
    {
        public int Id { get; set; }
    }
}

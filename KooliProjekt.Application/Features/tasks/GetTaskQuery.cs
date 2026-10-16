using KooliProjekt.Application.Data;
using MediatR;

namespace KooliProjekt.Application.Features.tasks
{
    public class GetTaskQuery : IRequest<task>
    {
        public int Id { get; set; }
    }
}

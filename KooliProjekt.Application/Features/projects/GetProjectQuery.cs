using KooliProjekt.Application.Data;
using MediatR;

namespace KooliProjekt.Application.Features.projects
{
    public class GetProjectQuery : IRequest<project>
    {
        public int Id { get; set; }
    }
}

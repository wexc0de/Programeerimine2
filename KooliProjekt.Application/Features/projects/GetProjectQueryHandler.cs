using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.tasks;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.projects
{

    public class GetProjectQueryHandler : IRequestHandler<GetProjectQuery, project>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetProjectQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<project> Handle(GetProjectQuery request, CancellationToken cancellationToken)
        {
            var list = await _dbContext.Projects.FindAsync(request.Id, cancellationToken);

            return list;
        }
    }
}

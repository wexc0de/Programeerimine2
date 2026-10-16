using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using MediatR;

namespace KooliProjekt.Application.Features.tasks
{
    public class GetTaskQueryHandler : IRequestHandler<GetTaskQuery, task>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetTaskQueryHandler (ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<task> Handle(GetTaskQuery request, CancellationToken cancellationToken)
        {
            var list = await _dbContext.Tasks.FindAsync(request.Id, cancellationToken);

            return list;
        }
    }
}

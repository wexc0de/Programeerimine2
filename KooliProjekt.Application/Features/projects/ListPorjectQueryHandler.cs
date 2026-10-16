using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.projects
{
    public class ListProjectsQueryHandler : IRequestHandler<ListProjectsQuery, IEnumerable<project>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListProjectsQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<project>> Handle(ListProjectsQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Projects.ToListAsync(cancellationToken);

            return result;
        }
    }
}

using KooliProjekt.Application.Data;
using KooliProjekt.Application.Dto;
using KooliProjekt.Application.Features.logs;
using KooliProjekt.Application.Infrastructure.Paging;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using LogEntity = KooliProjekt.Application.Data.logs;

namespace KooliProjekt.Application.Features.projects
{
    public class ListProjectsQueryHandler : IRequestHandler<ListProjectsQuery, IEnumerable<Project<ProjectDto>>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListProjectsQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Project<ProjectDto>>> Handle(ListProjectsQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Projects.ToListAsync(cancellationToken);

            return result;
        }
    }
}

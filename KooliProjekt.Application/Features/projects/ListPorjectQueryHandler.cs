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

namespace KooliProjekt.Application.Features.projects
    {
        public class ListProjectsQueryHandler : IRequestHandler<ListProjectsQuery, OperationResult<PagedResult<ProjectDto>>>
        {
            private readonly ApplicationDbContext _dbContext;

            public ListProjectsQueryHandler(ApplicationDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<OperationResult<PagedResult<ProjectDto>>> Handle(ListProjectsQuery request, CancellationToken cancellationToken)
            {
                var result = new OperationResult<PagedResult<ProjectDto>>();
                result.Value = await _dbContext.Projects
                    .AsNoTracking()
                    .OrderByDescending(project => project.id)
                    .Select(project => new ProjectDto
                    {
                        id = project.id,
                        name = project.name,
                        start = project.start,
                        deadline = project.Deadline,
                        budget = project.buget
                    })
                    .GetPagedAsync(request.Page, request.PageSize);

                return result;
            }
        }
    }

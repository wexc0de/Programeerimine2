using KooliProjekt.Application.Data;
using KooliProjekt.Application.Dto;
using KooliProjekt.Application.Features.logs;
using KooliProjekt.Application.Features.projects;
using KooliProjekt.Application.Infrastructure.Paging;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.tasks
{
    public class ListTasksQueryHandler : IRequestHandler<ListTasksQuery, OperationResult<PagedResult<TaskDto>>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListTasksQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<PagedResult<TaskDto>>> Handle(ListTasksQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<PagedResult<TaskDto>>();
            result.Value = await _dbContext.Tasks
                .AsNoTracking()
                .OrderByDescending(task => task.id)
                .Select(task => new TaskDto
                {
                    id = task.id,
                    title = task.title,
                    start = task.start,
                    estimatedHours = task.estimatedhours,
                    description = task.description,
                    IsCompleted = task.IsCompleted,
                    FixedPrice = task.FixedPrice
                })
                .GetPagedAsync(request.Page, request.PageSize);

            return result;
        }
    }
}

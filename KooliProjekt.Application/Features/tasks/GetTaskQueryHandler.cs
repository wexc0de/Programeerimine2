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
    public class GetTaskQueryHandler : IRequestHandler<GetTaskQuery, OperationResult<TaskDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetTaskQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<TaskDto>> Handle(GetTaskQuery request, CancellationToken cancellationToken)
        {
            var response = new OperationResult<TaskDto>();
            response.Value = await _dbContext.Tasks
                .AsNoTracking()
                .Where(task => task.id == request.Id)
                .Select(task => new TaskDto
                {
                    id = task.id,
                    title = task.title,
                    start = task.start,
                    estimatedHours = task.estimatedhours,
                    description = task.description,
                    IsCompleted =  task.IsCompleted,
                    FixedPrice = task.FixedPrice
                })
                .FirstOrDefaultAsync(cancellationToken);

            return response;
        }
    }
}
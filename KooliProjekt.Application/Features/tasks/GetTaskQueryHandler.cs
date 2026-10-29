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

namespace KooliProjekt.Application.Features.tasks
{
    public class GetTaskQueryHandler : IRequestHandler<GetTaskQuery, Task<TaskDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetTaskQueryHandler (ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Task<TaskDto>> Handle(GetTaskQuery request, CancellationToken cancellationToken)
        {
            var list = await _dbContext.Tasks.FindAsync(request.Id, cancellationToken);

            return list;
        }
    }
}

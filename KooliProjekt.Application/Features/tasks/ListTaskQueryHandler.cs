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
    public class ListTasksQueryHandler : IRequestHandler<ListTasksQuery, IEnumerable<Task<TaskDto>>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListTasksQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Task<TaskDto>>> Handle(ListTasksQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Tasks.ToListAsync(cancellationToken);

            return result;
        }
    }
}

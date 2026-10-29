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


namespace KooliProjekt.Application.Features.logs
{
    public class ListLogsQueryHandler : IRequestHandler<ListLogsQuery, OperationResult<PagedResult<LogsDto>>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListLogsQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<PagedResult<LogsDto>>> Handle(ListLogsQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<PagedResult<LogsDto>>();
            result.Value = await _dbContext.Logs
                .AsNoTracking()
                .OrderByDescending(log => log.id)
                .Select(log => new LogsDto
                {
                    id = log.id,
                    date = log.date,
                    hours = log.hours,
                    worker = log.worker,
                    description = log.description
                })
                .GetPagedAsync(request.Page, request.PageSize);

            return result;
        }
    }
}


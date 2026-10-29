using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Dto;
using KooliProjekt.Application.Features.logs;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.Logs
{
    public class GetLogQueryHandler : IRequestHandler<GetLogQuery , OperationResult<LogsDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetLogQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<LogsDto>> Handle(GetLogQuery request, CancellationToken cancellationToken)
        {
            var response = new OperationResult<LogsDto>();
            response.Value = await _dbContext.Logs
                .AsNoTracking()
                .Where(log => log.id == request.Id)
                .Select(log => new LogsDto
                {
                    id = log.id,
                    date = log.date,
                    hours = log.hours,
                    worker = log.worker,
                    description = log.description
                })
                .FirstOrDefaultAsync(cancellationToken);

            return response;
        }
    }
}

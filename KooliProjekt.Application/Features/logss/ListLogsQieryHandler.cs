using LogEntity = KooliProjekt.Application.Data.logs;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using KooliProjekt.Application.Features.logs;

namespace KooliProjekt.Application.Features.logs
{
    public class ListLogsQueryHandler : IRequestHandler<ListLogsQuery, IEnumerable<LogEntity>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListLogsQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<LogEntity>> Handle(ListLogsQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Logs.ToListAsync(cancellationToken);

            return result;
        }
    }
}

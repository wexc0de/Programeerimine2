using LogEntity = KooliProjekt.Application.Data.logs;
using KooliProjekt.Application.Data;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.logs
{
    public class GetLogQueryHandler : IRequestHandler<GetLogQuery, LogEntity>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetLogQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<LogEntity> Handle(GetLogQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Logs.FindAsync(new object[] { request.Id }, cancellationToken);
        }
    }
}

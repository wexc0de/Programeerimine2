using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.tasks
{
    public class ListTasksQueryHandler : IRequestHandler<ListTasksQuery, IEnumerable<task>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListTasksQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<task>> Handle(ListTasksQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Tasks.ToListAsync(cancellationToken);

            return result;
        }
    }
}

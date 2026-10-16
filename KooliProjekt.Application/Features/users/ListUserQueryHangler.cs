using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.users
{
    public class ListUsersQueryHandler : IRequestHandler<ListUsersQuery, IEnumerable<user>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListUsersQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<user>> Handle(ListUsersQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Users.ToListAsync(cancellationToken);

            return result;
        }
    }
}

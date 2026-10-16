using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using MediatR;

namespace KooliProjekt.Application.Features.users
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, user>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetUserQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<user> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {           
            var list = await _dbContext.Users.FindAsync(request.Id, cancellationToken);

            return list;
        }
    }
}

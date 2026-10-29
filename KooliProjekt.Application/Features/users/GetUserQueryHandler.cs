using KooliProjekt.Application.Data;
using KooliProjekt.Application.Dto;
using KooliProjekt.Application.Features.logs;
using KooliProjekt.Application.Features.tasks;
using KooliProjekt.Application.Infrastructure.Paging;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace KooliProjekt.Application.Features.users
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, OperationResult<UserDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetUserQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<UserDto>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var response = new OperationResult<UserDto>();
            response.Value = await _dbContext.Users
                .AsNoTracking()
                .Where(user => user.id == request.Id)
                .Select(user => new UserDto
                {
                    id = user.id,
                    name = user.name,
                    password = user.password,
                    email = user.email
                })
                .FirstOrDefaultAsync(cancellationToken);

            return response;
        }
    }
}

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
using LogEntity = KooliProjekt.Application.Data.logs;

namespace KooliProjekt.Application.Features.users
{
    public class ListUsersQueryHandler : IRequestHandler<ListUsersQuery, OperationResult<PagedResult<UserDto>>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListUsersQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<PagedResult<UserDto>>> Handle(ListUsersQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<PagedResult<UserDto>>();
            result.Value = await _dbContext.Users
                .AsNoTracking()
                .OrderByDescending(user => user.id)
                .Select(user => new UserDto
                {
                    id = user.id,
                    name = user.name,
                    password = user.password,
                    email = user.email
                })
                .GetPagedAsync(request.Page, request.PageSize);

            return result;
        }
    }
}
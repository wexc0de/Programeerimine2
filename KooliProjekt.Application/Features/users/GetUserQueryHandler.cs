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

namespace KooliProjekt.Application.Features.users
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, User<UserDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetUserQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User<UserDto>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {           
            var list = await _dbContext.Users.FindAsync(request.Id, cancellationToken);

            return list;
        }
    }
}

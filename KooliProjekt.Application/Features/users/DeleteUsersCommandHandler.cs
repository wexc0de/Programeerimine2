using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.logss;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.users

{
    public class DeleteUsersCommandHandler : IRequestHandler<DeleteUsersCommand, OperationResult>
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteUsersCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult> Handle(DeleteUsersCommand request, CancellationToken cancellationToken)
        {
            await _dbContext.Users
                .Where(list => list.id == request.Id)
                .ExecuteDeleteAsync();

            return new OperationResult();
        }
    }
}

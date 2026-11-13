using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.logss;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.users
{
    public class SaveUsersCommandHandler : IRequestHandler<SaveUsersCommand, OperationResult>
    {
        private readonly ApplicationDbContext _dbContext;

        public SaveUsersCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult> Handle(SaveUsersCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult();

            var projectsExists = await _dbContext.Users
                .AnyAsync(project => project.id == request.Id);
            if (!projectsExists)
            {
                return result.AddPropertyError("Id", "Cannot find users with ID " + request.Id);
            }

            var list = new user();

            if (request.Id == 0)
            {
                _dbContext.Add(list);
            }
            else
            {
                list = await _dbContext.FindAsync<user>(request.Id);
            }

            list.id = request.Id;
            list.name = request.name;
            list.password = request.password;
            list.email = request.email;

            await _dbContext.SaveChangesAsync();

            return result;
        }
    }
}

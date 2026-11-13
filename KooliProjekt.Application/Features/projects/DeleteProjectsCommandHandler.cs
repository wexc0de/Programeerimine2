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

namespace KooliProjekt.Application.Features.projects

{
    public class DeleteProjectsCommandHandler : IRequestHandler<DeleteProjectsCommand, OperationResult>
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteProjectsCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult> Handle(DeleteProjectsCommand request, CancellationToken cancellationToken)
        {
            await _dbContext.Projects
                .Where(list => list.id == request.Id)
                .ExecuteDeleteAsync();

            return new OperationResult();
        }
    }
}

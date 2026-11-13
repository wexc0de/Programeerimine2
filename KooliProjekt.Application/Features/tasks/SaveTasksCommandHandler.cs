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

namespace KooliProjekt.Application.Features.tasks
{
    public class SaveTasksCommandHandler : IRequestHandler<SaveTasksCommand, OperationResult>
    {
        private readonly ApplicationDbContext _dbContext;

        public SaveTasksCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult> Handle(SaveTasksCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult();

            var projectsExists = await _dbContext.Tasks
                .AnyAsync(project => project.id == request.Id);
            if (!projectsExists)
            {
                return result.AddPropertyError("Id", "Cannot find tasks with ID " + request.Id);
            }

            var list = new task();

            if (request.Id == 0)
            {
                _dbContext.Add(list);
            }
            else
            {
                list = await _dbContext.FindAsync<task>(request.Id);
            }

            list.id = request.Id;
            list.title = request.title;
            list.start = request.start;
            list.estimatedhours = request.estimatedhours;
            list.responsiblePerson= request.responsiblePerson;
            list.description = request.description;
            list.IsCompleted = request.IsCompleted;
            list.FixedPrice = request.FixedPrice;

            await _dbContext.SaveChangesAsync();

            return result;
        }
    }
}

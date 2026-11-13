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

namespace KooliProjekt.Application.Features.projects
{
    public class SaveProjectsCommandHandler : IRequestHandler<SaveProjectsCommand, OperationResult>
    {
        private readonly ApplicationDbContext _dbContext;

        public SaveProjectsCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult> Handle(SaveProjectsCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult();

            var projectsExists = await _dbContext.Projects
                .AnyAsync(project => project.id == request.Id);
            if (!projectsExists)
            {
                return result.AddPropertyError("Id", "Cannot find projects with ID " + request.Id);
            }

            var list = new project();

            if (request.Id == 0)
            {
                _dbContext.Add(list);
            }
            else
            {
                list = await _dbContext.FindAsync<project>(request.Id);
            }

            list.id = request.Id;
            list.name = request.name;
            list.start = request.start;
            list.Deadline = request.deadline;
            list.budget = request.budget;

            await _dbContext.SaveChangesAsync();

            return result;
        }
    }
}

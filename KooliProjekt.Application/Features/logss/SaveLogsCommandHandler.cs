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

namespace KooliProjekt.Application.Features.logss
{
    public class SaveLogsCommandHandler : IRequestHandler<SaveLogsCommand, OperationResult>
    {
        private readonly ApplicationDbContext _dbContext;

        public SaveLogsCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult> Handle(SaveLogsCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult();

            var logsExists = await _dbContext.Logs
                .AnyAsync(log => log.id == request.Id);
            if (!logsExists)
            {
                return result.AddPropertyError("Id", "Cannot find logs with ID " + request.Id);
            }

            var list = new KooliProjekt.Application.Data.logs();

            if (request.Id == 0)
            {
                _dbContext.Add(list);
            }
            else
            {
                list = await _dbContext.FindAsync<KooliProjekt.Application.Data.logs>(request.Id);
            }

            list.id = request.Id;
            list.date = request.date;
            list.hours = request.hours;
            list.worker = request.worker;
            list.description = request.description;

            await _dbContext.SaveChangesAsync();

            return result;
        }
    }
}

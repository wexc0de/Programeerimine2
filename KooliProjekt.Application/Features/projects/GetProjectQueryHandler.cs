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

namespace KooliProjekt.Application.Features.projects
{

public class GetProjectQueryHandler : IRequestHandler<GetProjectQuery, OperationResult<ProjectDto>>
{
    private readonly ApplicationDbContext _dbContext;

    public GetProjectQueryHandler(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<OperationResult<ProjectDto>> Handle(GetProjectQuery request, CancellationToken cancellationToken)
    {
        var response = new OperationResult<ProjectDto>();
        response.Value = await _dbContext.Projects
            .AsNoTracking()
            .Where(project => project.id == request.Id)
            .Select(project => new ProjectDto
            {
                id = project.id,
                name = project.name,
                description = project.description
            })
            .FirstOrDefaultAsync(cancellationToken);

        return response;
    }
}
}

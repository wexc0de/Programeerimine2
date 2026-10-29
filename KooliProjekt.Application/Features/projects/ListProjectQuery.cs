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

namespace KooliProjekt.Application.Features.projects
{
    public class ListProjectsQuery : IRequest<OperationResult<PagedResult<ProjectDto>>>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}

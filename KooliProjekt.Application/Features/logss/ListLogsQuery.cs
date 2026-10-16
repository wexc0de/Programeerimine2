using LogEntity = KooliProjekt.Application.Data.logs;
using System.Collections.Generic;
using KooliProjekt.Application.Data;
using MediatR;

namespace KooliProjekt.Application.Features.logs
{
    public class ListLogsQuery : IRequest<IEnumerable<LogEntity>>
    {
    }
}
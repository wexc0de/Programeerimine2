using System.Collections.Generic;
using KooliProjekt.Application.Data;
using MediatR;

namespace KooliProjekt.Application.Features.tasks
{
    public class ListTasksQuery : IRequest<IEnumerable<task>>
    {
    }
}
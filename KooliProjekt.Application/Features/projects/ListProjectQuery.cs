using System.Collections.Generic;
using KooliProjekt.Application.Data;
using MediatR;

namespace KooliProjekt.Application.Features.projects
{
    public class ListProjectsQuery : IRequest<IEnumerable<project>>
    {
    }
}
using System.Collections.Generic;
using KooliProjekt.Application.Data;
using MediatR;

namespace KooliProjekt.Application.Features.users
{
    public class ListUsersQuery : IRequest<IEnumerable<user>>
    {
    }
}
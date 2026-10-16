using KooliProjekt.Application.Data;
using MediatR;

namespace KooliProjekt.Application.Features.users
{
    public class GetUserQuery : IRequest<user>
    {
        public int Id { get; set; }
    }
}

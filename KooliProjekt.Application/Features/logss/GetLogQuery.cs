using LogEntity = KooliProjekt.Application.Data.logs;
using KooliProjekt.Application.Data;
using MediatR;

namespace KooliProjekt.Application.Features.logs
{
    public class GetLogQuery : IRequest<LogEntity>
    {
        public int Id { get; set; }
    }
}

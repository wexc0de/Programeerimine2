using LogEntity = KooliProjekt.Application.Data.logs;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Dto;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using System.ClientModel.Primitives;

namespace KooliProjekt.Application.Features.logs
{
    public class GetLogQuery : IRequest<OperationResult<LogsDto>>
    {
        public int Id { get; set; }
    }
}

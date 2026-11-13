using KooliProjekt.Application.Behaviors;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.VisualBasic;
using System;

namespace KooliProjekt.Application.Features.logss
{
    public class SaveLogsCommand : IRequest<OperationResult>, ITransactional
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public decimal hours { get; set; }
        public string worker { get; set; }
        public string description { get; set; }
    }
}

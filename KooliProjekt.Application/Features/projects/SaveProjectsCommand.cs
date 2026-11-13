using KooliProjekt.Application.Behaviors;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.VisualBasic;
using System;

namespace KooliProjekt.Application.Features.projects
{
    public class SaveProjectsCommand: IRequest<OperationResult>, ITransactional
    {
        public int Id { get; set; }
        public string name { get; set; }
        public DateTime start { get; set; }
        public DateTime deadline { get; set; }
        public decimal budget { get; set; }
    }
}

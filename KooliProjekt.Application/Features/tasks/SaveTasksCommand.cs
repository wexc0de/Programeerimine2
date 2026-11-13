using KooliProjekt.Application.Behaviors;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.VisualBasic;
using System;

namespace KooliProjekt.Application.Features.tasks
{
    public class SaveTasksCommand : IRequest<OperationResult>, ITransactional
    {
        public int Id { get; set; }
        public string title { get; set; }
        public DateTime start { get; set; }
        public decimal estimatedhours { get; set; }
        public string responsiblePerson { get; set; }
        public string fixedprice { get; set; }
        public string description { get; set; }
        public bool IsCompleted { get; set; }
        public decimal FixedPrice { get; set; }

    }
}

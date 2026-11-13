using KooliProjekt.Application.Behaviors;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.VisualBasic;
using System;

namespace KooliProjekt.Application.Features.users
{
    public class SaveUsersCommand : IRequest<OperationResult>, ITransactional
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string email { get; set; }

    }
}

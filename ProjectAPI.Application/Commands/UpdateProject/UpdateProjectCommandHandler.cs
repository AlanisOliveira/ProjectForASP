using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using ProjectAPI.Infrastructure.Persistence;

namespace ProjectAPI.Application.Commands.UpdateProject
{
    public class UpdateProjectCommandHandler : IRequest<Unit>
    {
        private readonly ProjectDbContext _dbContext;
        public UpdateProjectCommandHandler(ProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == request.Id);

            project.Update(request.Title, request.Description, request.TotalCost);
            await _dbContext.SaveChangesAsync();
            return Unit.Value;
        }
    }   
}

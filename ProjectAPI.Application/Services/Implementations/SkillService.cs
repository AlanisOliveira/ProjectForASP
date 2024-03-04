using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectAPI.Application.Services.Interfaces;
using ProjectAPI.Application.ViewModels;
using ProjectAPI.Infrastructure.Persistence;

namespace ProjectAPI.Application.Services.Implementations
{
    public class SkillService : ISkillService
    {
        private readonly ProjectDbContext _dbContext;
        public SkillService(ProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<SkillViewModel> GetAll()
        {
             var skills = _dbContext.Skills;

            var skillsViewModel = skills
                .Select(s => new SkillViewModel(s.Id, s.Description))
                .ToList();

            return skillsViewModel;
        }
    }
}
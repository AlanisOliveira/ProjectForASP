using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using ProjectAPI.Application.ViewModels;
using ProjectAPI.Infrastructure.Persistence;

namespace ProjectAPI.Application.Queries.GetAllSkills
{
    public class GetAllSkillsQuery : IRequest<List<SkillViewModel>>
    {

    }
    
}
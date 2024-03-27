using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProjectAPI.Application.ViewModels
{
    public class SkillViewModel
    {
        public SkillViewModel(int id, string description, DateTime createdAt)
        {
            Id = id;
            Description = description;
        }
        
        public int Id{get; private set;}
        public string Description{get; private set;}
    }
}
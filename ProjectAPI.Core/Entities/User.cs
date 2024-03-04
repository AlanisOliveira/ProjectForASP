using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string FullName, string Email, DateTime birthDate)
        {
            FullName = FullName;
            Email = Email;
            BirthDate = birthDate;
            createdAt = DateTime.Now;
            Active = true;
            
            Skills = new List<UserSkill>();
            OwnedProject = new List<Project>();
            FreelancerProject = new List<Project>();

        }
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime createdAt { get; private set; }

        public bool Active { get; set; }

        public List<UserSkill> Skills { get; private set; }

        public List<Project> OwnedProject { get; private set; }
        public List<Project> FreelancerProject { get; private set; }

        
    }
}
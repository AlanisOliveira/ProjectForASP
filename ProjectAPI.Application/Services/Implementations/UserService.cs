using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectAPI.Application.InputModels;
using ProjectAPI.Application.Services.Interfaces;
using ProjectAPI.Application.ViewModels;
using ProjectAPI.Core.Entities;
using ProjectAPI.Infrastructure.Persistence;


namespace ProjectAPI.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly ProjectDbContext _dbContext;
        public UserService(ProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(CreateUserInputModel inputModel)
        {
            var user = new User(inputModel.FullName, inputModel.Email, inputModel.BirthDate);

            _dbContext.Users.Add(user);

            return user.Id;
        }

        public UserViewModel GetUser(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);

            if (user == null)
            {
                return null;
            }

            return new UserViewModel(user.FullName, user.Email);
        }
    
    }
}
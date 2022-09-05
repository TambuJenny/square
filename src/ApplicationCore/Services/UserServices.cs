using DomainService.Interface;
using DomainService.Models.Request;
using Infrastruture.Context;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationCore.Services
{
    public class UserServices: UserInterface
    {
        private readonly Context _DbSet;

        public UserServices(Context dbSet)
        {
            _DbSet = dbSet;
        }

        public ActionResult Create(UserRequest body)
        {

            throw new NotImplementedException();
        }
    }
}

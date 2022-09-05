using DomainService.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace DomainService.Interface 
{
    public interface UserInterface 
    {
        ActionResult Create (UserRequest body);

    }
}

using CNCRM.Dto.Concrete;
using CNCRM.Service.Concrete;
using CNCRM.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace CNCRM.Api.Controllers
{
    public class UserComputerController : BaseController
    {
        UserComputerService userComputerService;
        [HttpGet]
        public ServiceResponse GetAll()
        {
            userComputerService = new UserComputerService();
            return userComputerService.GetAll();
        }
        [HttpGet]
        public ServiceResponse GetById(int id)
        {
            userComputerService = new UserComputerService();
            return userComputerService.GetById(id);
        }

        [HttpPost]
        public ServiceResponse Insert(UserComputerDto dto)
        {
            userComputerService = new UserComputerService();
            return userComputerService.Insert(dto);
        }
        [HttpPost]
        public ServiceResponse InsertAndComplete(UserComputerDto dto)
        {
            userComputerService = new UserComputerService();
            return userComputerService.InsertAndComplete(dto);
        }

        [HttpPut]
        public ServiceResponse Update(UserComputerDto dto)
        {
            userComputerService = new UserComputerService();
            return userComputerService.Update(dto);
        }

        [HttpPut]
        public ServiceResponse UpdateAndComplete(UserComputerDto dto)
        {
            userComputerService = new UserComputerService();
            return userComputerService.UpdateAndComplete(dto);
        }

        [HttpDelete]
        public ServiceResponse Delete(UserComputerDto dto)
        {
            userComputerService = new UserComputerService();
            return userComputerService.Delete(dto);
        }

        [HttpDelete]
        public ServiceResponse DeleteAndComplete(UserComputerDto dto)
        {
            userComputerService = new UserComputerService();
            return userComputerService.DeleteAndComplete(dto);
        }
    }
}

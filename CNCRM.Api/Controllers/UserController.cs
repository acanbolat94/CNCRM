using CNCRM.Dto.Concrete;
using CNCRM.Service.Concrete;
using CNCRM.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace CNCRM.Api.Controllers
{
    public class UserController : BaseController
    {
        UserService userService;
        [HttpGet]
        public ServiceResponse GetAll()
        {
            userService = new UserService();
            return userService.GetAll();
        }
        [HttpGet]
        public ServiceResponse GetById(int id)
        {
            userService = new UserService();
            return userService.GetById(id);
        }

        [HttpPost]
        public ServiceResponse Insert(UserDto dto)
        {
            userService = new UserService();
            return userService.Insert(dto);
        }
        [HttpPost]
        public ServiceResponse InsertAndComplete(UserDto dto)
        {
            userService = new UserService();
            return userService.InsertAndComplete(dto);
        }

        [HttpPut]
        public ServiceResponse Update(UserDto dto)
        {
            userService = new UserService();
            return userService.Update(dto);
        }

        [HttpPut]
        public ServiceResponse UpdateAndComplete(UserDto dto)
        {
            userService = new UserService();
            return userService.UpdateAndComplete(dto);
        }

        [HttpDelete]
        public ServiceResponse Delete(UserDto dto)
        {
            userService = new UserService();
            return userService.Delete(dto);
        }

        [HttpDelete]
        public ServiceResponse DeleteAndComplete(UserDto dto)
        {
            userService = new UserService();
            return userService.DeleteAndComplete(dto);
        }
    }
}

/*todo:cn=>
 *api controller tum siniflar icin yazildi ve calistigi gozlemlendi.
 *angularjs kurulumu yapildi
 *layout sayfasi duzenlendi
 *backupunit icin bir sayfa tasarimi yapildi
 *customer sayfasi tasarimi yapilacak
 */
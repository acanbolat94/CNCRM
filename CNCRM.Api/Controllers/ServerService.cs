using CNCRM.Dto.Concrete;
using CNCRM.Service.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CNCRM.Api.Controllers
{
    public class ServerService : BaseController
    {
        ServerService serverService;
        [HttpGet]
        public ServiceResponse GetAll()
        {
            serverService = new ServerService();
            return serverService.GetAll();
        }
        [HttpGet]
        public ServiceResponse GetById(int id)
        {
            serverService = new ServerService();
            return serverService.GetById(id);
        }

        [HttpPost]
        public ServiceResponse Insert(ServerDto dto)
        {
            serverService = new ServerService();
            return serverService.Insert(dto);
        }
        [HttpPost]
        public ServiceResponse InsertAndComplete(ServerDto dto)
        {
            serverService = new ServerService();
            return serverService.InsertAndComplete(dto);
        }

        [HttpPut]
        public ServiceResponse Update(ServerDto dto)
        {
            serverService = new ServerService();
            return serverService.Update(dto);
        }

        [HttpPut]
        public ServiceResponse UpdateAndComplete(ServerDto dto)
        {
            serverService = new ServerService();
            return serverService.UpdateAndComplete(dto);
        }

        [HttpDelete]
        public ServiceResponse Delete(ServerDto dto)
        {
            serverService = new ServerService();
            return serverService.Delete(dto);
        }

        [HttpDelete]
        public ServiceResponse DeleteAndComplete(ServerDto dto)
        {
            serverService = new ServerService();
            return serverService.DeleteAndComplete(dto);
        }
    }
}

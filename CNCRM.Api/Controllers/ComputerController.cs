using CNCRM.Dto.Concrete;
using CNCRM.Service.Concrete;
using CNCRM.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace CNCRM.Api.Controllers
{
    public class ComputerController : BaseController
    {
        ComputerService computerService;
        [HttpGet]
        public ServiceResponse GetAll()
        {
            computerService = new ComputerService();
            return computerService.GetAll();
        }
        [HttpGet]
        public ServiceResponse GetById(int id)
        {
            computerService = new ComputerService();
            return computerService.GetById(id);
        }

        [HttpPost]
        public ServiceResponse Insert(ComputerDto dto)
        {
            computerService = new ComputerService();
            return computerService.Insert(dto);
        }
        [HttpPost]
        public ServiceResponse InsertAndComplete(ComputerDto dto)
        {
            computerService = new ComputerService();
            return computerService.InsertAndComplete(dto);
        }

        [HttpPut]
        public ServiceResponse Update(ComputerDto dto)
        {
            computerService = new ComputerService();
            return computerService.Update(dto);
        }

        [HttpPut]
        public ServiceResponse UpdateAndComplete(ComputerDto dto)
        {
            computerService = new ComputerService();
            return computerService.UpdateAndComplete(dto);
        }

        [HttpDelete]
        public ServiceResponse Delete(ComputerDto dto)
        {
            computerService = new ComputerService();
            return computerService.Delete(dto);
        }

        [HttpDelete]
        public ServiceResponse DeleteAndComplete(ComputerDto dto)
        {
            computerService = new ComputerService();
            return computerService.DeleteAndComplete(dto);
        }
    }
}

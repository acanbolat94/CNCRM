using CNCRM.Dto.Concrete;
using CNCRM.Service.Concrete;
using CNCRM.Service.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CNCRM.Api.Controllers
{
    public class BackupUnitController : BaseController
    {
        BackupUnitService backupUnitService;
        [HttpGet]
        public ServiceResponse GetAll()
        {
            backupUnitService = new BackupUnitService();
            return backupUnitService.GetAll();
        }
        [HttpGet]
        public ServiceResponse GetById(int id)
        {
            backupUnitService = new BackupUnitService();
            return backupUnitService.GetById(id);
        }

        [HttpPost]
        public ServiceResponse Insert(BackupUnitDto dto)
        {
            backupUnitService = new BackupUnitService();
            return backupUnitService.Insert(dto);
        }
        [HttpPost]
        public ServiceResponse InsertAndComplete(BackupUnitDto dto)
        {
            backupUnitService = new BackupUnitService();
            return backupUnitService.InsertAndComplete(dto);
        }

        [HttpPut]
        public ServiceResponse Update(BackupUnitDto dto)
        {
            backupUnitService = new BackupUnitService();
            return backupUnitService.Update(dto);
        }

        [HttpPut]
        public ServiceResponse UpdateAndComplete(BackupUnitDto dto)
        {
            backupUnitService = new BackupUnitService();
            return backupUnitService.UpdateAndComplete(dto);
        }

        [HttpDelete]
        public ServiceResponse Delete(BackupUnitDto dto)
        {
            backupUnitService = new BackupUnitService();
            return backupUnitService.Delete(dto);
        }

        [HttpDelete]
        public ServiceResponse DeleteAndComplete(BackupUnitDto dto)
        {
            backupUnitService = new BackupUnitService();
            return backupUnitService.DeleteAndComplete(dto);
        }
    }
}


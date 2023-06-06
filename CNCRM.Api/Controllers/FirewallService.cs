using CNCRM.Dto.Concrete;
using CNCRM.Service.Concrete;
using CNCRM.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace CNCRM.Api.Controllers
{
    public class FirewallService : BaseController
    {
        FirewallService firewallService;
        [HttpGet]
        public ServiceResponse GetAll()
        {
            firewallService = new FirewallService();
            return firewallService.GetAll();
        }
        [HttpGet]
        public ServiceResponse GetById(int id)
        {
            firewallService = new FirewallService();
            return firewallService.GetById(id);
        }

        [HttpPost]
        public ServiceResponse Insert(FirewallDto dto)
        {
            firewallService = new FirewallService();
            return firewallService.Insert(dto);
        }
        [HttpPost]
        public ServiceResponse InsertAndComplete(FirewallDto dto)
        {
            firewallService = new FirewallService();
            return firewallService.InsertAndComplete(dto);
        }

        [HttpPut]
        public ServiceResponse Update(FirewallDto dto)
        {
            firewallService = new FirewallService();
            return firewallService.Update(dto);
        }

        [HttpPut]
        public ServiceResponse UpdateAndComplete(FirewallDto dto)
        {
            firewallService = new FirewallService();
            return firewallService.UpdateAndComplete(dto);
        }

        [HttpDelete]
        public ServiceResponse Delete(FirewallDto dto)
        {
            firewallService = new FirewallService();
            return firewallService.Delete(dto);
        }

        [HttpDelete]
        public ServiceResponse DeleteAndComplete(FirewallDto dto)
        {
            firewallService = new FirewallService();
            return firewallService.DeleteAndComplete(dto);
        }
    }
}

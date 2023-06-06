using CNCRM.Dto.Concrete;
using CNCRM.Service.Concrete;
using CNCRM.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace CNCRM.Api.Controllers
{
    public class CustomerController : BaseController
    {
        CustomerService customerService;
        [HttpGet]
        public ServiceResponse GetAll()
        {
            customerService = new CustomerService();
            return customerService.GetAll();
        }
        [HttpGet]
        public ServiceResponse GetById(int id)
        {
            customerService = new CustomerService();
            return customerService.GetById(id);
        }

        [HttpPost]
        public ServiceResponse Insert(CustomerDto dto)
        {
            customerService = new CustomerService();
            return customerService.Insert(dto);
        }
        [HttpPost]
        public ServiceResponse InsertAndComplete(CustomerDto dto)
        {
            customerService = new CustomerService();
            return customerService.InsertAndComplete(dto);
        }

        [HttpPut]
        public ServiceResponse Update(CustomerDto dto)
        {
            customerService = new CustomerService();
            return customerService.Update(dto);
        }

        [HttpPut]
        public ServiceResponse UpdateAndComplete(CustomerDto dto)
        {
            customerService = new CustomerService();
            return customerService.UpdateAndComplete(dto);
        }

        [HttpDelete]
        public ServiceResponse Delete(CustomerDto dto)
        {
            customerService = new CustomerService();
            return customerService.Delete(dto);
        }

        [HttpDelete]
        public ServiceResponse DeleteAndComplete(CustomerDto dto)
        {
            customerService = new CustomerService();
            return customerService.DeleteAndComplete(dto);
        }

        //[HttpDelete]
        //public ServiceResponse Delete(int id)
        //{
        //    customerService = new CustomerService();
        //    return customerService.Delete(id);
        //}

        //[HttpDelete]
        //public ServiceResponse DeleteAndComplete(int id)
        //{
        //    customerService = new CustomerService();
        //    return customerService.DeleteAndComplete(id);
        //}
    }
}

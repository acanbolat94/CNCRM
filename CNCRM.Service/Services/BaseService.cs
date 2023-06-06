using CNCRM.Entity.Context;
using CNCRM.Repository.Abstract;
using CNCRM.Service.Concrete;
using System;
using System.Linq;

namespace CNCRM.Service.Services
{
    public class BaseService<TRepository, TDto, TEntity> where TRepository : IBaseRepository<TEntity>
    {
        public SingletonContext<CNCRMContext> singleTon { get; set; } = new SingletonContext<CNCRMContext>();
        TRepository repository { get; set; }
        protected ServiceResponse response { get; set; }
        public BaseService()
        {
            repository = (TRepository)Activator.CreateInstance(typeof(TRepository), singleTon.DbContext);
        }
        public ServiceResponse GetById(int id)
        {
            try
            {
                response = new ServiceResponse();
                var entity = Mapping.Mapper.Map<TEntity>(repository.GetById(id));
                response.Data = entity;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
                response.ResponseType = Enum.ResponseType.error;
            }
            return response;
        }

        public ServiceResponse GetAll()
        {
            try
            {
                response = new ServiceResponse();
                var entity = repository.GetAll().ToList();
                response.Data = entity;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
                response.ResponseType = Enum.ResponseType.error;
            }
            return response;
        }

        public ServiceResponse Insert(TDto dto)
        {
            try
            {
                response = new ServiceResponse();
                var entity = Mapping.Mapper.Map<TEntity>(dto);
                repository.Insert(entity);
                response.Data = entity;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
                response.ResponseType = Enum.ResponseType.error;
            }
            return response;
        }

        public ServiceResponse InsertAndComplete(TDto dto)
        {
            try
            {
                response = new ServiceResponse();
                var entity = Mapping.Mapper.Map<TEntity>(dto);
                repository.InsertAndComplete(entity);
                response.Data = entity;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
                response.ResponseType = Enum.ResponseType.error;
            }
            return response;
        }

        public ServiceResponse Update(TDto dto)
        {
            try
            {
                response = new ServiceResponse();
                var entity = Mapping.Mapper.Map<TEntity>(dto);
                repository.Update(entity);
                response.Data = entity;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
                response.ResponseType = Enum.ResponseType.error;
            }
            return response;
        }

        public ServiceResponse UpdateAndComplete(TDto dto)
        {
            try
            {
                response = new ServiceResponse();
                var entity = Mapping.Mapper.Map<TEntity>(dto);
                repository.UpdateAndComplete(entity);
                response.Data = entity;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
                response.ResponseType = Enum.ResponseType.error;
            }
            return response;
        }

        //public ServiceResponse Delete(TDto dto)
        //{
        //    try
        //    {
        //        response = new ServiceResponse();
        //        var entity = Mapping.Mapper.Map<TEntity>(dto);
        //        repository.Delete(entity);
        //        response.Data = entity;
        //    }
        //    catch (Exception ex)
        //    {
        //        response.Success = false;
        //        response.ErrorMessage = ex.Message;
        //        response.ResponseType = Enum.ResponseType.error;
        //    }
        //    return response;
        //}

        //public ServiceResponse DeleteAndComplete(int id)
        //{
        //    try
        //    {
        //        response = new ServiceResponse();
        //        var entity = Mapping.Mapper.Map<TEntity>(repository.GetById(id));
        //        repository.DeleteAndComplete(entity);
        //        response.Data = entity;
        //    }
        //    catch (Exception ex)
        //    {
        //        response.Success = false;
        //        response.ErrorMessage = ex.Message;
        //        response.ResponseType = Enum.ResponseType.error;
        //    }
        //    return response;
        //}

        public ServiceResponse Delete(TDto dto)
        {
            try
            {
                response = new ServiceResponse();
                var entity = Mapping.Mapper.Map<TEntity>(dto);
                repository.Delete(entity);
                response.Data = entity;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
                response.ResponseType = Enum.ResponseType.error;
            }
            return response;
        }

        public ServiceResponse DeleteAndComplete(TDto dto)
        {
            try
            {
                response = new ServiceResponse();
                var entity = Mapping.Mapper.Map<TEntity>(dto);
                repository.DeleteAndComplete(entity);
                response.Data = entity;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
                response.ResponseType = Enum.ResponseType.error;
            }
            return response;
        }
    }
}

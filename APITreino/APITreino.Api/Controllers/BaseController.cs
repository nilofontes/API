using APITreino.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using APITreino.Repository;
using AutoMapper;

namespace APITreino.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<D,T,R> : ControllerBase where T : BaseModel where R : BaseRepository<T>
    {
        private R _repository;
        public IMapper _mapper;

        public BaseController(IMapper mapper)
        {
            this._repository = Activator.CreateInstance<R>();
            this._mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<T> GetAll() 
        {
            IEnumerable<T> listOccs = _repository.GetAll();
            return listOccs;
        }

        [HttpPost]
        public void Create(D dto)
        {
            T model = this._mapper.Map<T>(dto);           
            this._repository.Create(model);
        }
    }
}

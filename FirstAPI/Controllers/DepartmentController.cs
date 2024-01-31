using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstAPI.Interfaces;
using FirstAPI.Repositories;
using FirstAPI.Models;
namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        IRepository<int, Departmnet> _repo;
        public DepartmentController(IRepository<int, Departmnet> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<List<Departmnet>> GetDepartmnets()
        {
            var departments = await _repo.GetAsync();
            return departments;
        }
        [HttpPost]
        public async Task<Departmnet> Post(Departmnet departmnet)
        {
            departmnet = await _repo.Add(departmnet);
            return departmnet;
        }
    }
}

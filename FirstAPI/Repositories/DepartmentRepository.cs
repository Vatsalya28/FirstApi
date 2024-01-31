using FirstAPI.Contexts;
using FirstAPI.Interfaces;
using FirstAPI.Models;

namespace FirstAPI.Repositories

{
    public class DepartmentRepository : IRepository<int, Departmnet>
    {
        readonly RequestTarkerContext _context;
        public DepartmentRepository(RequestTarkerContext context)
        {
            _context = context;
        }
        public async Task<Departmnet> Add(Departmnet item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return item;
        }

        public async Task<Departmnet> Delete(int key)
        {
            var department = await GetAsync(key);
            _context? Departmnets.Remove(department);
            return department;
        }

        public async Task<Departmnet> GetAsync(int key)
        {
            var departments = await GetAsync();
            var department = departments.FirstOrDefault(d => d.DeparmentNumber == key);
            if(department != null) {
                return department;
            }
            else
            {
                throw new NoSuchDepartmentException;
            }
        }

        public async Task<List<Departmnet>> GetAsync()
        {
            var departments = _context.Departments.ToList();
            return departments;
        }

        public Task<Departmnet> Update(Departmnet item)
        {
            throw new NotImplementedException();
        }
    }
}

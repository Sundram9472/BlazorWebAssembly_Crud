using BlazorWebAssembly_Crud.Server.DBContext;
using BlazorWebAssembly_Crud.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAssembly_Crud.Server.Services
{
    public class EmployeeManager : IEmployeeManager
    {
        readonly ApplicationContext _dbContext;
        public EmployeeManager(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Employee> GetEmpDetails()
        {
            try
            {
                return _dbContext.Employees_sk.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void AddEmp(Employee user)
        {
            try
            {
                _dbContext.Employees_sk.Add(user);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar user
        public void UpdateEmpDetails(Employee user)
        {
            try
            {
                _dbContext.Entry(user).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular user
        public Employee GetEmpData(int id)
        {
            try
            {
                Employee? user = _dbContext.Employees_sk.Find(id);
                if (user != null)
                {
                    return user;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular user
        public void DeleteEmp(int id)
        {
            try
            {
                Employee? user = _dbContext.Employees_sk.Find(id);
                if (user != null)
                {
                    _dbContext.Employees_sk.Remove(user);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}

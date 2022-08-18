using BlazorWebAssembly_Crud.Shared.Models;

namespace BlazorWebAssembly_Crud.Server.Services
{
    public interface IEmployeeManager
    {
        List<Employee> GetEmpDetails();
        void DeleteEmp(int id);
        void UpdateEmpDetails(Employee user);
        void AddEmp(Employee user);
        Employee GetEmpData(int id);
    }
}
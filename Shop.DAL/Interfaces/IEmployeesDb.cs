using Shop.DAL.Models;

namespace Shop.DAL.Interfaces
{
    public interface IEmployeesDb
    {
        List<EmployeesModel> GetEmployees();
        EmployeesModel GetEmployee(int employeeId);
        void SaveEmployee(EmployeesAddModel employeeAdd);
        void UpdateEmployee(EmployeesUpdateModel employeesUpdate);
        void RemoveEmployee(EmployeesRemovesModel employeesRemove);
    }
}

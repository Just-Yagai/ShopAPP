using Shop.DAL.Context;
using Shop.DAL.Entities;
using Shop.DAL.Interfaces;
using Shop.DAL.Models;

namespace Shop.DAL.Daos
{
    public class EmployeesDb : IEmployeesDb
    {
        private readonly ShopContext context;
        public EmployeesDb(ShopContext context) 
        {  
            this.context = context; 
        }
        public EmployeesModel GetEmployee(int employeeId)
        {
            var employee = context.Employees.FirstOrDefault(e => e.EmpId == employeeId);
            if (employee == null) return null;

            return new EmployeesModel
            {
                EmpId = employee.EmpId,
                LastName = employee.LastName,
                FirstName = employee.FirstName,
                Title = employee.Title,
                TitleOfCourtesy = employee.TitleOfCourtesy,
                BirthDate = employee.BirthDate,
                HireDate = employee.HireDate,
                Address = employee.Address,
                City = employee.City,
                Region = employee.Region,
                PostalCode = employee.PostalCode,
                Country = employee.Country,
                Phone = employee.Phone,
                MgrId = employee.MgrId,
                CreationDate = employee.CreationDate,
                CreationUser = employee.CreationUser,
                ModifyDate = employee.ModifyDate,
                ModifyUser = employee.ModifyUser,
                DeleteUser = employee.DeleteUser,
                DeleteDate = employee.DeleteDate,
                Deleted = employee.Deleted
            };
        }

        public List<EmployeesModel> GetEmployees()
        {
            return context.Employees.Select(e => new EmployeesModel
            {
                EmpId = e.EmpId,
                LastName = e.LastName,
                FirstName = e.FirstName,
                Title = e.Title,
                TitleOfCourtesy = e.TitleOfCourtesy,
                BirthDate = e.BirthDate,
                HireDate = e.HireDate,
                Address = e.Address,
                City = e.City,
                Region = e.Region,
                PostalCode = e.PostalCode,
                Country = e.Country,
                Phone = e.Phone,
                MgrId = e.MgrId,
                CreationDate = e.CreationDate,
                CreationUser = e.CreationUser,
                ModifyDate = e.ModifyDate,
                ModifyUser = e.ModifyUser,
                DeleteUser = e.DeleteUser,
                DeleteDate = e.DeleteDate,
                Deleted = e.Deleted
            }).ToList();
        }

        public void RemoveEmployee(EmployeesRemovesModel employeeRemove)
        {
            var employee = context.Employees.FirstOrDefault(e => e.EmpId == employeeRemove.EmpId);
            if (employee != null)
            {
                employee.Deleted = employeeRemove.Deleted;
                employee.DeleteUser = employeeRemove.DeleteUser;
                employee.DeleteDate = employeeRemove.DeleteDate;

                context.Employees.Update(employee);
                context.SaveChanges();
            }
        }

        public void SaveEmployee(EmployeesAddModel employeeSave)
        {
            var employee = new Employees
            {
                LastName = employeeSave.LastName,
                FirstName = employeeSave.FirstName,
                Title = employeeSave.Title,
                TitleOfCourtesy = employeeSave.TitleOfCourtesy,
                BirthDate = employeeSave.BirthDate,
                HireDate = employeeSave.HireDate,
                Address = employeeSave.Address,
                City = employeeSave.City,
                Region = employeeSave.Region,
                PostalCode = employeeSave.PostalCode,
                Country = employeeSave.Country,
                Phone = employeeSave.Phone,
                MgrId = employeeSave.MgrId,
                CreationDate = employeeSave.CreationDate,
                CreationUser = employeeSave.CreationUser
            };
            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public void UpdateEmployee(EmployeesUpdateModel employeeUpdate)
        {
            var employee = context.Employees.FirstOrDefault(e => e.EmpId == employeeUpdate.EmpId);

            if (employee != null)
            {
                employee.LastName = employeeUpdate.LastName;
                employee.FirstName = employeeUpdate.FirstName;
                employee.Title = employeeUpdate.Title;
                employee.TitleOfCourtesy = employeeUpdate.TitleOfCourtesy;
                employee.BirthDate = employeeUpdate.BirthDate;
                employee.HireDate = employeeUpdate.HireDate;
                employee.Address = employeeUpdate.Address;
                employee.City = employeeUpdate.City;
                employee.Region = employeeUpdate.Region;
                employee.PostalCode = employeeUpdate.PostalCode;
                employee.Country = employeeUpdate.Country;
                employee.Phone = employeeUpdate.Phone;
                employee.MgrId = employeeUpdate.MgrId;
                employee.ModifyDate = employeeUpdate.ModifyDate;
                employee.ModifyUser = employeeUpdate.ModifyUser;
                context.SaveChanges();
            }
        }
    }
}

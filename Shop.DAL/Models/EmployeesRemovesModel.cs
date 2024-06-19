namespace Shop.DAL.Models
{
    public class EmployeesRemovesModel
    {
        public int EmpId { get; set; }
        public DateTime DeleteDate { get; set; }
        public int DeleteUser { get; set; }
        public bool Deleted { get; set; }
    }
}


namespace ManageStaffDBApp.Model
{
    public class Position
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public int MaxNumber { get; set; }
        public List<User>? Users { get; set; }
        public int DepartmentID { get; set; }
        public virtual Department? Department { get; set; }
    }
}


namespace ManageStaffDBApp.Model
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public int PositionID { get; set; }
        public virtual Position Position { get; set; }
    }
}

﻿
namespace ManageStaffDBApp.Model
{
    public class Department
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public List<Position>? Positions { get; set; }
    }
}

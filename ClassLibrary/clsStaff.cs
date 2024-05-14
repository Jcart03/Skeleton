using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public string StaffAddress { get; set; }
        public string StaffEmail { get; set; }
        public DateTime StartingDate { get; set; }
        public decimal StaffSalary { get; set; }
        public bool IsManager { get; set; }
    }
}
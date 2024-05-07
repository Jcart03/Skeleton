using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public Int32 OrderId { get; set; }
        public string CustomerName { get; set; }
        public string StaffName { get; set; }
        public string OrderNotes { get; set; }
        public DateTime OrderDate { get; set; }
        public TimeSpan OrderTime { get; set; }
        public bool OrderShipped { get; set; }

    }
}
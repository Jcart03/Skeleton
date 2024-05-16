using System;

namespace ClassLibrary
{
    public class clsSuppliers
    {
        public bool Active { get; set; }
        public int SuppliersId { get; set; }
        public string SuppliersName { get; set; }
        public string SuppliersAddress { get; set; }
        public string PaymentTerms { get; set; }
        public DateTime ContractStart { get; set; }
        public bool IsActive { get; set; }
        public int ContactNumber { get; set; }
    }
}
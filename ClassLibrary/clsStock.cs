using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Active { get; set; }
        public int ShoeId { get; set; }
        public int ShoeSize { get; set; }
        public string ShoeColour { get; set; }
        public int ShoePrice { get; set; }
        public string ShoeBrand { get; set; }
        public bool ShoeAvailability { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
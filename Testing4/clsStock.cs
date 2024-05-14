using System;

namespace Testing4
{
    internal class clsStock
    {
        public bool Active { get; internal set; }
        public int ShoeId { get; internal set; }
        public int ShoeSize { get; internal set; }
        public DateTime DateAdded { get; internal set; }
        public string ShoeColour { get; internal set; }
        public int ShoePrice { get; internal set; }
        public string ShoeBrand { get; internal set; }
        public bool ShoeAvailability { get; internal set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutomobileLibary.DataAccess
{
    public partial class Cars
    {
        
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public int ReleasedYear { get; set; }
    }
}

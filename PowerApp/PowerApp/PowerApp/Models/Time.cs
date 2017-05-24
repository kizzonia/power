using System;
using System.Collections.Generic;
using System.Linq;


namespace PowerApp.Models
{
    public class Time
    {
        public Guid ID { get; set; }
        public DateTime from { get; set; }
        public DateTime to { get; set; }
    }
}
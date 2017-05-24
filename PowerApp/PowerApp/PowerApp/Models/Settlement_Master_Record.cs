using System;
using System.Collections.Generic;
using System.Linq;


namespace PowerApp.Models
{
    public class Settlement_Master_Record
    {
        public Guid ID { get; set; }
        public DateTime date { get; set; }
        public ICollection<Settlement_Record> Settlement_Records { get; set; }
    }
}
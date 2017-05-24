using System;
using System.Collections.Generic;
using System.Linq;


namespace PowerApp.Models
{
    public class Record
    {
        public Guid ID { get; set; }
        public DateTime date { get; set; }
        public virtual ICollection<OPRecord> Operation_Reports { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;


namespace PowerApp.Models
{
    public class Settlement_Record
    {
        public Guid ID { get; set; }
        public Guid TimeID { get; set; }
        public Guid TurbineID { get; set; }
        public Guid Settlement_MasterID { get; set; }
        public DateTime time { get; set; }
        public virtual Turbine Turbine { get; set; }
        public virtual Settlement_Master_Record Settlement_Master { get; set; }
        public virtual Time Time { get; set; }
        public double? IG5 { get; set; }
        public double? IG6 { get; set; }
        public double? IG11 { get; set; }
        public double? IG12 { get; set; }
    }
}
namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bot_Items
    {
        public int ID { get; set; }
        public int Bot_No { get; set; }
        public string Item_Code { get; set; }
        public double Qty { get; set; }
        public Nullable<short> flag { get; set; }
        public int @ref { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<double> ml { get; set; }
        public string Des { get; set; }
    }
}

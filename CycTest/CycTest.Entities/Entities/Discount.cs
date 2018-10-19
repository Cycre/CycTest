namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Discount
    {
        public double Item { get; set; }
        public double Cash { get; set; }
        public Nullable<decimal> cashAmt { get; set; }
    }
}

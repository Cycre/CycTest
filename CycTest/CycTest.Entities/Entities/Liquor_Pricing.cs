namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Liquor_Pricing
    {
        public string Discrip { get; set; }
        public int ID { get; set; }
        public Nullable<double> qty { get; set; }
        public Nullable<decimal> Price { get; set; }
    }
}

namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock_Cost
    {
        public string Stock_Card { get; set; }
        public decimal Avg_Cost { get; set; }
        public Nullable<decimal> Last_Cost { get; set; }
        public string usern { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> Ref { get; set; }
    }
}

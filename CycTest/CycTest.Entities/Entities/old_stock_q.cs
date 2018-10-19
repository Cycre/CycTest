namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class old_stock_q
    {
        public string Name { get; set; }
        public string TP { get; set; }
        public string address { get; set; }
        public Nullable<int> inv { get; set; }
        public string Stock_card { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public string Descrip { get; set; }
    }
}

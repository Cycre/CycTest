namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class price_bank
    {
        public string Item_Code { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<decimal> Retail_Price { get; set; }
        public Nullable<decimal> WS_Price { get; set; }
        public string Cashier { get; set; }
        public int ID { get; set; }
    }
}

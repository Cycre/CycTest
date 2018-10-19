namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item_Price
    {
        public string Item_code { get; set; }
        public Nullable<decimal> R_Price { get; set; }
        public Nullable<decimal> W_price { get; set; }
        public Nullable<double> Qty { get; set; }
        public int id { get; set; }
        public Nullable<System.DateTime> expire_date { get; set; }
    }
}

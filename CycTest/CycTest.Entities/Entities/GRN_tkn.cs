namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class GRN_tkn
    {
        public string sup { get; set; }
        public string stock_card { get; set; }
        public string itm { get; set; }
        public string rack { get; set; }
        public Nullable<double> qty { get; set; }
        public Nullable<decimal> ucost { get; set; }
        public Nullable<decimal> ws_min { get; set; }
        public Nullable<decimal> ws_max { get; set; }
        public Nullable<decimal> rtl_min { get; set; }
        public Nullable<decimal> rtl_max { get; set; }
        public string modl { get; set; }
        public Nullable<decimal> avg { get; set; }
        public Nullable<int> reordr { get; set; }
        public Nullable<short> maxordr { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> tkn { get; set; }
        public Nullable<decimal> sub { get; set; }
        public Nullable<double> foc { get; set; }
        public int ID { get; set; }
        public Nullable<System.DateTime> expire_date { get; set; }
        public string inv { get; set; }
    }
}
